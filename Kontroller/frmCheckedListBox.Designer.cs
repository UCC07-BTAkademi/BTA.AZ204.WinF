
namespace Kontroller
{
    partial class frmCheckedListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btonKapat = new System.Windows.Forms.Button();
            this.chkbDiller = new System.Windows.Forms.CheckedListBox();
            this.rbtnHepsiSec = new System.Windows.Forms.RadioButton();
            this.rbtnHepsiKaldir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btonOK = new System.Windows.Forms.Button();
            this.lbelMesaj = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonKapat
            // 
            this.btonKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonKapat.Location = new System.Drawing.Point(391, 399);
            this.btonKapat.Name = "btonKapat";
            this.btonKapat.Size = new System.Drawing.Size(103, 49);
            this.btonKapat.TabIndex = 0;
            this.btonKapat.Text = "Kapat";
            this.btonKapat.UseVisualStyleBackColor = true;
            this.btonKapat.Click += new System.EventHandler(this.btonKapat_Click);
            // 
            // chkbDiller
            // 
            this.chkbDiller.FormattingEnabled = true;
            this.chkbDiller.Items.AddRange(new object[] {
            "CSharp",
            "Java",
            "C++",
            "C",
            "Javascript",
            "PHP",
            "Python"});
            this.chkbDiller.Location = new System.Drawing.Point(46, 65);
            this.chkbDiller.Name = "chkbDiller";
            this.chkbDiller.Size = new System.Drawing.Size(120, 140);
            this.chkbDiller.TabIndex = 1;
            // 
            // rbtnHepsiSec
            // 
            this.rbtnHepsiSec.AutoSize = true;
            this.rbtnHepsiSec.Location = new System.Drawing.Point(32, 37);
            this.rbtnHepsiSec.Name = "rbtnHepsiSec";
            this.rbtnHepsiSec.Size = new System.Drawing.Size(102, 21);
            this.rbtnHepsiSec.TabIndex = 2;
            this.rbtnHepsiSec.TabStop = true;
            this.rbtnHepsiSec.Text = "Hepsini seç";
            this.rbtnHepsiSec.UseVisualStyleBackColor = true;
            this.rbtnHepsiSec.CheckedChanged += new System.EventHandler(this.rbtnHepsiSec_CheckedChanged);
            // 
            // rbtnHepsiKaldir
            // 
            this.rbtnHepsiKaldir.AutoSize = true;
            this.rbtnHepsiKaldir.Location = new System.Drawing.Point(32, 73);
            this.rbtnHepsiKaldir.Name = "rbtnHepsiKaldir";
            this.rbtnHepsiKaldir.Size = new System.Drawing.Size(124, 21);
            this.rbtnHepsiKaldir.TabIndex = 3;
            this.rbtnHepsiKaldir.TabStop = true;
            this.rbtnHepsiKaldir.Text = "Seçimleri kaldır";
            this.rbtnHepsiKaldir.UseVisualStyleBackColor = true;
            this.rbtnHepsiKaldir.CheckedChanged += new System.EventHandler(this.rbtnHepsiKaldir_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHepsiSec);
            this.groupBox1.Controls.Add(this.rbtnHepsiKaldir);
            this.groupBox1.Location = new System.Drawing.Point(294, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçiminiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hangi programlama dilleri ile uğraşıyorsunuz ?";
            // 
            // btonOK
            // 
            this.btonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonOK.Location = new System.Drawing.Point(46, 228);
            this.btonOK.Name = "btonOK";
            this.btonOK.Size = new System.Drawing.Size(120, 32);
            this.btonOK.TabIndex = 4;
            this.btonOK.Text = "Mesaj ver";
            this.btonOK.UseVisualStyleBackColor = true;
            this.btonOK.Click += new System.EventHandler(this.btonOK_Click_1);
            // 
            // lbelMesaj
            // 
            this.lbelMesaj.AutoSize = true;
            this.lbelMesaj.Location = new System.Drawing.Point(43, 307);
            this.lbelMesaj.Name = "lbelMesaj";
            this.lbelMesaj.Size = new System.Drawing.Size(46, 17);
            this.lbelMesaj.TabIndex = 5;
            this.lbelMesaj.Text = "label2";
            // 
            // frmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 460);
            this.Controls.Add(this.lbelMesaj);
            this.Controls.Add(this.btonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkbDiller);
            this.Controls.Add(this.btonKapat);
            this.Name = "frmCheckedListBox";
            this.Text = "frmCheckedListBox";
            this.Load += new System.EventHandler(this.frmCheckedListBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonKapat;
        private System.Windows.Forms.CheckedListBox chkbDiller;
        private System.Windows.Forms.RadioButton rbtnHepsiSec;
        private System.Windows.Forms.RadioButton rbtnHepsiKaldir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btonOK;
        private System.Windows.Forms.Label lbelMesaj;
    }
}