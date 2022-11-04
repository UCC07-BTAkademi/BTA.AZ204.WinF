using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontroller
{
    public partial class frmCombobox : Form
    {
        public frmCombobox()
        {
            InitializeComponent();
        }

        private void btonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCombobox_Load(object sender, EventArgs e)
        {
            cboxSehir.Items.Add("Konya");
            cboxSehir.Items.Add("Muğla");
            cboxSehir.Items.Add("Antalya");
            cboxSehir.Items.Add("Mersin");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ekrandaki combobox içinde kaç eleman var.

            lbelMesaj.Text = "Combobox içinde " + cboxSehir.Items.Count + "adet eleman vardır..";
        }

        private void cboxHangi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxSonuc.Items.Clear(); // Öncelikle için dolduracağım combobox ı temizliyorum.

            string secilen = (string)cboxHangi.SelectedItem;

            if (secilen == "Haftanın günleri")
            {
                string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

                cboxSonuc.Items.AddRange(gunler);

            }
            else
            {
                string[] yillar = { "2021", "2022", "2023", "2024", "2025", "2026", "2027" };

                cboxSonuc.Items.AddRange(yillar);
            }
        }
    }
}
