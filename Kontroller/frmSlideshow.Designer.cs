
namespace Kontroller
{
    partial class frmSlideshow
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
            this.components = new System.ComponentModel.Container();
            this.btonClose = new System.Windows.Forms.Button();
            this.picbResim = new System.Windows.Forms.PictureBox();
            this.lboxResimler = new System.Windows.Forms.ListBox();
            this.btonResimYukle = new System.Windows.Forms.Button();
            this.btonOnceki = new System.Windows.Forms.Button();
            this.btonSonraki = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxSure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btonSlide = new System.Windows.Forms.Button();
            this.timrSlideShow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbResim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(905, 567);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(113, 45);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // picbResim
            // 
            this.picbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbResim.Location = new System.Drawing.Point(21, 63);
            this.picbResim.Name = "picbResim";
            this.picbResim.Size = new System.Drawing.Size(364, 477);
            this.picbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbResim.TabIndex = 1;
            this.picbResim.TabStop = false;
            // 
            // lboxResimler
            // 
            this.lboxResimler.FormattingEnabled = true;
            this.lboxResimler.ItemHeight = 16;
            this.lboxResimler.Location = new System.Drawing.Point(422, 63);
            this.lboxResimler.Name = "lboxResimler";
            this.lboxResimler.Size = new System.Drawing.Size(554, 276);
            this.lboxResimler.TabIndex = 2;
            this.lboxResimler.SelectedIndexChanged += new System.EventHandler(this.lboxResimler_SelectedIndexChanged);
            // 
            // btonResimYukle
            // 
            this.btonResimYukle.Location = new System.Drawing.Point(422, 377);
            this.btonResimYukle.Name = "btonResimYukle";
            this.btonResimYukle.Size = new System.Drawing.Size(171, 47);
            this.btonResimYukle.TabIndex = 3;
            this.btonResimYukle.Text = "Resimleri Yükle";
            this.btonResimYukle.UseVisualStyleBackColor = true;
            this.btonResimYukle.Click += new System.EventHandler(this.btonResimYukle_Click);
            // 
            // btonOnceki
            // 
            this.btonOnceki.Location = new System.Drawing.Point(422, 453);
            this.btonOnceki.Name = "btonOnceki";
            this.btonOnceki.Size = new System.Drawing.Size(72, 48);
            this.btonOnceki.TabIndex = 4;
            this.btonOnceki.Text = "Önceki";
            this.btonOnceki.UseVisualStyleBackColor = true;
            this.btonOnceki.Click += new System.EventHandler(this.btonOnceki_Click);
            // 
            // btonSonraki
            // 
            this.btonSonraki.Location = new System.Drawing.Point(518, 453);
            this.btonSonraki.Name = "btonSonraki";
            this.btonSonraki.Size = new System.Drawing.Size(75, 48);
            this.btonSonraki.TabIndex = 5;
            this.btonSonraki.Text = "Sonraki";
            this.btonSonraki.UseVisualStyleBackColor = true;
            this.btonSonraki.Click += new System.EventHandler(this.btonSonraki_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxSure);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btonSlide);
            this.groupBox1.Location = new System.Drawing.Point(673, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SlideShow";
            // 
            // cboxSure
            // 
            this.cboxSure.FormattingEnabled = true;
            this.cboxSure.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboxSure.Location = new System.Drawing.Point(188, 33);
            this.cboxSure.Name = "cboxSure";
            this.cboxSure.Size = new System.Drawing.Size(72, 24);
            this.cboxSure.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bekleme süresi (sn)  : ";
            // 
            // btonSlide
            // 
            this.btonSlide.Location = new System.Drawing.Point(34, 88);
            this.btonSlide.Name = "btonSlide";
            this.btonSlide.Size = new System.Drawing.Size(190, 36);
            this.btonSlide.TabIndex = 0;
            this.btonSlide.Text = "SlideShow Başlat";
            this.btonSlide.UseVisualStyleBackColor = true;
            this.btonSlide.Click += new System.EventHandler(this.btonSlide_Click);
            // 
            // timrSlideShow
            // 
            this.timrSlideShow.Tick += new System.EventHandler(this.timrSlideShow_Tick);
            // 
            // frmSlideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btonSonraki);
            this.Controls.Add(this.btonOnceki);
            this.Controls.Add(this.btonResimYukle);
            this.Controls.Add(this.lboxResimler);
            this.Controls.Add(this.picbResim);
            this.Controls.Add(this.btonClose);
            this.Name = "frmSlideshow";
            this.Text = "frmSlideshow";
            ((System.ComponentModel.ISupportInitialize)(this.picbResim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.PictureBox picbResim;
        private System.Windows.Forms.ListBox lboxResimler;
        private System.Windows.Forms.Button btonResimYukle;
        private System.Windows.Forms.Button btonOnceki;
        private System.Windows.Forms.Button btonSonraki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btonSlide;
        private System.Windows.Forms.Timer timrSlideShow;
    }
}