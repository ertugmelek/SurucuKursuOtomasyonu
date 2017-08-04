namespace Sürücü_Kursu_Otomasyonu
{
    partial class DersProgrami
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
            this.listTrafik = new System.Windows.Forms.ListBox();
            this.TrafikDersi = new System.Windows.Forms.Label();
            this.listİlkYardim = new System.Windows.Forms.ListBox();
            this.listMotor = new System.Windows.Forms.ListBox();
            this.İlkYardimDersi = new System.Windows.Forms.Label();
            this.MotorDersi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listTrafik
            // 
            this.listTrafik.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listTrafik.FormattingEnabled = true;
            this.listTrafik.ItemHeight = 15;
            this.listTrafik.Items.AddRange(new object[] {
            "",
            "Pazartesi :  13:00 -15:00 /  19:00-21:00",
            " ",
            "Perşembe : 10:00 - 12:00 ",
            "",
            "Cumartesi : 13:00 - 15:00"});
            this.listTrafik.Location = new System.Drawing.Point(40, 41);
            this.listTrafik.Name = "listTrafik";
            this.listTrafik.Size = new System.Drawing.Size(274, 94);
            this.listTrafik.TabIndex = 0;
            // 
            // TrafikDersi
            // 
            this.TrafikDersi.AutoSize = true;
            this.TrafikDersi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TrafikDersi.Location = new System.Drawing.Point(37, 21);
            this.TrafikDersi.Name = "TrafikDersi";
            this.TrafikDersi.Size = new System.Drawing.Size(87, 17);
            this.TrafikDersi.TabIndex = 1;
            this.TrafikDersi.Text = "Trafik Dersi";
            // 
            // listİlkYardim
            // 
            this.listİlkYardim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listİlkYardim.FormattingEnabled = true;
            this.listİlkYardim.ItemHeight = 15;
            this.listİlkYardim.Items.AddRange(new object[] {
            "",
            "Salı : 13:00 - 15:00 / 19:00 - 21:00",
            "",
            "Çarşamba : 19:00 - 21:00 ",
            "",
            "Cumartesi : 15:00- 17:00"});
            this.listİlkYardim.Location = new System.Drawing.Point(40, 163);
            this.listİlkYardim.Name = "listİlkYardim";
            this.listİlkYardim.Size = new System.Drawing.Size(274, 94);
            this.listİlkYardim.TabIndex = 2;
            // 
            // listMotor
            // 
            this.listMotor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listMotor.FormattingEnabled = true;
            this.listMotor.ItemHeight = 15;
            this.listMotor.Items.AddRange(new object[] {
            "",
            "Cuma : 10:00 - 12:00 / 16:00 - 18:00",
            " ",
            "Çarşamba : 13:00 - 15:00",
            "",
            "Pazar : 17:00 - 19:00"});
            this.listMotor.Location = new System.Drawing.Point(40, 286);
            this.listMotor.Name = "listMotor";
            this.listMotor.Size = new System.Drawing.Size(274, 94);
            this.listMotor.TabIndex = 3;
            // 
            // İlkYardimDersi
            // 
            this.İlkYardimDersi.AutoSize = true;
            this.İlkYardimDersi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İlkYardimDersi.Location = new System.Drawing.Point(37, 143);
            this.İlkYardimDersi.Name = "İlkYardimDersi";
            this.İlkYardimDersi.Size = new System.Drawing.Size(115, 17);
            this.İlkYardimDersi.TabIndex = 4;
            this.İlkYardimDersi.Text = "İlk Yardım Dersi";
            // 
            // MotorDersi
            // 
            this.MotorDersi.AutoSize = true;
            this.MotorDersi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MotorDersi.Location = new System.Drawing.Point(37, 266);
            this.MotorDersi.Name = "MotorDersi";
            this.MotorDersi.Size = new System.Drawing.Size(90, 17);
            this.MotorDersi.TabIndex = 5;
            this.MotorDersi.Text = "Motor Dersi";
            // 
            // DersProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 392);
            this.Controls.Add(this.MotorDersi);
            this.Controls.Add(this.İlkYardimDersi);
            this.Controls.Add(this.listMotor);
            this.Controls.Add(this.listİlkYardim);
            this.Controls.Add(this.TrafikDersi);
            this.Controls.Add(this.listTrafik);
            this.Name = "DersProgrami";
            this.Text = "DersProgrami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTrafik;
        private System.Windows.Forms.Label TrafikDersi;
        private System.Windows.Forms.ListBox listİlkYardim;
        private System.Windows.Forms.ListBox listMotor;
        private System.Windows.Forms.Label İlkYardimDersi;
        private System.Windows.Forms.Label MotorDersi;
    }
}