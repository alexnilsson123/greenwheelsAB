using GreenwheelsAB;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsGUI
{
    public partial class AdminMeny : Form
    {
        private LogicLayer logicLayer;
        private Fordon valtFordon;
        public AdminMeny(LogicLayer logicLayer)
        {
            InitializeComponent();

            this.logicLayer = logicLayer;
            RefreshDataGridViewFordon();
        }

        private void btnRefreshFordon_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewFordon();
        }
        private void RefreshDataGridViewFordon()
        {
            dataGridViewFordon.DataSource = new BindingList<Fordon>(logicLayer.HämtaAllaFordon());

            if (dataGridViewFordon.Columns["Station"] != null)
            {
                dataGridViewFordon.Columns["Station"].Visible = false;
            }
        }

        private void dataGridViewFordon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valtFordon = dataGridViewFordon.SelectedRows[0].DataBoundItem as Fordon;

        }

        private void btnTaBortFordon_Click(object sender, EventArgs e)
        {

            if (valtFordon != null)
            {
                logicLayer.TaBortFordon(valtFordon);
                MessageBox.Show($" Fordon med ID {valtFordon.FordonID} har tagits bort från systemet :)");

            }
            RefreshDataGridViewFordon();

        }

        private void btnLäggTillFordon_Click(object sender, EventArgs e)
        {
            LäggTillFordon läggTillFordon = new LäggTillFordon(logicLayer);
            läggTillFordon.ShowDialog();
            RefreshDataGridViewFordon(); 

        }
    }
}
