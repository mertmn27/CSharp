namespace _01_Inceleme.Forms
{
    partial class Customer
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
            lbl_adSoyad = new Label();
            txtBox_fullName = new TextBox();
            btn_save = new Button();
            lbl_description = new Label();
            textBox1 = new TextBox();
            lbl_bilgi = new Label();
            txtBox_Bilgi = new TextBox();
            lbl_sehir = new Label();
            cmbox_sehir = new ComboBox();
            lbl_kategori = new Label();
            lstCategories = new ListBox();
            check_sozlesme = new CheckBox();
            radio_Secim1 = new RadioButton();
            radio_Secim2 = new RadioButton();
            dgw_Customer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgw_Customer).BeginInit();
            SuspendLayout();
            // 
            // lbl_adSoyad
            // 
            lbl_adSoyad.AutoSize = true;
            lbl_adSoyad.Location = new Point(19, 15);
            lbl_adSoyad.Name = "lbl_adSoyad";
            lbl_adSoyad.Size = new Size(100, 20);
            lbl_adSoyad.TabIndex = 0;
            lbl_adSoyad.Text = "Adı ve Soyadı";
            // 
            // txtBox_fullName
            // 
            txtBox_fullName.Location = new Point(125, 12);
            txtBox_fullName.Name = "txtBox_fullName";
            txtBox_fullName.Size = new Size(214, 27);
            txtBox_fullName.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(125, 508);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(214, 29);
            btn_save.TabIndex = 2;
            btn_save.Text = "Kaydet";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Location = new Point(19, 52);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(70, 20);
            lbl_description.TabIndex = 3;
            lbl_description.Text = "Açıklama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 126);
            textBox1.TabIndex = 4;
            // 
            // lbl_bilgi
            // 
            lbl_bilgi.AutoSize = true;
            lbl_bilgi.Location = new Point(18, 478);
            lbl_bilgi.Name = "lbl_bilgi";
            lbl_bilgi.Size = new Size(39, 20);
            lbl_bilgi.TabIndex = 5;
            lbl_bilgi.Text = "Bilgi";
            lbl_bilgi.Click += label1_Click;
            // 
            // txtBox_Bilgi
            // 
            txtBox_Bilgi.Location = new Point(125, 475);
            txtBox_Bilgi.Name = "txtBox_Bilgi";
            txtBox_Bilgi.Size = new Size(300, 27);
            txtBox_Bilgi.TabIndex = 6;
            txtBox_Bilgi.Text = "Bilgileriniz TR sunucularında tutulmaktadır";
            // 
            // lbl_sehir
            // 
            lbl_sehir.AutoSize = true;
            lbl_sehir.Location = new Point(19, 193);
            lbl_sehir.Name = "lbl_sehir";
            lbl_sehir.Size = new Size(42, 20);
            lbl_sehir.TabIndex = 7;
            lbl_sehir.Text = "Şehir";
            // 
            // cmbox_sehir
            // 
            cmbox_sehir.FormattingEnabled = true;
            cmbox_sehir.Location = new Point(125, 193);
            cmbox_sehir.Name = "cmbox_sehir";
            cmbox_sehir.Size = new Size(214, 28);
            cmbox_sehir.TabIndex = 8;
            // 
            // lbl_kategori
            // 
            lbl_kategori.AutoSize = true;
            lbl_kategori.Location = new Point(19, 252);
            lbl_kategori.Name = "lbl_kategori";
            lbl_kategori.Size = new Size(99, 40);
            lbl_kategori.TabIndex = 9;
            lbl_kategori.Text = "İlgilendiğiniz \r\nKategoriler";
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.Location = new Point(125, 252);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(214, 104);
            lstCategories.TabIndex = 10;
            // 
            // check_sozlesme
            // 
            check_sozlesme.AutoSize = true;
            check_sozlesme.Location = new Point(125, 379);
            check_sozlesme.Name = "check_sozlesme";
            check_sozlesme.Size = new Size(214, 24);
            check_sozlesme.TabIndex = 11;
            check_sozlesme.Text = "Sözleşmeyi Kabul Ediyorum";
            check_sozlesme.UseVisualStyleBackColor = true;
            // 
            // radio_Secim1
            // 
            radio_Secim1.AutoSize = true;
            radio_Secim1.Location = new Point(125, 409);
            radio_Secim1.Name = "radio_Secim1";
            radio_Secim1.Size = new Size(84, 24);
            radio_Secim1.TabIndex = 12;
            radio_Secim1.TabStop = true;
            radio_Secim1.Text = "Seçim A";
            radio_Secim1.UseVisualStyleBackColor = true;
            // 
            // radio_Secim2
            // 
            radio_Secim2.AutoSize = true;
            radio_Secim2.Location = new Point(125, 439);
            radio_Secim2.Name = "radio_Secim2";
            radio_Secim2.Size = new Size(83, 24);
            radio_Secim2.TabIndex = 13;
            radio_Secim2.TabStop = true;
            radio_Secim2.Text = "Seçim B";
            radio_Secim2.UseVisualStyleBackColor = true;
            radio_Secim2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dgw_Customer
            // 
            dgw_Customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Customer.Location = new Point(452, 15);
            dgw_Customer.Name = "dgw_Customer";
            dgw_Customer.RowHeadersWidth = 51;
            dgw_Customer.Size = new Size(542, 522);
            dgw_Customer.TabIndex = 14;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 550);
            Controls.Add(dgw_Customer);
            Controls.Add(radio_Secim2);
            Controls.Add(radio_Secim1);
            Controls.Add(check_sozlesme);
            Controls.Add(lstCategories);
            Controls.Add(lbl_kategori);
            Controls.Add(cmbox_sehir);
            Controls.Add(lbl_sehir);
            Controls.Add(txtBox_Bilgi);
            Controls.Add(lbl_bilgi);
            Controls.Add(textBox1);
            Controls.Add(lbl_description);
            Controls.Add(btn_save);
            Controls.Add(txtBox_fullName);
            Controls.Add(lbl_adSoyad);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dgw_Customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_adSoyad;
        private TextBox txtBox_fullName;
        private Button btn_save;
        private Label lbl_description;
        private TextBox textBox1;
        private Label lbl_bilgi;
        private TextBox txtBox_Bilgi;
        private Label lbl_sehir;
        private ComboBox cmbox_sehir;
        private Label lbl_kategori;
        private ListBox lstCategories;
        private CheckBox check_sozlesme;
        private RadioButton radio_Secim1;
        private RadioButton radio_Secim2;
        private DataGridView dgw_Customer;
    }
}