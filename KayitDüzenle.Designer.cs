namespace Sürücü_Kursu_Otomasyonu
{
    partial class KayitDüzenle
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
            this.DüzenlenecekKisi = new System.Windows.Forms.Label();
            this.btnbul = new System.Windows.Forms.Button();
            this.cbKisiler = new System.Windows.Forms.ComboBox();
            this.Soyadi = new System.Windows.Forms.Label();
            this.Adi = new System.Windows.Forms.Label();
            this.TelNo = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.msktextTelNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // DüzenlenecekKisi
            // 
            this.DüzenlenecekKisi.AutoSize = true;
            this.DüzenlenecekKisi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DüzenlenecekKisi.Location = new System.Drawing.Point(19, 20);
            this.DüzenlenecekKisi.Name = "DüzenlenecekKisi";
            this.DüzenlenecekKisi.Size = new System.Drawing.Size(141, 17);
            this.DüzenlenecekKisi.TabIndex = 1;
            this.DüzenlenecekKisi.Text = "Düzenlenecek Kişi :";
            // 
            // btnbul
            // 
            this.btnbul.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbul.Location = new System.Drawing.Point(294, 48);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(86, 40);
            this.btnbul.TabIndex = 2;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.bul_Click);
            // 
            // cbKisiler
            // 
            this.cbKisiler.FormattingEnabled = true;
            this.cbKisiler.Location = new System.Drawing.Point(22, 55);
            this.cbKisiler.Name = "cbKisiler";
            this.cbKisiler.Size = new System.Drawing.Size(229, 21);
            this.cbKisiler.TabIndex = 3;
            // 
            // Soyadi
            // 
            this.Soyadi.AutoSize = true;
            this.Soyadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyadi.Location = new System.Drawing.Point(19, 200);
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.Size = new System.Drawing.Size(59, 17);
            this.Soyadi.TabIndex = 5;
            this.Soyadi.Text = "Soyadi :";
            // 
            // Adi
            // 
            this.Adi.AutoSize = true;
            this.Adi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adi.Location = new System.Drawing.Point(19, 141);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(40, 17);
            this.Adi.TabIndex = 6;
            this.Adi.Text = "Adi :";
            // 
            // TelNo
            // 
            this.TelNo.AutoSize = true;
            this.TelNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelNo.Location = new System.Drawing.Point(19, 249);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(89, 17);
            this.TelNo.TabIndex = 7;
            this.TelNo.Text = "Telefon No :";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(166, 141);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(214, 20);
            this.textAd.TabIndex = 9;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(166, 193);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(214, 20);
            this.textSoyad.TabIndex = 10;
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(166, 297);
            this.textAdres.Multiline = true;
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(214, 71);
            this.textAdres.TabIndex = 12;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adres.Location = new System.Drawing.Point(19, 297);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(57, 17);
            this.Adres.TabIndex = 13;
            this.Adres.Text = "Adres :";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(166, 385);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(214, 31);
            this.btnDuzenle.TabIndex = 14;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // msktextTelNo
            // 
            this.msktextTelNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktextTelNo.Location = new System.Drawing.Point(166, 246);
            this.msktextTelNo.Mask = "(999) 000-0000";
            this.msktextTelNo.Name = "msktextTelNo";
            this.msktextTelNo.Size = new System.Drawing.Size(214, 26);
            this.msktextTelNo.TabIndex = 15;
            // 
            // KayitDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 419);
            this.Controls.Add(this.msktextTelNo);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.Soyadi);
            this.Controls.Add(this.cbKisiler);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.DüzenlenecekKisi);
            this.Name = "KayitDüzenle";
            this.Text = "KayitDüzenle";
            this.Load += new System.EventHandler(this.KayitDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DüzenlenecekKisi;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.ComboBox cbKisiler;
        private System.Windows.Forms.Label Soyadi;
        private System.Windows.Forms.Label Adi;
        private System.Windows.Forms.Label TelNo;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.MaskedTextBox msktextTelNo;
    }
}