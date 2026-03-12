namespace Uygulama.Forms
{
    partial class LoginUI
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
            pictureBox1 = new PictureBox();
            lbl_kullaniciAdi = new Label();
            kullaniciAdi_txtBox = new TextBox();
            lbl_sifre = new Label();
            sifre_txtBox = new TextBox();
            giris_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_kullaniciAdi
            // 
            lbl_kullaniciAdi.AutoSize = true;
            lbl_kullaniciAdi.Location = new Point(186, 34);
            lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            lbl_kullaniciAdi.Size = new Size(99, 20);
            lbl_kullaniciAdi.TabIndex = 1;
            lbl_kullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // kullaniciAdi_txtBox
            // 
            kullaniciAdi_txtBox.Location = new Point(291, 31);
            kullaniciAdi_txtBox.Name = "kullaniciAdi_txtBox";
            kullaniciAdi_txtBox.Size = new Size(150, 27);
            kullaniciAdi_txtBox.TabIndex = 0;
            kullaniciAdi_txtBox.Enter += kullaniciAdi_txtBox_Enter;
            kullaniciAdi_txtBox.Leave += kullaniciAdi_txtBox_Leave;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(186, 67);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(46, 20);
            lbl_sifre.TabIndex = 1;
            lbl_sifre.Text = "Şifre :";
            // 
            // sifre_txtBox
            // 
            sifre_txtBox.Location = new Point(291, 64);
            sifre_txtBox.Name = "sifre_txtBox";
            sifre_txtBox.PasswordChar = '*';
            sifre_txtBox.Size = new Size(150, 27);
            sifre_txtBox.TabIndex = 1;
            sifre_txtBox.Enter += kullaniciAdi_txtBox_Enter;
            sifre_txtBox.Leave += kullaniciAdi_txtBox_Leave;
            // 
            // giris_button
            // 
            giris_button.Location = new Point(291, 97);
            giris_button.Name = "giris_button";
            giris_button.Size = new Size(150, 29);
            giris_button.TabIndex = 2;
            giris_button.Text = "Giriş Yap";
            giris_button.UseVisualStyleBackColor = true;
            giris_button.Click += giris_button_Click;
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 188);
            Controls.Add(giris_button);
            Controls.Add(sifre_txtBox);
            Controls.Add(lbl_sifre);
            Controls.Add(kullaniciAdi_txtBox);
            Controls.Add(lbl_kullaniciAdi);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_kullaniciAdi;
        private TextBox kullaniciAdi_txtBox;
        private Label lbl_sifre;
        private TextBox sifre_txtBox;
        private Button giris_button;
    }
}