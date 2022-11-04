
namespace Kontroller
{
    partial class frmCheckbox
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
            this.chkbMesaj = new System.Windows.Forms.CheckBox();
            this.btonMesaj = new System.Windows.Forms.Button();
            this.lbelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Location = new System.Drawing.Point(246, 270);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(87, 34);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // chkbMesaj
            // 
            this.chkbMesaj.AutoSize = true;
            this.chkbMesaj.Location = new System.Drawing.Point(79, 47);
            this.chkbMesaj.Name = "chkbMesaj";
            this.chkbMesaj.Size = new System.Drawing.Size(103, 21);
            this.chkbMesaj.TabIndex = 1;
            this.chkbMesaj.Text = "Mesaj ver...";
            this.chkbMesaj.UseVisualStyleBackColor = true;
            this.chkbMesaj.CheckedChanged += new System.EventHandler(this.chkbMesaj_CheckedChanged);
            // 
            // btonMesaj
            // 
            this.btonMesaj.Location = new System.Drawing.Point(218, 47);
            this.btonMesaj.Name = "btonMesaj";
            this.btonMesaj.Size = new System.Drawing.Size(75, 23);
            this.btonMesaj.TabIndex = 2;
            this.btonMesaj.Text = "Mesaj";
            this.btonMesaj.UseVisualStyleBackColor = true;
            this.btonMesaj.Click += new System.EventHandler(this.btonMesaj_Click);
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelMessage.Location = new System.Drawing.Point(76, 129);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(76, 30);
            this.lbelMessage.TabIndex = 3;
            this.lbelMessage.Text = "label1";
            // 
            // frmCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 316);
            this.Controls.Add(this.lbelMessage);
            this.Controls.Add(this.btonMesaj);
            this.Controls.Add(this.chkbMesaj);
            this.Controls.Add(this.btonClose);
            this.Name = "frmCheckbox";
            this.Text = "frmCheckbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.CheckBox chkbMesaj;
        private System.Windows.Forms.Button btonMesaj;
        private System.Windows.Forms.Label lbelMessage;
    }
}