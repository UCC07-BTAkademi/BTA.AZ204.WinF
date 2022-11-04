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
    public partial class frmPictureBox : Form
    {
        Image dosya;
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "PNG (*.PNG) | *.png";

            if (ofd.ShowDialog()== DialogResult.OK)
            {


                dosya = Image.FromFile(ofd.FileName);

                picbKitap.Image = dosya;
            }
        }

        private void btonKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "PNG (*.PNG) | *.png";

            if (sfd.ShowDialog()==DialogResult.OK)
            {
                dosya.Save(sfd.FileName);
            }
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
