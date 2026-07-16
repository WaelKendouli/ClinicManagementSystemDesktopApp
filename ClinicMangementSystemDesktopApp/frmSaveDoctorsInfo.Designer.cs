namespace ClinicMangementSystemDesktopApp
{
    partial class frmSaveDoctorsInfo
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
            this.ctrlSaveDoctorInfos1 = new ClinicMangementSystemDesktopApp.ctrlSaveDoctorInfos();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlSaveDoctorInfos1
            // 
            this.ctrlSaveDoctorInfos1.BackColor = System.Drawing.Color.White;
            this.ctrlSaveDoctorInfos1.Location = new System.Drawing.Point(33, 81);
            this.ctrlSaveDoctorInfos1.Name = "ctrlSaveDoctorInfos1";
            this.ctrlSaveDoctorInfos1.Size = new System.Drawing.Size(1005, 509);
            this.ctrlSaveDoctorInfos1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(423, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save Doctor Infos";
            // 
            // frmSaveDoctorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSaveDoctorInfos1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveDoctorsInfo";
            this.Text = "frmSaveDoctorsInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSaveDoctorInfos ctrlSaveDoctorInfos1;
        private System.Windows.Forms.Label label1;
    }
}