using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Uygulama.Core.BusinessLogicLayer;
using Uygulama.Core.Helper;
using Uygulama.Entities;

namespace Uygulama.Forms
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void kullaniciAdi_txtBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Yellow;
        }

        private void kullaniciAdi_txtBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            string username = kullaniciAdi_txtBox.Text;
            string password = sifre_txtBox.Text;
            UserService userService = new UserService();

            User applicationUser = userService.Login(username, password);

            if (applicationUser != null)
            {
                CurrentVar.currentUser = applicationUser;
                MainFormUI mainForm = new MainFormUI();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş bilgileriniz hatalı veya kullanıcı kilitli!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
