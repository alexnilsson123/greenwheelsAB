namespace WinformsGUI
{
    partial class VäljAnvändare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VäljAnvändare));
            btnSystemadministratör = new Button();
            btnAnvändare = new Button();
            SuspendLayout();
            // 
            // btnSystemadministratör
            // 
            btnSystemadministratör.Location = new Point(63, 164);
            btnSystemadministratör.Name = "btnSystemadministratör";
            btnSystemadministratör.Size = new Size(278, 104);
            btnSystemadministratör.TabIndex = 0;
            btnSystemadministratör.Text = "Systemadministratör";
            btnSystemadministratör.UseVisualStyleBackColor = true;
            btnSystemadministratör.Click += btnSystemadministratör_Click;
            // 
            // btnAnvändare
            // 
            btnAnvändare.BackColor = SystemColors.Control;
            btnAnvändare.Location = new Point(466, 164);
            btnAnvändare.Name = "btnAnvändare";
            btnAnvändare.Size = new Size(312, 104);
            btnAnvändare.TabIndex = 1;
            btnAnvändare.Text = "Användare";
            btnAnvändare.UseVisualStyleBackColor = false;
            btnAnvändare.Click += btnAnvändare_Click;
            // 
            // VäljAnvändare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 524);
            Controls.Add(btnAnvändare);
            Controls.Add(btnSystemadministratör);
            Name = "VäljAnvändare";
            Text = "Välj Användare";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSystemadministratör;
        private Button btnAnvändare;
    }
}