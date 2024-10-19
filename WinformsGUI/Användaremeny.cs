using GreenwheelsAB;
using ServiceLayer;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinformsGUI
{
    public partial class Användarmeny : Form
    {
        private LogicLayer logicLayer;
        
        public Användarmeny(LogicLayer logicLayer)
        {
            this.logicLayer = logicLayer;
            InitializeComponent();

            RefreshAllt();
        }
        
        private void btnRefreshAllt_Click(object sender, EventArgs e)
        {
            RefreshAllt();
        }


        public void RefreshAllt()
        {

            int? valtAnvändarID = null;
            if (dataGridViewAnvändare.CurrentRow != null)
            {
                valtAnvändarID = (int)dataGridViewAnvändare.CurrentRow.Cells["AnvändarID"].Value;
            }

            dataGridViewAnvändare.DataSource = new BindingList<Användare>(logicLayer.HämtaAnvändare());
            dataGridViewStationer.DataSource = new BindingList<Station>(logicLayer.HämtaStationer());

            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                Station station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;

                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillgängligaFordon(station));
             
            }
            else
            {
                dataGridViewFordon.DataSource = new BindingList<Fordon>();
            }

            if (valtAnvändarID != null)
            {
                foreach (DataGridViewRow row in dataGridViewAnvändare.Rows)
                {
                    if ((int)row.Cells["AnvändarID"].Value == valtAnvändarID)
                    {
                        row.Selected = true;
                        dataGridViewAnvändare.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            RefreshHyror();
        }




        private void dataGridViewStationer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                Station station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;

                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillgängligaFordon(station));

                if (dataGridViewFordon.Columns["Station"] != null) 
                {
                    dataGridViewFordon.Columns["Station"].Visible = false; 
                }

               
            }
            
        }

        private void btnHyra_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnvändare.SelectedRows.Count > 0 && dataGridViewFordon.SelectedRows.Count > 0 && dataGridViewStationer.SelectedRows.Count > 0)
            {
                var användare = (Användare)dataGridViewAnvändare.SelectedRows[0].DataBoundItem;
                var fordon = (Fordon)dataGridViewFordon.SelectedRows[0].DataBoundItem;
                var station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;

                bool lyckadesHyra = logicLayer.HyraFordon(användare, fordon, station);


                if (lyckadesHyra)
                {
                    MessageBox.Show($"Användare med ID {användare.AnvändarID} har hyrt fordon {fordon.FordonID}.", "Hyra Bekräftelse");
                    RefreshAllt();
                }
                else
                {
                    MessageBox.Show("Användaren har redan ett pågående hyresavtal och kan inte hyra fler fordon.", "Fel");
                }
            }
            else
            {
                MessageBox.Show("Välj både användare och fordon innan du hyr.", "Fel");
            }
        }

        private void btnAvslutaHyra_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnvändare.SelectedRows.Count > 0 && dataGridViewAktivhyra.SelectedRows.Count > 0 && dataGridViewStationer.SelectedRows.Count > 0)
            {
                var hyra = (Hyra)dataGridViewAktivhyra.SelectedRows[0].DataBoundItem;
                var station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;
                string resultat = logicLayer.AvslutaHyraOchVisaKostnad(hyra, station);


                MessageBox.Show(resultat, "Avsluta Hyra");

                RefreshAllt();
            }
            else
            {
                MessageBox.Show("Välj en aktiv hyra och en station att återlämna fordonet till.", "Fel");
            }
        }



        private void RefreshHyror()
        {
            if (dataGridViewAnvändare.CurrentRow != null)
            {
                var valdAnvändare = (Användare)dataGridViewAnvändare.CurrentRow.DataBoundItem;
                var aktivaHyror = logicLayer.HämtaAktivaHyror(valdAnvändare);

              
                dataGridViewAktivhyra.DataSource = new BindingList<Hyra>(aktivaHyror);

                if (dataGridViewAktivhyra.Columns["Användare"] != null)
                {
                    dataGridViewAktivhyra.Columns["Användare"].Visible = false;  
                }

                if (dataGridViewAktivhyra.Columns["Fordon"] != null)
                {
                    dataGridViewAktivhyra.Columns["Fordon"].Visible = false; 
                }
            }
            else
            {
                dataGridViewAktivhyra.DataSource = new BindingList<Hyra>();
            }
        }


       
        private void dataGridViewAnvändare_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            RefreshHyror();

        }

        private void btnVisaHyreshistorik_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnvändare.SelectedRows.Count > 0)
            {
                var valdAnvändare = (Användare)dataGridViewAnvändare.SelectedRows[0].DataBoundItem;

                List<Hyra> hyreshistorik = logicLayer.HämtaHyresHistorik(valdAnvändare);

               
                HyresHistorikForm historikForm = new HyresHistorikForm(hyreshistorik);
                historikForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Välj en användare för att visa hyreshistoriken.", "Ingen användare vald");
            }
        }


    }
}
