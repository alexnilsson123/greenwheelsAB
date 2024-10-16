using GreenwheelsAB;
using ServiceLayer;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinformsGUI
{
    public partial class HyraFordon : Form
    {
        private LogicLayer logicLayer;
        
        public HyraFordon(LogicLayer logicLayer)
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

            // Uppdatera fordonslistan om en station är vald
            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value;
                
                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillgängligaFordon(stationID));

            }
            else
            {
                dataGridViewFordon.DataSource = new BindingList<Fordon>();
            }

            // Återställ det valda användar-ID:t om det finns
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
            // Uppdatera aktiva hyror för den valda användaren
            RefreshHyror();
        }

        private void dataGridViewStationer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value;
                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillgängligaFordon(stationID));
            }
        }

        private void btnHyra_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnvändare.SelectedRows.Count > 0 && dataGridViewFordon.SelectedRows.Count > 0 && dataGridViewStationer.SelectedRows.Count > 0)
            {
                int användarID = (int)dataGridViewAnvändare.SelectedRows[0].Cells["AnvändarID"].Value;
                int fordonID = (int)dataGridViewFordon.SelectedRows[0].Cells["FordonID"].Value;
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value;

                bool lyckadesHyra = logicLayer.HyraFordon(användarID, fordonID, stationID);

                if (lyckadesHyra)
                {
                    MessageBox.Show($"Användare med ID {användarID} har hyrt fordon {fordonID}.", "Hyra Bekräftelse");
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
                int användarID = (int)dataGridViewAnvändare.SelectedRows[0].Cells["AnvändarID"].Value;
                int hyraID = (int)dataGridViewAktivhyra.SelectedRows[0].Cells["HyraID"].Value;
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value; // Vald station att återlämna fordonet

                string resultat = logicLayer.AvslutaHyraOchVisaKostnad(hyraID, stationID); // Skicka med stationID för återlämning

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

                int användarID = (int)dataGridViewAnvändare.CurrentRow.Cells["AnvändarID"].Value;


                var aktivaHyror = logicLayer.HämtaAktivaHyror(användarID);

                // Kontrollera om det finns aktiva hyror och visa dessa i DataGridView
                if (aktivaHyror.Count > 0)
                {
                    dataGridViewAktivhyra.DataSource = new BindingList<Hyra>(aktivaHyror);
                }
                else
                {
                    // Om inga aktiva hyror finns, rensa DataGridView
                    dataGridViewAktivhyra.DataSource = new BindingList<Hyra>();
                }
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

                int användarID = (int)dataGridViewAnvändare.SelectedRows[0].Cells["AnvändarID"].Value;


                List<Hyra> hyreshistorik = logicLayer.HämtaHyresHistorik(användarID);


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
