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
    public partial class frmOthers : Form
    {
        public frmOthers()
        {
            InitializeComponent();
        }

        private void btonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
