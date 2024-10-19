namespace WinformsGUI
{
    partial class LäggTillFordon
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
            txtFordonID = new TextBox();
            txtBatteriNivå = new TextBox();
            txtTyp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLäggTill = new Button();
            cmbStationer = new ComboBox();
            SuspendLayout();
            // 
            // txtFordonID
            // 
            txtFordonID.Location = new Point(12, 34);
            txtFordonID.Name = "txtFordonID";
            txtFordonID.Size = new Size(266, 23);
            txtFordonID.TabIndex = 0;
            // 
            // txtBatteriNivå
            // 
            txtBatteriNivå.Location = new Point(12, 141);
            txtBatteriNivå.Name = "txtBatteriNivå";
            txtBatteriNivå.Size = new Size(266, 23);
            txtBatteriNivå.TabIndex = 1;
            // 
            // txtTyp
            // 
            txtTyp.Location = new Point(12, 88);
            txtTyp.Name = "txtTyp";
            txtTyp.Size = new Size(266, 23);
            txtTyp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "FordonID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Typ : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 6;
            label3.Text = "Batteri Nivå :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Station :";
            // 
            // btnLäggTill
            // 
            btnLäggTill.Location = new Point(173, 248);
            btnLäggTill.Name = "btnLäggTill";
            btnLäggTill.Size = new Size(113, 23);
            btnLäggTill.TabIndex = 8;
            btnLäggTill.Text = "Lägg till Fordon";
            btnLäggTill.UseVisualStyleBackColor = true;
            btnLäggTill.Click += btnLäggTill_Click;
            // 
            // cmbStationer
            // 
            cmbStationer.FormattingEnabled = true;
            cmbStationer.Location = new Point(12, 195);
            cmbStationer.Name = "cmbStationer";
            cmbStationer.Size = new Size(139, 23);
            cmbStationer.TabIndex = 9;
            // 
            // LäggTillFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 283);
            Controls.Add(cmbStationer);
            Controls.Add(btnLäggTill);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTyp);
            Controls.Add(txtBatteriNivå);
            Controls.Add(txtFordonID);
            Name = "LäggTillFordon";
            Text = "LäggTillFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFordonID;
        private TextBox txtBatteriNivå;
        private TextBox txtTyp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLäggTill;
        private ComboBox cmbStationer;
    }
}