using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreGucuKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //şifre girişi alın.
            //şifre 6 karakterden az ise şifre gücü düşük yazsın.Rengi kırmızı olsun.
            //şifre 6 karakterden çok ama tek tip karakter ise.Rengi kırmızı olsun.
            //şifre 6 karakterden fazla ve sayı+özelkarakter+harf içeriyorsa güçlü (rengi yeşil olsun)
            //şifre 6 karakterden fazla ve ikili kombinasyon içeriyorsa (harf+sayı/harf+özel karakter) orta desin rengi mavi olsun

        }


        private void txtSifreGirisi_TextChanged(object sender, EventArgs e)
        {

            string sifre = txtSifreGirisi.Text;
            if (sifre.Length < 6 ||sifre.All(char.IsLetter)|| sifre.All(char.IsDigit)||!sifre.Any(char.IsLetterOrDigit))
            {
                lblrenk.Text = "Düşük";
                lblrenk.ForeColor = Color.Red;
            }
            else if (sifre.Any(char.IsLetter)&& sifre.Any(char.IsDigit) && !sifre.All(char.IsLetterOrDigit))
            {
                lblrenk.Text = "Yüksek";
                lblrenk.ForeColor = Color.Green;
            }
            else
            {
                lblrenk.Text = "Orta";
                lblrenk.ForeColor = Color.Blue;
            }

        }
    }
}
