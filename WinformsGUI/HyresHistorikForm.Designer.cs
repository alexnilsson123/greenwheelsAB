namespace WinformsGUI
{
    partial class HyresHistorikForm
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
            dataGridViewHyresHistorik = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHyresHistorik).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHyresHistorik
            // 
            dataGridViewHyresHistorik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHyresHistorik.Location = new Point(48, 61);
            dataGridViewHyresHistorik.MultiSelect = false;
            dataGridViewHyresHistorik.Name = "dataGridViewHyresHistorik";
            dataGridViewHyresHistorik.ReadOnly = true;
            dataGridViewHyresHistorik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHyresHistorik.Size = new Size(686, 184);
            dataGridViewHyresHistorik.TabIndex = 0;
            // 
            // HyresHistorikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 315);
            Controls.Add(dataGridViewHyresHistorik);
            Name = "HyresHistorikForm";
            Text = "HyresHistorikForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHyresHistorik).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHyresHistorik;
    }
}