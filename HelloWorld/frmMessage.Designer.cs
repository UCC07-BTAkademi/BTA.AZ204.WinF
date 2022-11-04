
namespace HelloWorld_WinF
{
    partial class frmMessage
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
            this.lbelMessage = new System.Windows.Forms.Label();
            this.btonOK = new System.Windows.Forms.Button();
            this.btonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbelMessage.Location = new System.Drawing.Point(33, 70);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(117, 46);
            this.lbelMessage.TabIndex = 0;
            this.lbelMessage.Text = "label1";
            // 
            // btonOK
            // 
            this.btonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btonOK.Location = new System.Drawing.Point(23, 194);
            this.btonOK.Name = "btonOK";
            this.btonOK.Size = new System.Drawing.Size(94, 29);
            this.btonOK.TabIndex = 1;
            this.btonOK.Text = "OK";
            this.btonOK.UseVisualStyleBackColor = true;
            // 
            // btonCancel
            // 
            this.btonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btonCancel.Location = new System.Drawing.Point(576, 194);
            this.btonCancel.Name = "btonCancel";
            this.btonCancel.Size = new System.Drawing.Size(94, 29);
            this.btonCancel.TabIndex = 2;
            this.btonCancel.Text = "Cancel";
            this.btonCancel.UseVisualStyleBackColor = true;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 235);
            this.Controls.Add(this.btonCancel);
            this.Controls.Add(this.btonOK);
            this.Controls.Add(this.lbelMessage);
            this.Name = "frmMessage";
            this.Text = "frmMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btonOK;
        private System.Windows.Forms.Button btonCancel;
        public System.Windows.Forms.Label lbelMessage;
    }
}