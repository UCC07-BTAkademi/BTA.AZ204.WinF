using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem
{
    public partial class Form1 : Form
    {
        double sonuc;
        double sayi1, sayi2;
        char islemKod;
        public Form1()
        {
            InitializeComponent();
        }

        private void tboxSayi1_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tboxSayi1.Text);
        }

        private void tboxSayi2_TextChanged(object sender, EventArgs e)
        {
            if (tboxSayi2.Text != "")
            {
                sayi2 = Convert.ToDouble(tboxSayi2.Text);
            }
            else
                sayi2 = 0;
        }

        private void btonTopla_Click(object sender, EventArgs e)
        {
            sonuc = sayi1 + sayi2;

            islemKod = '+';

            SonucGoster(sonuc, islemKod);


        }

        private void btonFark_Click(object sender, EventArgs e)
        {
            sonuc = sayi1 - sayi2;

            islemKod = '-';

            SonucGoster(sonuc, islemKod);

        }

        private void btonCarp_Click(object sender, EventArgs e)
        {
            sonuc = sayi1 * sayi2;

            islemKod = '*';

            SonucGoster(sonuc, islemKod);

        }

        private void btonBol_Click(object sender, EventArgs e)
        {
            if (sayi2 != 0)
            {
                sonuc = sayi1 / sayi2;

                islemKod = '/';

                SonucGoster(sonuc, islemKod);

            }
            else
            {
                MessageBox.Show("Bölen değeri 0 olamaz...Kontrol edip tekrar deneyiniz....");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbelSonuc.Text = "";
        }

        private void SonucGoster(double sonuc, char islem)
        {
            string Aciklama="";

            switch (islem)
            {
                case '+':
                    Aciklama = " Toplama ";
                    break;
                case '-':
                    Aciklama = " Çıkarma ";
                    break;
                case '*':
                    Aciklama = " Çarpma ";
                    break;
                case '/':
                    Aciklama = " Bölme ";
                    break;
            }

            lbelSonuc.Text = "Yaptığınız " + Aciklama +"işleminin sonucu " + sonuc.ToString() + " dır...";
        }
    }
}
