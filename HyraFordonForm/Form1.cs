using GreenwheelsAB;
using ServiceLayer;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
        public Anv�ndareHyra()
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
            DataGridViewAnv�ndare.DataSource = new BindingList<Anv�ndare>(logicLayer.H�mtaAnv�ndare());
        }
            

    }
}
