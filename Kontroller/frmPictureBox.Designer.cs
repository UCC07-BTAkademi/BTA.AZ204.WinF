
namespace Kontroller
{
    partial class frmPictureBox
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
            this.picbKitap = new System.Windows.Forms.PictureBox();
            this.btonClose = new System.Windows.Forms.Button();
            this.btonAc = new System.Windows.Forms.Button();
            this.btonKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // picbKitap
            // 
            this.picbKitap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbKitap.Location = new System.Drawing.Point(62, 49);
            this.picbKitap.Name = "picbKitap";
            this.picbKitap.Size = new System.Drawing.Size(213, 270);
            this.picbKitap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbKitap.TabIndex = 0;
            this.picbKitap.TabStop = false;
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonClose.Location = new System.Drawing.Point(532, 538);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(90, 37);
            this.btonClose.TabIndex = 1;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // btonAc
            // 
            this.btonAc.Location = new System.Drawing.Point(62, 355);
            this.btonAc.Name = "btonAc";
            this.btonAc.Size = new System.Drawing.Size(103, 56);
            this.btonAc.TabIndex = 2;
            this.btonAc.Text = "Dosya Aç";
            this.btonAc.UseVisualStyleBackColor = true;
            this.btonAc.Click += new System.EventHandler(this.btonAc_Click);
            // 
            // btonKaydet
            // 
            this.btonKaydet.Location = new System.Drawing.Point(171, 355);
            this.btonKaydet.Name = "btonKaydet";
            this.btonKaydet.Size = new System.Drawing.Size(108, 56);
            this.btonKaydet.TabIndex = 3;
            this.btonKaydet.Text = "Farklı Kaydet";
            this.btonKaydet.UseVisualStyleBackColor = true;
            this.btonKaydet.Click += new System.EventHandler(this.btonKaydet_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 587);
            this.Controls.Add(this.btonKaydet);
            this.Controls.Add(this.btonAc);
            this.Controls.Add(this.btonClose);
            this.Controls.Add(this.picbKitap);
            this.Name = "frmPictureBox";
            this.Text = "frmPictureBox";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbKitap;
        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.Button btonAc;
        private System.Windows.Forms.Button btonKaydet;
    }
}