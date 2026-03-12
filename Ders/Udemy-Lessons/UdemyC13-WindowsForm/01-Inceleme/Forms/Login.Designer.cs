namespace _01_Inceleme.Forms
{
    partial class Login
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
            lbl_kullaniciAdi = new Label();
            textbox_kullaniciAdi = new TextBox();
            lbl_sifre = new Label();
            textbox_sifre = new TextBox();
            btn_girisYap = new Button();
            SuspendLayout();
            // 
            // lbl_kullaniciAdi
            // 
            lbl_kullaniciAdi.AutoSize = true;
            lbl_kullaniciAdi.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_kullaniciAdi.Location = new Point(112, 71);
            lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            lbl_kullaniciAdi.Size = new Size(89, 17);
            lbl_kullaniciAdi.TabIndex = 1;
            lbl_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textbox_kullaniciAdi
            // 
            textbox_kullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            textbox_kullaniciAdi.Location = new Point(207, 68);
            textbox_kullaniciAdi.Name = "textbox_kullaniciAdi";
            textbox_kullaniciAdi.Size = new Size(125, 25);
            textbox_kullaniciAdi.TabIndex = 0;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sifre.Location = new Point(112, 102);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(42, 17);
            lbl_sifre.TabIndex = 1;
            lbl_sifre.Text = "Şifre:";
            // 
            // textbox_sifre
            // 
            textbox_sifre.BorderStyle = BorderStyle.FixedSingle;
            textbox_sifre.Location = new Point(207, 99);
            textbox_sifre.Name = "textbox_sifre";
            textbox_sifre.Size = new Size(125, 25);
            textbox_sifre.TabIndex = 1;
            // 
            // btn_girisYap
            // 
            btn_girisYap.Location = new Point(207, 130);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(125, 29);
            btn_girisYap.TabIndex = 2;
            btn_girisYap.Text = "Giriş Yap";
            btn_girisYap.UseVisualStyleBackColor = true;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 240);
            Controls.Add(btn_girisYap);
            Controls.Add(textbox_sifre);
            Controls.Add(lbl_sifre);
            Controls.Add(textbox_kullaniciAdi);
            Controls.Add(lbl_kullaniciAdi);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş Ekranı";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_kullaniciAdi;
        private TextBox textbox_kullaniciAdi;
        private Label lbl_sifre;
        private TextBox textbox_sifre;
        private Button btn_girisYap;
    }
}