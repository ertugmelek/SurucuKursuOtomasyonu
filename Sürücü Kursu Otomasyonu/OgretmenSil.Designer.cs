namespace Sürücü_Kursu_Otomasyonu
{
    partial class OgretmenSil
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
            this.cbOgretmenler = new System.Windows.Forms.ComboBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOgretmenler
            // 
            this.cbOgretmenler.FormattingEnabled = true;
            this.cbOgretmenler.Location = new System.Drawing.Point(97, 44);
            this.cbOgretmenler.Name = "cbOgretmenler";
            this.cbOgretmenler.Size = new System.Drawing.Size(206, 21);
            this.cbOgretmenler.TabIndex = 0;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(223, 89);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(74, 41);
            this.buttonSil.TabIndex = 1;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek :";
            // 
            // OgretmenSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.cbOgretmenler);
            this.Name = "OgretmenSil";
            this.Text = "OgretmenSil";
            this.Load += new System.EventHandler(this.OgretmenSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOgretmenler;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label label1;
    }
}