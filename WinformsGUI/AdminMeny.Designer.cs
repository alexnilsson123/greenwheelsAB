namespace WinformsGUI
{
    partial class AdminMeny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewFordon = new DataGridView();
            btnLäggTillFordon = new Button();
            btnTaBortFordon = new Button();
            btnRefreshFordon = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFordon).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFordon
            // 
            dataGridViewFordon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFordon.Location = new Point(28, 35);
            dataGridViewFordon.MultiSelect = false;
            dataGridViewFordon.Name = "dataGridViewFordon";
            dataGridViewFordon.ReadOnly = true;
            dataGridViewFordon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFordon.Size = new Size(695, 321);
            dataGridViewFordon.TabIndex = 0;
            dataGridViewFordon.CellClick += dataGridViewFordon_CellClick;
            // 
            // btnLäggTillFordon
            // 
            btnLäggTillFordon.Location = new Point(28, 372);
            btnLäggTillFordon.Name = "btnLäggTillFordon";
            btnLäggTillFordon.Size = new Size(116, 32);
            btnLäggTillFordon.TabIndex = 1;
            btnLäggTillFordon.Text = "Lägg till fordon";
            btnLäggTillFordon.UseVisualStyleBackColor = true;
            // 
            // btnTaBortFordon
            // 
            btnTaBortFordon.Location = new Point(167, 372);
            btnTaBortFordon.Name = "btnTaBortFordon";
            btnTaBortFordon.Size = new Size(116, 32);
            btnTaBortFordon.TabIndex = 2;
            btnTaBortFordon.Text = "Ta bort fordon";
            btnTaBortFordon.UseVisualStyleBackColor = true;
            btnTaBortFordon.Click += btnTaBortFordon_Click;
            // 
            // btnRefreshFordon
            // 
            btnRefreshFordon.Location = new Point(598, 372);
            btnRefreshFordon.Name = "btnRefreshFordon";
            btnRefreshFordon.Size = new Size(125, 32);
            btnRefreshFordon.TabIndex = 3;
            btnRefreshFordon.Text = "Refresh";
            btnRefreshFordon.UseVisualStyleBackColor = true;
            btnRefreshFordon.Click += btnRefreshFordon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "Fordonslista";
            // 
            // AdminMeny
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 428);
            Controls.Add(label1);
            Controls.Add(btnRefreshFordon);
            Controls.Add(btnTaBortFordon);
            Controls.Add(btnLäggTillFordon);
            Controls.Add(dataGridViewFordon);
            Name = "AdminMeny";
            Text = "AdminMeny";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFordon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFordon;
        private Button btnLäggTillFordon;
        private Button btnTaBortFordon;
        private Button btnRefreshFordon;
        private Label label1;
    }
}