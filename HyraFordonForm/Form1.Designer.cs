namespace WinformsGUI
{
    partial class AnvändareHyra
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            DataGridViewAnvändare = new DataGridView();
            dataGridViewStationer = new DataGridView();
            btnRefreshAllt = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAnvändare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStationer).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // DataGridViewAnvändare
            // 
            DataGridViewAnvändare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAnvändare.Location = new Point(144, 70);
            DataGridViewAnvändare.MultiSelect = false;
            DataGridViewAnvändare.Name = "DataGridViewAnvändare";
            DataGridViewAnvändare.ReadOnly = true;
            DataGridViewAnvändare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewAnvändare.Size = new Size(315, 157);
            DataGridViewAnvändare.TabIndex = 0;
            // 
            // dataGridViewStationer
            // 
            dataGridViewStationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStationer.Location = new Point(144, 369);
            dataGridViewStationer.MultiSelect = false;
            dataGridViewStationer.Name = "dataGridViewStationer";
            dataGridViewStationer.ReadOnly = true;
            dataGridViewStationer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStationer.Size = new Size(315, 172);
            dataGridViewStationer.TabIndex = 1;
            // 
            // btnRefreshAllt
            // 
            btnRefreshAllt.Location = new Point(796, 590);
            btnRefreshAllt.Name = "btnRefreshAllt";
            btnRefreshAllt.Size = new Size(108, 29);
            btnRefreshAllt.TabIndex = 2;
            btnRefreshAllt.Text = "Refresh";
            btnRefreshAllt.UseVisualStyleBackColor = true;
            btnRefreshAllt.Click += btnRefreshAllt_Click;
            // 
            // AnvändareHyra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1188, 757);
            Controls.Add(btnRefreshAllt);
            Controls.Add(dataGridViewStationer);
            Controls.Add(DataGridViewAnvändare);
            Name = "AnvändareHyra";
            Text = "Användare";
            ((System.ComponentModel.ISupportInitialize)DataGridViewAnvändare).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStationer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private DataGridView DataGridViewAnvändare;
        private DataGridView dataGridViewStationer;
        private Button btnRefreshAllt;
    }
}
