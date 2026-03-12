namespace _01_Inceleme.Forms
{
    partial class Main
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
            lbl_merhaba = new Label();
            lbl_kullaniciAdi = new Label();
            SuspendLayout();
            // 
            // lbl_merhaba
            // 
            lbl_merhaba.AutoSize = true;
            lbl_merhaba.Location = new Point(12, 9);
            lbl_merhaba.Name = "lbl_merhaba";
            lbl_merhaba.Size = new Size(75, 20);
            lbl_merhaba.TabIndex = 0;
            lbl_merhaba.Text = "Merhaba ,";
            // 
            // lbl_kullaniciAdi
            // 
            lbl_kullaniciAdi.AutoSize = true;
            lbl_kullaniciAdi.Location = new Point(93, 9);
            lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            lbl_kullaniciAdi.Size = new Size(50, 20);
            lbl_kullaniciAdi.TabIndex = 1;
            lbl_kullaniciAdi.Text = "label2";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_kullaniciAdi);
            Controls.Add(lbl_merhaba);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_merhaba;
        private Label lbl_kullaniciAdi;
    }
}