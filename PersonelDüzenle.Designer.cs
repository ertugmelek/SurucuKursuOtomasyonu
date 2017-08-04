namespace Sürücü_Kursu_Otomasyonu
{
    partial class PersonelDüzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifresi = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Şifresi :";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(139, 46);
            this.txtAranan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(217, 25);
            this.txtAranan.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(139, 158);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(217, 25);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtKullaniciSifresi
            // 
            this.txtKullaniciSifresi.Location = new System.Drawing.Point(139, 201);
            this.txtKullaniciSifresi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKullaniciSifresi.Name = "txtKullaniciSifresi";
            this.txtKullaniciSifresi.Size = new System.Drawing.Size(217, 25);
            this.txtKullaniciSifresi.TabIndex = 5;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(274, 92);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(82, 42);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yetki :";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(276, 289);
            this.btnDüzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(80, 41);
            this.btnDüzenle.TabIndex = 8;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(139, 258);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(69, 21);
            this.rbAdmin.TabIndex = 9;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // PersonelDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 347);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtKullaniciSifresi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonelDüzenle";
            this.Text = "PersonelDüzenle";
            this.Load += new System.EventHandler(this.PersonelDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciSifresi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.RadioButton rbAdmin;
    }
}