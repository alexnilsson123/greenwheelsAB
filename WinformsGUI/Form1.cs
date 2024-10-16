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
            
            int? valtAnv�ndarID = null;
            if (dataGridViewAnv�ndare.CurrentRow != null)
            {
                valtAnv�ndarID = (int)dataGridViewAnv�ndare.CurrentRow.Cells["Anv�ndarID"].Value;
            }

            
            dataGridViewAnv�ndare.DataSource = new BindingList<Anv�ndare>(logicLayer.H�mtaAnv�ndare());

           
            dataGridViewStationer.DataSource = new BindingList<Station>(logicLayer.H�mtaStationer());

            // Uppdatera fordonslistan om en station �r vald
            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value;
                
                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillg�ngligaFordon(stationID));

            }
            else
            {
                dataGridViewFordon.DataSource = new BindingList<Fordon>();
            }

            // �terst�ll det valda anv�ndar-ID:t om det finns
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
            // Uppdatera aktiva hyror f�r den valda anv�ndaren
            RefreshHyror();
        }

        private void dataGridViewStationer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStationer.SelectedRows.Count > 0)
            {
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value;
                dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.VisaTillg�ngligaFordon(stationID));
            }
        }

        private void btnHyra_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnv�ndare.SelectedRows.Count > 0 && dataGridViewFordon.SelectedRows.Count > 0 && dataGridViewStationer.SelectedRows.Count > 0)
            {
                int anv�ndarID = (int)dataGridViewAnv�ndare.SelectedRows[0].Cells["Anv�ndarID"].Value;
                int fordonID = (int)dataGridViewFordon.SelectedRows[0].Cells["FordonID"].Value;
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value;

                bool lyckadesHyra = logicLayer.HyraFordon(anv�ndarID, fordonID, stationID);

                if (lyckadesHyra)
                {
                    MessageBox.Show($"Anv�ndare med ID {anv�ndarID} har hyrt fordon {fordonID}.", "Hyra Bekr�ftelse");
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
                int anv�ndarID = (int)dataGridViewAnv�ndare.SelectedRows[0].Cells["Anv�ndarID"].Value;
                int hyraID = (int)dataGridViewAktivhyra.SelectedRows[0].Cells["HyraID"].Value;
                int stationID = (int)dataGridViewStationer.SelectedRows[0].Cells["StationID"].Value; // Vald station att �terl�mna fordonet

                string resultat = logicLayer.AvslutaHyraOchVisaKostnad(hyraID, stationID); // Skicka med stationID f�r �terl�mning

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

                int anv�ndarID = (int)dataGridViewAnv�ndare.CurrentRow.Cells["Anv�ndarID"].Value;


                var aktivaHyror = logicLayer.H�mtaAktivaHyror(anv�ndarID);

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


        private void dataGridViewAnv�ndare_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            RefreshHyror();

        }

        private void btnVisaHyreshistorik_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnv�ndare.SelectedRows.Count > 0)
            {

                int anv�ndarID = (int)dataGridViewAnv�ndare.SelectedRows[0].Cells["Anv�ndarID"].Value;


                List<Hyra> hyreshistorik = logicLayer.H�mtaHyresHistorik(anv�ndarID);


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
