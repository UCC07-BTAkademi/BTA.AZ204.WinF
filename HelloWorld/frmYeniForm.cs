using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_WinF
{
    public partial class frmYeniForm : Form
    {
        public frmYeniForm()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            // Buton click yapıldığında tetiklenecek bölüm

            Application.Exit(); // uygulamadan çıkar..
        }

        private void btonMessage_Click(object sender, EventArgs e)
        {

            using (frmMessage frmMessage = new frmMessage()) // Buradaki kullnım...şunu şunu kullanarak...anlamında
            {
                frmMessage.Text = "Mesajınız var...."; // formun title değeri
                frmMessage.lbelMessage.Text = "Merhaba Sayın " + tboxAd.Text + " " + tboxSoyad.Text; // Modifiers

                if (frmMessage.ShowDialog() == DialogResult.OK) // Eğer dilog formundan OK tuşuna basılıp çıkıldıysa kontrolleri temizle.
                {
                    tboxAd.Clear();
                    tboxSoyad.Clear();
                }
            }

        }
    }
}
