namespace WinformsGUI
{
    partial class HyraFordon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAnvändare = new DataGridView();
            dataGridViewStationer = new DataGridView();
            lblAnvändare = new Label();
            lblStationer = new Label();
            btnRefreshAllt = new Button();
            dataGridViewFordon = new DataGridView();
            lblFordon = new Label();
            btnHyra = new Button();
            btnAvslutaHyra = new Button();
            dataGridViewAktivhyra = new DataGridView();
            lblHyror = new Label();
            label1 = new Label();
            btnVisaHyreshistorik = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnvändare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStationer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFordon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAktivhyra).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnvändare
            // 
            dataGridViewAnvändare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnvändare.Location = new Point(64, 51);
            dataGridViewAnvändare.MultiSelect = false;
            dataGridViewAnvändare.Name = "dataGridViewAnvändare";
            dataGridViewAnvändare.ReadOnly = true;
            dataGridViewAnvändare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnvändare.Size = new Size(603, 228);
            dataGridViewAnvändare.TabIndex = 0;
            // 
            // dataGridViewStationer
            // 
            dataGridViewStationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStationer.Location = new Point(55, 334);
            dataGridViewStationer.MultiSelect = false;
            dataGridViewStationer.Name = "dataGridViewStationer";
            dataGridViewStationer.ReadOnly = true;
            dataGridViewStationer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStationer.Size = new Size(612, 218);
            dataGridViewStationer.TabIndex = 1;
            dataGridViewStationer.CellClick += dataGridViewStationer_CellClick;
            // 
            // lblAnvändare
            // 
            lblAnvändare.AutoSize = true;
            lblAnvändare.Location = new Point(64, 33);
            lblAnvändare.Name = "lblAnvändare";
            lblAnvändare.Size = new Size(64, 15);
            lblAnvändare.TabIndex = 2;
            lblAnvändare.Text = "Användare";
            // 
            // lblStationer
            // 
            lblStationer.AutoSize = true;
            lblStationer.Location = new Point(55, 316);
            lblStationer.Name = "lblStationer";
            lblStationer.Size = new Size(54, 15);
            lblStationer.TabIndex = 3;
            lblStationer.Text = "Stationer";
            // 
            // btnRefreshAllt
            // 
            btnRefreshAllt.Location = new Point(55, 682);
            btnRefreshAllt.Name = "btnRefreshAllt";
            btnRefreshAllt.Size = new Size(168, 50);
            btnRefreshAllt.TabIndex = 4;
            btnRefreshAllt.Text = "Refresh";
            btnRefreshAllt.UseVisualStyleBackColor = true;
            btnRefreshAllt.Click += btnRefreshAllt_Click;
            // 
            // dataGridViewFordon
            // 
            dataGridViewFordon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFordon.Location = new Point(715, 334);
            dataGridViewFordon.MultiSelect = false;
            dataGridViewFordon.Name = "dataGridViewFordon";
            dataGridViewFordon.ReadOnly = true;
            dataGridViewFordon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFordon.Size = new Size(669, 218);
            dataGridViewFordon.TabIndex = 5;
            // 
            // lblFordon
            // 
            lblFordon.AutoSize = true;
            lblFordon.Location = new Point(715, 316);
            lblFordon.Name = "lblFordon";
            lblFordon.Size = new Size(45, 15);
            lblFordon.TabIndex = 6;
            lblFordon.Text = "Fordon";
            // 
            // btnHyra
            // 
            btnHyra.Location = new Point(1252, 681);
            btnHyra.Name = "btnHyra";
            btnHyra.Size = new Size(189, 50);
            btnHyra.TabIndex = 7;
            btnHyra.Text = "Hyr Fordon";
            btnHyra.UseVisualStyleBackColor = true;
            btnHyra.Click += btnHyra_Click;
            // 
            // btnAvslutaHyra
            // 
            btnAvslutaHyra.Location = new Point(1021, 681);
            btnAvslutaHyra.Name = "btnAvslutaHyra";
            btnAvslutaHyra.Size = new Size(189, 51);
            btnAvslutaHyra.TabIndex = 8;
            btnAvslutaHyra.Text = "Avsluta Hyra";
            btnAvslutaHyra.UseVisualStyleBackColor = true;
            btnAvslutaHyra.Click += btnAvslutaHyra_Click;
            // 
            // dataGridViewAktivhyra
            // 
            dataGridViewAktivhyra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAktivhyra.Location = new Point(715, 51);
            dataGridViewAktivhyra.MultiSelect = false;
            dataGridViewAktivhyra.Name = "dataGridViewAktivhyra";
            dataGridViewAktivhyra.ReadOnly = true;
            dataGridViewAktivhyra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAktivhyra.Size = new Size(669, 228);
            dataGridViewAktivhyra.TabIndex = 9;
            // 
            // lblHyror
            // 
            lblHyror.AutoSize = true;
            lblHyror.Location = new Point(715, 33);
            lblHyror.Name = "lblHyror";
            lblHyror.Size = new Size(73, 15);
            lblHyror.TabIndex = 10;
            lblHyror.Text = "Aktiva Hyror";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1106, 33);
            label1.Name = "label1";
            label1.Size = new Size(278, 15);
            label1.TabIndex = 11;
            label1.Text = "För att se aktiva hyror, välj användare sedan Refresh";
            // 
            // btnVisaHyreshistorik
            // 
            btnVisaHyreshistorik.Location = new Point(715, 682);
            btnVisaHyreshistorik.Name = "btnVisaHyreshistorik";
            btnVisaHyreshistorik.Size = new Size(241, 50);
            btnVisaHyreshistorik.TabIndex = 12;
            btnVisaHyreshistorik.Text = "Hyreshistorik för vald användare";
            btnVisaHyreshistorik.UseVisualStyleBackColor = true;
            btnVisaHyreshistorik.Click += btnVisaHyreshistorik_Click;
            // 
            // button1
            // 
            button1.Location = new Point(402, 681);
            button1.Name = "button1";
            button1.Size = new Size(241, 50);
            button1.TabIndex = 13;
            button1.Text = "Underhåll";
            button1.UseVisualStyleBackColor = true;
            // 
            // HyraFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 760);
            Controls.Add(button1);
            Controls.Add(btnVisaHyreshistorik);
            Controls.Add(label1);
            Controls.Add(lblHyror);
            Controls.Add(dataGridViewAktivhyra);
            Controls.Add(btnAvslutaHyra);
            Controls.Add(btnHyra);
            Controls.Add(lblFordon);
            Controls.Add(dataGridViewFordon);
            Controls.Add(btnRefreshAllt);
            Controls.Add(lblStationer);
            Controls.Add(lblAnvändare);
            Controls.Add(dataGridViewStationer);
            Controls.Add(dataGridViewAnvändare);
            Name = "HyraFordon";
            Text = "Hyra / Lämna Fordon";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnvändare).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStationer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFordon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAktivhyra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAnvändare;
        private DataGridView dataGridViewStationer;
        private Label lblAnvändare;
        private Label lblStationer;
        private Button btnRefreshAllt;
        private DataGridView dataGridViewFordon;
        private Label lblFordon;
        private Button btnHyra;
        private Button btnAvslutaHyra;
        public DataGridView dataGridViewAktivhyra;
        private Label lblHyror;
        private Label label1;
        private Button btnVisaHyreshistorik;
        private Button button1;
    }
}
