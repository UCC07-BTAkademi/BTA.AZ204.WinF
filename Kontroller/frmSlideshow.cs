using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kontroller
{

    public partial class frmSlideshow : Form
    {
        int imageindex; // listbox.selectedindex gibi çalışacak bir değişgen

        string DirPath; // Resimlerin bulunduğu directorynin adı/değeri 


        public frmSlideshow()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonResimYukle_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // Directoryler arasında gezinmeyi sağlar.

            DialogResult dr = fbd.ShowDialog(); // ekrana gelir ve dönüş değerini almak için.

            if (dr != DialogResult.Cancel) // resimlerin bulunduğu yer seçildikten sonra listbox ın doldurulması.....
            {
                lboxResimler.Items.Clear();

                DirPath = fbd.SelectedPath;

                string[] dosyalar = Directory.GetFiles(DirPath,"*.*"); // dizinin içini dolduruyorum

                foreach (string dosya in dosyalar)
                {
                    lboxResimler.Items.Add(dosya); //ekrandaki listbox dolduruluyor
                }

                //

                lboxResimler.SelectedIndex = imageindex = 0; // listbox ın ilk satırına konumlanmasını sağladım.

                btonOnceki.Enabled = false;

                btonSonraki.Enabled = btonSlide.Enabled = true;

            }
        }

        private void btonSlide_Click(object sender, EventArgs e)
        {
            if (btonSlide.Text == "SlideShow Başlat")
            {
                btonSlide.Text = "SlideShow Durdur";
                // şimdi timer kontrulünü ayarlama.

                timrSlideShow.Interval = int.Parse(cboxSure.Text) * 1000; // milisaniye

                timrSlideShow.Start();

            }
            else
            {
                btonSlide.Text = "SlideShow Başlat";

                timrSlideShow.Stop();
            }
        }

        private void lboxResimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listbox index değeri değiştiğinde tetiklenecek yer...
            picbResim.ImageLocation = lboxResimler.SelectedItem.ToString();
        }

        private void btonOnceki_Click(object sender, EventArgs e)
        {
            if (imageindex > 0)
            {
                imageindex = imageindex - 1; // imageindex -= 1

                if (imageindex == 0)
                {
                    btonOnceki.Enabled = false;
                }

                if (imageindex < lboxResimler.Items.Count - 1)
                {
                    btonSonraki.Enabled = true;
                }

                lboxResimler.SelectedIndex = imageindex;

            }
        }

        private void btonSonraki_Click(object sender, EventArgs e)
        {
            if (imageindex < lboxResimler.Items.Count-1)
            {
                imageindex += 1;

                if (imageindex == lboxResimler.Items.Count-1)
                {
                    btonSonraki.Enabled = false;
                }

                if (imageindex>0)
                {
                    btonOnceki.Enabled = true;
                }

                lboxResimler.SelectedIndex = imageindex;
            }
        }

        private void timrSlideShow_Tick(object sender, EventArgs e)
        {
            btonSonraki.PerformClick(); // sanki butona tıklamış gibi davran.
        }
    }
}
