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
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void radbE_CheckedChanged(object sender, EventArgs e)
        {
            lbelMesaj.Text = "Erkek";
        }

        private void radbK_CheckedChanged(object sender, EventArgs e)
        {
            lbelMesaj.Text = "Kadın";
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRadioButton_Load(object sender, EventArgs e)
        {
            // yeni bir tane radio button eklemek. (run-time)

            // Olmayan bir kontrolu yaratmak için
            RadioButton radbT = new RadioButton(); // radio butonun ismi (Name)
            radbT.Text = "LGBTi";
            radbT.AutoSize = true;
            radbT.Location = new Point(100, 200);
            radbT.Font = new Font("Arial", 14);

            this.Controls.Add(radbT); // Kontrol ekleniyor form üzerine

            radbT.CheckedChanged += new System.EventHandler(this.radbT_CheckChanged); // o kontrolün bir metodu

        }

        private void radbT_CheckChanged(object sender, EventArgs e)
        {
            lbelMesaj.Text = "LGBTİ+";

            
        }
    }
}
