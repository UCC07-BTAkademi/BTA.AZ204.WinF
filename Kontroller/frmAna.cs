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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {


            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            menuAna.BackColor = Color.OrangeRed;
            menuAna.ForeColor = Color.Black;
            menuAna.Font = new Font("Georgia", 10);
            //menuAna.Dock = DockStyle.Left;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCheckbox frmCheckbox = new frmCheckbox();

            //frmCheckbox.Show(); // Show ile açıldığında ekranın farklı taraflarına dokunulduğunda hidden oluyor.

            frmCheckbox.ShowDialog(); // bu formun dışında bir yere dokunduğunuzda form kaybolmaz.
        }

        private void radiButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadioButton frmRadioButton = new frmRadioButton();

            frmRadioButton.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCombobox frmCombobox = new frmCombobox();

            frmCombobox.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCheckedListBox frmCheckedListBox = new frmCheckedListBox();

            frmCheckedListBox.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPictureBox frmPictureBox = new frmPictureBox();

            frmPictureBox.ShowDialog();
        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSlideshow frmSlideshow = new frmSlideshow();

            frmSlideshow.ShowDialog();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOthers frmOthers = new frmOthers();

            frmOthers.ShowDialog();
        }
    }
}
