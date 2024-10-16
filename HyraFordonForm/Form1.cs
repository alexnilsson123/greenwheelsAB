using GreenwheelsAB;
using ServiceLayer;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
        public AnvändareHyra()
        {
            InitializeComponent();
        df
        hfgjhgjgjhgjg
        private void btnRefreshAllt_Click(object sender, EventArgs e)
        {

            RefreshAllt();

        }
        private void RefreshAllt()
        {
            DataGridViewAnvändare.DataSource = new BindingList<Användare>(logicLayer.HämtaAnvändare());
        }
            

    }
}
