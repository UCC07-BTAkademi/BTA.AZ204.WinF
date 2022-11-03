
namespace Database2
{
    partial class frmEmployee
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
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.tboxSoyad = new System.Windows.Forms.TextBox();
            this.btonEkle = new System.Windows.Forms.Button();
            this.btonGüncelle = new System.Windows.Forms.Button();
            this.btonSil = new System.Windows.Forms.Button();
            this.dgrdEmployees = new System.Windows.Forms.DataGridView();
            this.tboxEmpID = new System.Windows.Forms.TextBox();
            this.btonAra = new System.Windows.Forms.Button();
            this.tboxAra = new System.Windows.Forms.TextBox();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.tboxCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxAd
            // 
            this.tboxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAd.Location = new System.Drawing.Point(120, 308);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(179, 26);
            this.tboxAd.TabIndex = 0;
            // 
            // tboxSoyad
            // 
            this.tboxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSoyad.Location = new System.Drawing.Point(120, 347);
            this.tboxSoyad.Name = "tboxSoyad";
            this.tboxSoyad.Size = new System.Drawing.Size(179, 26);
            this.tboxSoyad.TabIndex = 1;
            // 
            // btonEkle
            // 
            this.btonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonEkle.Location = new System.Drawing.Point(120, 478);
            this.btonEkle.Name = "btonEkle";
            this.btonEkle.Size = new System.Drawing.Size(102, 36);
            this.btonEkle.TabIndex = 3;
            this.btonEkle.Text = "Ekle";
            this.btonEkle.UseVisualStyleBackColor = true;
            this.btonEkle.Click += new System.EventHandler(this.btonEkle_Click);
            // 
            // btonGüncelle
            // 
            this.btonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonGüncelle.Location = new System.Drawing.Point(228, 478);
            this.btonGüncelle.Name = "btonGüncelle";
            this.btonGüncelle.Size = new System.Drawing.Size(102, 35);
            this.btonGüncelle.TabIndex = 4;
            this.btonGüncelle.Text = "Güncelle";
            this.btonGüncelle.UseVisualStyleBackColor = true;
            this.btonGüncelle.Click += new System.EventHandler(this.btonGüncelle_Click);
            // 
            // btonSil
            // 
            this.btonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonSil.Location = new System.Drawing.Point(336, 478);
            this.btonSil.Name = "btonSil";
            this.btonSil.Size = new System.Drawing.Size(102, 33);
            this.btonSil.TabIndex = 5;
            this.btonSil.Text = "Sil";
            this.btonSil.UseVisualStyleBackColor = true;
            this.btonSil.Click += new System.EventHandler(this.btonSil_Click);
            // 
            // dgrdEmployees
            // 
            this.dgrdEmployees.AllowUserToAddRows = false;
            this.dgrdEmployees.AllowUserToDeleteRows = false;
            this.dgrdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdEmployees.Location = new System.Drawing.Point(27, 24);
            this.dgrdEmployees.Name = "dgrdEmployees";
            this.dgrdEmployees.ReadOnly = true;
            this.dgrdEmployees.RowHeadersVisible = false;
            this.dgrdEmployees.RowHeadersWidth = 51;
            this.dgrdEmployees.RowTemplate.Height = 24;
            this.dgrdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdEmployees.Size = new System.Drawing.Size(796, 221);
            this.dgrdEmployees.TabIndex = 8;
            this.dgrdEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdEmployees_CellMouseClick);
            // 
            // tboxEmpID
            // 
            this.tboxEmpID.Enabled = false;
            this.tboxEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmpID.Location = new System.Drawing.Point(120, 265);
            this.tboxEmpID.Name = "tboxEmpID";
            this.tboxEmpID.Size = new System.Drawing.Size(67, 26);
            this.tboxEmpID.TabIndex = 10;
            // 
            // btonAra
            // 
            this.btonAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonAra.Location = new System.Drawing.Point(721, 298);
            this.btonAra.Name = "btonAra";
            this.btonAra.Size = new System.Drawing.Size(102, 36);
            this.btonAra.TabIndex = 11;
            this.btonAra.Text = "Ara";
            this.btonAra.UseVisualStyleBackColor = true;
            this.btonAra.Click += new System.EventHandler(this.btonAra_Click);
            // 
            // tboxAra
            // 
            this.tboxAra.Location = new System.Drawing.Point(601, 298);
            this.tboxAra.Name = "tboxAra";
            this.tboxAra.Size = new System.Drawing.Size(100, 22);
            this.tboxAra.TabIndex = 12;
            // 
            // tboxCity
            // 
            this.tboxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCity.Location = new System.Drawing.Point(120, 379);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(179, 26);
            this.tboxCity.TabIndex = 13;
            // 
            // tboxCountry
            // 
            this.tboxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCountry.Location = new System.Drawing.Point(120, 411);
            this.tboxCountry.Name = "tboxCountry";
            this.tboxCountry.Size = new System.Drawing.Size(179, 26);
            this.tboxCountry.TabIndex = 14;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 608);
            this.Controls.Add(this.tboxCountry);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.tboxAra);
            this.Controls.Add(this.btonAra);
            this.Controls.Add(this.tboxEmpID);
            this.Controls.Add(this.dgrdEmployees);
            this.Controls.Add(this.btonSil);
            this.Controls.Add(this.btonGüncelle);
            this.Controls.Add(this.btonEkle);
            this.Controls.Add(this.tboxSoyad);
            this.Controls.Add(this.tboxAd);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.TextBox tboxSoyad;
        private System.Windows.Forms.Button btonEkle;
        private System.Windows.Forms.Button btonGüncelle;
        private System.Windows.Forms.Button btonSil;
        private System.Windows.Forms.DataGridView dgrdEmployees;
        private System.Windows.Forms.TextBox tboxEmpID;
        private System.Windows.Forms.Button btonAra;
        private System.Windows.Forms.TextBox tboxAra;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.TextBox tboxCountry;
    }
}