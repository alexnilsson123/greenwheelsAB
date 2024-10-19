using GreenwheelsAB;
using ServiceLayer;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinformsGUI
{
    public partial class Anv�ndarmeny : Form
    {
        private LogicLayer logicLayer;
        
        public Anv�ndarmeny(LogicLayer logicLayer)
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

            int? valtAnv�ndarID = null;
            if (dataGridViewAnv�ndare.CurrentRow != null)
            {
                valtAnv�ndarID = (int)dataGridViewAnv�ndare.CurrentRow.Cells["Anv�ndarID"].Value;
            }

            dataGridViewAnv�ndare.DataSource = new BindingList<Anv�ndare>(logicLayer.H�mtaAnv�ndare());
            dataGridViewStationer.DataSource = new BindingList<Station>(logicLayer.H�mtaStationer());

            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                Station station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;

                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillg�ngligaFordon(station));
             
            }
            else
            {
                dataGridViewFordon.DataSource = new BindingList<Fordon>();
            }

            if (valtAnv�ndarID != null)
            {
                foreach (DataGridViewRow row in dataGridViewAnv�ndare.Rows)
                {
                    if ((int)row.Cells["Anv�ndarID"].Value == valtAnv�ndarID)
                    {
                        row.Selected = true;
                        dataGridViewAnv�ndare.CurrentCell = row.Cells[0];
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

                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillg�ngligaFordon(station));

                if (dataGridViewFordon.Columns["Station"] != null) 
                {
                    dataGridViewFordon.Columns["Station"].Visible = false; 
                }

               
            }
            
        }

        private void btnHyra_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnv�ndare.SelectedRows.Count > 0 && dataGridViewFordon.SelectedRows.Count > 0 && dataGridViewStationer.SelectedRows.Count > 0)
            {
                var anv�ndare = (Anv�ndare)dataGridViewAnv�ndare.SelectedRows[0].DataBoundItem;
                var fordon = (Fordon)dataGridViewFordon.SelectedRows[0].DataBoundItem;
                var station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;

                bool lyckadesHyra = logicLayer.HyraFordon(anv�ndare, fordon, station);


                if (lyckadesHyra)
                {
                    MessageBox.Show($"Anv�ndare med ID {anv�ndare.Anv�ndarID} har hyrt fordon {fordon.FordonID}.", "Hyra Bekr�ftelse");
                    RefreshAllt();
                }
                else
                {
                    MessageBox.Show("Anv�ndaren har redan ett p�g�ende hyresavtal och kan inte hyra fler fordon.", "Fel");
                }
            }
            else
            {
                MessageBox.Show("V�lj b�de anv�ndare och fordon innan du hyr.", "Fel");
            }
        }

        private void btnAvslutaHyra_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnv�ndare.SelectedRows.Count > 0 && dataGridViewAktivhyra.SelectedRows.Count > 0 && dataGridViewStationer.SelectedRows.Count > 0)
            {
                var hyra = (Hyra)dataGridViewAktivhyra.SelectedRows[0].DataBoundItem;
                var station = (Station)dataGridViewStationer.SelectedRows[0].DataBoundItem;
                string resultat = logicLayer.AvslutaHyraOchVisaKostnad(hyra, station);


                MessageBox.Show(resultat, "Avsluta Hyra");

                RefreshAllt();
            }
            else
            {
                MessageBox.Show("V�lj en aktiv hyra och en station att �terl�mna fordonet till.", "Fel");
            }
        }



        private void RefreshHyror()
        {
            if (dataGridViewAnv�ndare.CurrentRow != null)
            {
                var valdAnv�ndare = (Anv�ndare)dataGridViewAnv�ndare.CurrentRow.DataBoundItem;
                var aktivaHyror = logicLayer.H�mtaAktivaHyror(valdAnv�ndare);

              
                dataGridViewAktivhyra.DataSource = new BindingList<Hyra>(aktivaHyror);

                if (dataGridViewAktivhyra.Columns["Anv�ndare"] != null)
                {
                    dataGridViewAktivhyra.Columns["Anv�ndare"].Visible = false;  
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


       
        private void dataGridViewAnv�ndare_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            RefreshHyror();

        }

        private void btnVisaHyreshistorik_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnv�ndare.SelectedRows.Count > 0)
            {
                var valdAnv�ndare = (Anv�ndare)dataGridViewAnv�ndare.SelectedRows[0].DataBoundItem;

                List<Hyra> hyreshistorik = logicLayer.H�mtaHyresHistorik(valdAnv�ndare);

               
                HyresHistorikForm historikForm = new HyresHistorikForm(hyreshistorik);
                historikForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("V�lj en anv�ndare f�r att visa hyreshistoriken.", "Ingen anv�ndare vald");
            }
        }


    }
}
