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
    public partial class frmCheckbox : Form
    {
        public frmCheckbox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonMesaj_Click(object sender, EventArgs e)
        {
            if (chkbMesaj.Checked == true) // checkbox seçilmişmi ??
            {
                lbelMessage.Text = "Checkbox Seçili";
            }
            else
            {
                lbelMessage.Text = "Checkbox seçili değil";
            }
        }

        private void chkbMesaj_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbMesaj.Checked == true) // checkbox seçilmişmi ??
            {
                lbelMessage.Text = "Checkbox Seçili";
            }
            else
            {
                lbelMessage.Text = "Checkbox seçili değil";
            }
        }
    }
}
