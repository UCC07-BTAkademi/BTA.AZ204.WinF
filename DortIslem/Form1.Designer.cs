
namespace DortIslem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSayi2 = new System.Windows.Forms.TextBox();
            this.lbelSonuc = new System.Windows.Forms.Label();
            this.btonTopla = new System.Windows.Forms.Button();
            this.btonFark = new System.Windows.Forms.Button();
            this.btonCarp = new System.Windows.Forms.Button();
            this.btonBol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1";
            // 
            // tboxSayi1
            // 
            this.tboxSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSayi1.Location = new System.Drawing.Point(225, 72);
            this.tboxSayi1.Name = "tboxSayi1";
            this.tboxSayi1.Size = new System.Drawing.Size(164, 38);
            this.tboxSayi1.TabIndex = 1;
            this.tboxSayi1.TextChanged += new System.EventHandler(this.tboxSayi1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı2";
            // 
            // tboxSayi2
            // 
            this.tboxSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSayi2.Location = new System.Drawing.Point(225, 117);
            this.tboxSayi2.Name = "tboxSayi2";
            this.tboxSayi2.Size = new System.Drawing.Size(164, 38);
            this.tboxSayi2.TabIndex = 3;
            this.tboxSayi2.TextChanged += new System.EventHandler(this.tboxSayi2_TextChanged);
            // 
            // lbelSonuc
            // 
            this.lbelSonuc.AutoSize = true;
            this.lbelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelSonuc.Location = new System.Drawing.Point(84, 320);
            this.lbelSonuc.Name = "lbelSonuc";
            this.lbelSonuc.Size = new System.Drawing.Size(79, 29);
            this.lbelSonuc.TabIndex = 5;
            this.lbelSonuc.Text = "label3";
            // 
            // btonTopla
            // 
            this.btonTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonTopla.Location = new System.Drawing.Point(221, 200);
            this.btonTopla.Name = "btonTopla";
            this.btonTopla.Size = new System.Drawing.Size(75, 41);
            this.btonTopla.TabIndex = 6;
            this.btonTopla.Text = "Topla";
            this.btonTopla.UseVisualStyleBackColor = true;
            this.btonTopla.Click += new System.EventHandler(this.btonTopla_Click);
            // 
            // btonFark
            // 
            this.btonFark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonFark.Location = new System.Drawing.Point(312, 200);
            this.btonFark.Name = "btonFark";
            this.btonFark.Size = new System.Drawing.Size(75, 41);
            this.btonFark.TabIndex = 7;
            this.btonFark.Text = "Çıkart";
            this.btonFark.UseVisualStyleBackColor = true;
            this.btonFark.Click += new System.EventHandler(this.btonFark_Click);
            // 
            // btonCarp
            // 
            this.btonCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonCarp.Location = new System.Drawing.Point(404, 200);
            this.btonCarp.Name = "btonCarp";
            this.btonCarp.Size = new System.Drawing.Size(75, 41);
            this.btonCarp.TabIndex = 8;
            this.btonCarp.Text = "Çarp";
            this.btonCarp.UseVisualStyleBackColor = true;
            this.btonCarp.Click += new System.EventHandler(this.btonCarp_Click);
            // 
            // btonBol
            // 
            this.btonBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonBol.Location = new System.Drawing.Point(499, 200);
            this.btonBol.Name = "btonBol";
            this.btonBol.Size = new System.Drawing.Size(75, 41);
            this.btonBol.TabIndex = 9;
            this.btonBol.Text = "Böl";
            this.btonBol.UseVisualStyleBackColor = true;
            this.btonBol.Click += new System.EventHandler(this.btonBol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btonBol);
            this.Controls.Add(this.btonCarp);
            this.Controls.Add(this.btonFark);
            this.Controls.Add(this.btonTopla);
            this.Controls.Add(this.lbelSonuc);
            this.Controls.Add(this.tboxSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxSayi1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSayi2;
        private System.Windows.Forms.Label lbelSonuc;
        private System.Windows.Forms.Button btonTopla;
        private System.Windows.Forms.Button btonFark;
        private System.Windows.Forms.Button btonCarp;
        private System.Windows.Forms.Button btonBol;
    }
}

