using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sonuc, gecme_notu;
            sayi1 = Convert.ToInt32(txtSinav1.Text);
            sayi2 = Convert.ToInt32(txtSinav2.Text);
            sayi3 = Convert.ToInt32(txtSinav3.Text);
            gecme_notu = Convert.ToInt32(txtgecme.Text);

            sonuc = (sayi1 + sayi2 + sayi3) / 3;

            if (sonuc < gecme_notu)
            {
                txtsonuc.Text = sonuc.ToString();
                txtsonuc.BackColor = Color.Red;
                txtsonuc.ForeColor = Color.White;
            }
            else
            {
                txtsonuc.Text = sonuc.ToString();
                txtsonuc.BackColor = Color.Green;
                txtsonuc.ForeColor = Color.White;

            }

            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSinav1.Text = "";
            txtSinav2.Text = "";
            txtSinav3.Text = "";
            txtsonuc.Text = "";
            txtsonuc.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
