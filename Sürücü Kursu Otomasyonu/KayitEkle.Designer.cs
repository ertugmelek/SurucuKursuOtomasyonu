namespace Sürücü_Kursu_Otomasyonu
{
    partial class KayitEkle
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
            this.Adi = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.Soyadi = new System.Windows.Forms.Label();
            this.textTC = new System.Windows.Forms.TextBox();
            this.TelNo = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.msktextTelNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Adi
            // 
            this.Adi.AutoSize = true;
            this.Adi.BackColor = System.Drawing.SystemColors.Control;
            this.Adi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adi.Location = new System.Drawing.Point(53, 85);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(40, 17);
            this.Adi.TabIndex = 0;
            this.Adi.Text = "Adı :";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(95, 82);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(212, 20);
            this.textAd.TabIndex = 2;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(95, 127);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(212, 20);
            this.textSoyad.TabIndex = 3;
            // 
            // Soyadi
            // 
            this.Soyadi.AutoSize = true;
            this.Soyadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyadi.Location = new System.Drawing.Point(33, 130);
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.Size = new System.Drawing.Size(59, 17);
            this.Soyadi.TabIndex = 3;
            this.Soyadi.Text = "Soyadı :";
            // 
            // textTC
            // 
            this.textTC.Location = new System.Drawing.Point(95, 40);
            this.textTC.Name = "textTC";
            this.textTC.Size = new System.Drawing.Size(212, 20);
            this.textTC.TabIndex = 1;
            this.textTC.TextChanged += new System.EventHandler(this.textTC_TextChanged);
            this.textTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTC_KeyPress);
            // 
            // TelNo
            // 
            this.TelNo.AutoSize = true;
            this.TelNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelNo.Location = new System.Drawing.Point(4, 179);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(89, 17);
            this.TelNo.TabIndex = 5;
            this.TelNo.Text = "Telefon No :";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(55, 41);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(38, 17);
            this.tc.TabIndex = 6;
            this.tc.Text = "TC :";
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(95, 220);
            this.textAdres.Multiline = true;
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(212, 80);
            this.textAdres.TabIndex = 8;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adres.Location = new System.Drawing.Point(35, 220);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(57, 17);
            this.Adres.TabIndex = 9;
            this.Adres.Text = "Adres :";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(162, 315);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 41);
            this.buttonEkle.TabIndex = 10;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // msktextTelNo
            // 
            this.msktextTelNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktextTelNo.Location = new System.Drawing.Point(95, 176);
            this.msktextTelNo.Mask = "(999) 000-0000";
            this.msktextTelNo.Name = "msktextTelNo";
            this.msktextTelNo.Size = new System.Drawing.Size(212, 26);
            this.msktextTelNo.TabIndex = 4;
            // 
            // KayitEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 410);
            this.Controls.Add(this.msktextTelNo);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.textTC);
            this.Controls.Add(this.Soyadi);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.Adi);
            this.Name = "KayitEkle";
            this.Text = "KayitEkle";
            this.Load += new System.EventHandler(this.KayitEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adi;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label Soyadi;
        private System.Windows.Forms.TextBox textTC;
        private System.Windows.Forms.Label TelNo;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.MaskedTextBox msktextTelNo;
    }
}