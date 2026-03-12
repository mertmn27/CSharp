using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_Inceleme.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textbox_kullaniciAdi.Text;
            string sifre = textbox_sifre.Text;
            if(kullaniciAdi == "Admin" && sifre == "123")
            {
                Main mainForm = new Main(kullaniciAdi);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
    }
}
