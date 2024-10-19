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
    public partial class LäggTillFordon : Form
    {
        private LogicLayer logicLayer;
        public LäggTillFordon(LogicLayer logicLayer)
        {
            InitializeComponent();
            this.logicLayer = logicLayer;

            cmbStationer.DataSource = logicLayer.HämtaStationer(); 
            cmbStationer.DisplayMember = "Namn"; 
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            

            Station valdStation = (Station)cmbStationer.SelectedItem;

            Fordon nyttfordon = new Fordon(
                int.Parse(txtFordonID.Text),
                txtTyp.Text,
                int.Parse(txtBatteriNivå.Text),
                "Ledig",
                valdStation
            );

            logicLayer.LäggTillNyttFordon(nyttfordon);
            valdStation.AntalTillgängligaFordon.Add(nyttfordon);
            MessageBox.Show($"Fordon med ID {txtFordonID.Text} har lagts till : {valdStation.Namn}.");

            this.Close();

        } 

    
    }
}
