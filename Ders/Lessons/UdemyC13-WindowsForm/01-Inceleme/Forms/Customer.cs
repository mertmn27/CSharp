using _01_Inceleme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_Inceleme.Forms
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            txtBox_Bilgi.ReadOnly = true;
            cmbox_sehir.Items.Add("Seçiniz");
            cmbox_sehir.Items.Add("İstanbul");
            cmbox_sehir.Items.Add("Ankara");
            cmbox_sehir.Items.Add("İzmir");
            cmbox_sehir.Items.Add("Bursa");
            lstCategories.Items.Add("Seçiniz");
            lstCategories.Items.Add("Elektronik");
            lstCategories.Items.Add("Beyaz Eşya");
            lstCategories.Items.Add("Bay Giyim");
            lstCategories.Items.Add("Bayan Giyim");
            List<CustomerENT> customers = new List<CustomerENT>();
            dgw_Customer.DataSource = customers;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string kullaniciBilgi = txtBox_fullName.Text;
            string kullaniciSehir = cmbox_sehir.SelectedItem.ToString();
            string kullaniciKategori = lstCategories.SelectedItem.ToString();
            bool kullaniciSozlesme = check_sozlesme.Checked;
            bool secimA = radio_Secim1.Checked;
            bool secimB = radio_Secim2.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
