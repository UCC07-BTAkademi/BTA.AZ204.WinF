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
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonOK_Click(object sender, EventArgs e)
        {

        }

        private void rbtnHepsiSec_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(true);

        }

        private void rbtnHepsiKaldir_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(false);
        }

        private void CheckAyarla(bool checkState )
        {
            for (int i = 0; i < chkbDiller.Items.Count; i++) // checkedlistbox ın indexlerine göre hareket chlboxDillerin tüm elemanlarına erişmek amacıyla
            {
                chkbDiller.SetItemChecked(i, checkState);
            }
        }

        private void frmCheckedListBox_Load(object sender, EventArgs e)
        {
            lbelMesaj.Text = "";
        }

        private void btonOK_Click_1(object sender, EventArgs e)
        {
            var secilenDiller = new List<string>(); // chkblist içinde seçmiş olduğum item değerlerini tutacak

            foreach(var dil in chkbDiller.CheckedItems)
            {
                secilenDiller.Add(dil.ToString()); // seçilmiş olan değerler listeye ekleniyor.
            }

            lbelMesaj.Text = $"Uğraşmış olduğunuz diller : {string.Join(", ", secilenDiller)}"; // C#JavaJavascript --> C#, Java, Javascript haline getirmek amacıyla..

        }
    }
}
