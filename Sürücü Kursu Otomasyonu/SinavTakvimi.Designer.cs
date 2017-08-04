namespace Sürücü_Kursu_Otomasyonu
{
    partial class SinavTakvimi
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2014, 6, 14, 0, 0, 0, 0),
        new System.DateTime(2014, 7, 12, 0, 0, 0, 0),
        new System.DateTime(2014, 8, 9, 0, 0, 0, 0),
        new System.DateTime(2014, 9, 6, 0, 0, 0, 0),
        new System.DateTime(2014, 10, 18, 0, 0, 0, 0),
        new System.DateTime(2014, 12, 6, 0, 0, 0, 0)};
            this.monthCalendar1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar1.Location = new System.Drawing.Point(39, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // SinavTakvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 220);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "SinavTakvimi";
            this.Text = "SinavTakvimi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;

    }
}