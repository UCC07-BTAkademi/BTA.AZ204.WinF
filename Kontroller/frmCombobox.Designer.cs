
namespace Kontroller
{
    partial class frmCombobox
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
            this.cboxSehir = new System.Windows.Forms.ComboBox();
            this.btonKapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbelMesaj = new System.Windows.Forms.Label();
            this.cboxHangi = new System.Windows.Forms.ComboBox();
            this.cboxSonuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxSehir
            // 
            this.cboxSehir.FormattingEnabled = true;
            this.cboxSehir.Items.AddRange(new object[] {
            "Ankara",
            "Bursa",
            "İstanbul",
            "İzmir",
            "Adana"});
            this.cboxSehir.Location = new System.Drawing.Point(39, 34);
            this.cboxSehir.Name = "cboxSehir";
            this.cboxSehir.Size = new System.Drawing.Size(173, 24);
            this.cboxSehir.TabIndex = 0;
            // 
            // btonKapat
            // 
            this.btonKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonKapat.Location = new System.Drawing.Point(425, 500);
            this.btonKapat.Name = "btonKapat";
            this.btonKapat.Size = new System.Drawing.Size(75, 23);
            this.btonKapat.TabIndex = 1;
            this.btonKapat.Text = "Kapat";
            this.btonKapat.UseVisualStyleBackColor = true;
            this.btonKapat.Click += new System.EventHandler(this.btonKapat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbelMesaj
            // 
            this.lbelMesaj.AutoSize = true;
            this.lbelMesaj.Location = new System.Drawing.Point(268, 102);
            this.lbelMesaj.Name = "lbelMesaj";
            this.lbelMesaj.Size = new System.Drawing.Size(46, 17);
            this.lbelMesaj.TabIndex = 3;
            this.lbelMesaj.Text = "label1";
            // 
            // cboxHangi
            // 
            this.cboxHangi.AutoCompleteCustomSource.AddRange(new string[] {
            "Haftanın günleri",
            "Yıllar"});
            this.cboxHangi.FormattingEnabled = true;
            this.cboxHangi.Items.AddRange(new object[] {
            "Haftanın günleri",
            "Yıllar"});
            this.cboxHangi.Location = new System.Drawing.Point(39, 272);
            this.cboxHangi.Name = "cboxHangi";
            this.cboxHangi.Size = new System.Drawing.Size(127, 24);
            this.cboxHangi.TabIndex = 4;
            this.cboxHangi.SelectedIndexChanged += new System.EventHandler(this.cboxHangi_SelectedIndexChanged);
            // 
            // cboxSonuc
            // 
            this.cboxSonuc.FormattingEnabled = true;
            this.cboxSonuc.Location = new System.Drawing.Point(251, 272);
            this.cboxSonuc.Name = "cboxSonuc";
            this.cboxSonuc.Size = new System.Drawing.Size(121, 24);
            this.cboxSonuc.TabIndex = 5;
            // 
            // frmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 535);
            this.Controls.Add(this.cboxSonuc);
            this.Controls.Add(this.cboxHangi);
            this.Controls.Add(this.lbelMesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btonKapat);
            this.Controls.Add(this.cboxSehir);
            this.Name = "frmCombobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCombobox";
            this.Load += new System.EventHandler(this.frmCombobox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxSehir;
        private System.Windows.Forms.Button btonKapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbelMesaj;
        private System.Windows.Forms.ComboBox cboxHangi;
        private System.Windows.Forms.ComboBox cboxSonuc;
    }
}