
namespace Tores.v2
{
    partial class frmLogin
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
            this.tboxUName = new System.Windows.Forms.TextBox();
            this.tboxUPass = new System.Windows.Forms.TextBox();
            this.btonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxUName
            // 
            this.tboxUName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUName.Location = new System.Drawing.Point(161, 54);
            this.tboxUName.MaxLength = 10;
            this.tboxUName.Name = "tboxUName";
            this.tboxUName.Size = new System.Drawing.Size(161, 31);
            this.tboxUName.TabIndex = 0;
            // 
            // tboxUPass
            // 
            this.tboxUPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUPass.Location = new System.Drawing.Point(161, 106);
            this.tboxUPass.MaxLength = 10;
            this.tboxUPass.Name = "tboxUPass";
            this.tboxUPass.PasswordChar = '*';
            this.tboxUPass.Size = new System.Drawing.Size(161, 31);
            this.tboxUPass.TabIndex = 1;
            // 
            // btonLogin
            // 
            this.btonLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonLogin.Location = new System.Drawing.Point(161, 167);
            this.btonLogin.Name = "btonLogin";
            this.btonLogin.Size = new System.Drawing.Size(91, 53);
            this.btonLogin.TabIndex = 2;
            this.btonLogin.Text = "Login";
            this.btonLogin.UseVisualStyleBackColor = true;
            this.btonLogin.Click += new System.EventHandler(this.btonLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 331);
            this.ControlBox = false;
            this.Controls.Add(this.btonLogin);
            this.Controls.Add(this.tboxUPass);
            this.Controls.Add(this.tboxUName);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUName;
        private System.Windows.Forms.TextBox tboxUPass;
        private System.Windows.Forms.Button btonLogin;
    }
}