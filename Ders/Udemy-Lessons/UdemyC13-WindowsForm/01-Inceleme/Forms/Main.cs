using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_Inceleme.Forms
{
    public partial class Main : Form
    {
        public Main(string kullaniciAdi)
        {
            InitializeComponent();
            lbl_kullaniciAdi.Text = kullaniciAdi;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
