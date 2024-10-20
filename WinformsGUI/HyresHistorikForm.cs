﻿using GreenwheelsAB;
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
    public partial class HyresHistorikForm : Form
    {
        public HyresHistorikForm(List<Hyra> hyreshistorik)
        {
            InitializeComponent();

            dataGridViewHyresHistorik.DataSource = new BindingList<Hyra>(hyreshistorik);
            if (dataGridViewHyresHistorik.Columns["Användare"] != null)
            {
                dataGridViewHyresHistorik.Columns["Användare"].Visible = false;  
            }

            if (dataGridViewHyresHistorik.Columns["Fordon"] != null)
            {
                dataGridViewHyresHistorik.Columns["Fordon"].Visible = false;  
            }

        }
    }
}
