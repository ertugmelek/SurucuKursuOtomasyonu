namespace Sürücü_Kursu_Otomasyonu
{
    partial class KayitSil
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
            this.SilinecekKisi = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.cbKisiler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SilinecekKisi
            // 
            this.SilinecekKisi.AutoSize = true;
            this.SilinecekKisi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilinecekKisi.Location = new System.Drawing.Point(27, 59);
            this.SilinecekKisi.Name = "SilinecekKisi";
            this.SilinecekKisi.Size = new System.Drawing.Size(108, 17);
            this.SilinecekKisi.TabIndex = 0;
            this.SilinecekKisi.Text = "Silinecek Kişi :";
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(242, 93);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(76, 41);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // cbKisiler
            // 
            this.cbKisiler.FormattingEnabled = true;
            this.cbKisiler.Location = new System.Drawing.Point(141, 55);
            this.cbKisiler.Name = "cbKisiler";
            this.cbKisiler.Size = new System.Drawing.Size(177, 21);
            this.cbKisiler.TabIndex = 3;
            // 
            // KayitSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 150);
            this.Controls.Add(this.cbKisiler);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.SilinecekKisi);
            this.Name = "KayitSil";
            this.Text = "KayitSil";
            this.Load += new System.EventHandler(this.KayitSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SilinecekKisi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ComboBox cbKisiler;
    }
}