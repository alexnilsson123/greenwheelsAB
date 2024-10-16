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
    public partial class VäljAnvändare : Form
    {
        LogicLayer logicLayer;
        public VäljAnvändare(LogicLayer logicLayer)
        {
            this.logicLayer = logicLayer;
            InitializeComponent();
        }

        private void btnAnvändare_Click(object sender, EventArgs e)
        {
            HyraFordon hyraFordon = new HyraFordon(logicLayer);

            hyraFordon.ShowDialog();


        }

        private void btnSystemadministratör_Click(object sender, EventArgs e)
        {
            AdminMeny adminMeny = new AdminMeny(logicLayer);
            adminMeny.ShowDialog();
        }
    }
}
