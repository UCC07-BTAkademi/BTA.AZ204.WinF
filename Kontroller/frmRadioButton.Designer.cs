
namespace Kontroller
{
    partial class frmRadioButton
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
            this.btonClose = new System.Windows.Forms.Button();
            this.radbE = new System.Windows.Forms.RadioButton();
            this.grpCinsiyet = new System.Windows.Forms.GroupBox();
            this.radbK = new System.Windows.Forms.RadioButton();
            this.lbelMesaj = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(395, 360);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(95, 32);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // radbE
            // 
            this.radbE.AutoSize = true;
            this.radbE.Location = new System.Drawing.Point(21, 34);
            this.radbE.Name = "radbE";
            this.radbE.Size = new System.Drawing.Size(65, 21);
            this.radbE.TabIndex = 1;
            this.radbE.TabStop = true;
            this.radbE.Text = "Erkek";
            this.radbE.UseVisualStyleBackColor = true;
            this.radbE.CheckedChanged += new System.EventHandler(this.radbE_CheckedChanged);
            // 
            // grpCinsiyet
            // 
            this.grpCinsiyet.Controls.Add(this.radbK);
            this.grpCinsiyet.Controls.Add(this.radbE);
            this.grpCinsiyet.Location = new System.Drawing.Point(98, 34);
            this.grpCinsiyet.Name = "grpCinsiyet";
            this.grpCinsiyet.Size = new System.Drawing.Size(179, 112);
            this.grpCinsiyet.TabIndex = 2;
            this.grpCinsiyet.TabStop = false;
            this.grpCinsiyet.Text = "Cinsiyet Seçiniz";
            // 
            // radbK
            // 
            this.radbK.AutoSize = true;
            this.radbK.Location = new System.Drawing.Point(21, 74);
            this.radbK.Name = "radbK";
            this.radbK.Size = new System.Drawing.Size(65, 21);
            this.radbK.TabIndex = 2;
            this.radbK.TabStop = true;
            this.radbK.Text = "Kadın";
            this.radbK.UseVisualStyleBackColor = true;
            this.radbK.CheckedChanged += new System.EventHandler(this.radbK_CheckedChanged);
            // 
            // lbelMesaj
            // 
            this.lbelMesaj.AutoSize = true;
            this.lbelMesaj.Font = new System.Drawing.Font("Megrim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelMesaj.Location = new System.Drawing.Point(107, 225);
            this.lbelMesaj.Name = "lbelMesaj";
            this.lbelMesaj.Size = new System.Drawing.Size(90, 28);
            this.lbelMesaj.TabIndex = 3;
            this.lbelMesaj.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // frmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 404);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbelMesaj);
            this.Controls.Add(this.grpCinsiyet);
            this.Controls.Add(this.btonClose);
            this.Name = "frmRadioButton";
            this.Text = "Radio Button Kontrolü";
            this.Load += new System.EventHandler(this.frmRadioButton_Load);
            this.grpCinsiyet.ResumeLayout(false);
            this.grpCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.RadioButton radbE;
        private System.Windows.Forms.GroupBox grpCinsiyet;
        private System.Windows.Forms.RadioButton radbK;
        private System.Windows.Forms.Label lbelMesaj;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}