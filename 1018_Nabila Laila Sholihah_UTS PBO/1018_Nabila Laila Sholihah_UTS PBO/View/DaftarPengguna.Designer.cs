namespace _1018_Nabila_Laila_Sholihah_UTS_PBO.View
{
    partial class DaftarPengguna
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
            btMasuk = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btMasuk
            // 
            btMasuk.Location = new Point(517, 277);
            btMasuk.Name = "btMasuk";
            btMasuk.Size = new Size(94, 29);
            btMasuk.TabIndex = 9;
            btMasuk.Text = "Daftar";
            btMasuk.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(282, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(330, 27);
            tbPassword.TabIndex = 8;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(282, 144);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(330, 27);
            tbUsername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 203);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 147);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 5;
            label1.Text = "Username : ";
            // 
            // DaftarPengguna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMasuk);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DaftarPengguna";
            Text = "DaftarPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMasuk;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label2;
        private Label label1;
    }
}