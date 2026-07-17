namespace ClinicMangementSystemDesktopApp
{
    partial class frmManageDoctors
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateThisDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findSpecificDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(422, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.ContextMenuStrip = this.cmsOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoctors.Location = new System.Drawing.Point(32, 219);
            this.dgvDoctors.Name = "dgvDoctors";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(1253, 443);
            this.dgvDoctors.TabIndex = 1;
            // 
            // cmsOptions
            // 
            this.cmsOptions.BackColor = System.Drawing.Color.Teal;
            this.cmsOptions.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDoctorToolStripMenuItem,
            this.updateThisDoctorToolStripMenuItem,
            this.deleteThisDoctorToolStripMenuItem,
            this.findSpecificDoctorToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(291, 176);
            // 
            // addNewDoctorToolStripMenuItem
            // 
            this.addNewDoctorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewDoctorToolStripMenuItem.Name = "addNewDoctorToolStripMenuItem";
            this.addNewDoctorToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.addNewDoctorToolStripMenuItem.Text = "Add new Doctor";
            this.addNewDoctorToolStripMenuItem.Click += new System.EventHandler(this.addNewDoctorToolStripMenuItem_Click);
            // 
            // updateThisDoctorToolStripMenuItem
            // 
            this.updateThisDoctorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateThisDoctorToolStripMenuItem.Name = "updateThisDoctorToolStripMenuItem";
            this.updateThisDoctorToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.updateThisDoctorToolStripMenuItem.Text = "Update this doctor";
            this.updateThisDoctorToolStripMenuItem.Click += new System.EventHandler(this.updateThisDoctorToolStripMenuItem_Click);
            // 
            // deleteThisDoctorToolStripMenuItem
            // 
            this.deleteThisDoctorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteThisDoctorToolStripMenuItem.Name = "deleteThisDoctorToolStripMenuItem";
            this.deleteThisDoctorToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.deleteThisDoctorToolStripMenuItem.Text = "Delete this doctor";
            // 
            // findSpecificDoctorToolStripMenuItem
            // 
            this.findSpecificDoctorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.findSpecificDoctorToolStripMenuItem.Name = "findSpecificDoctorToolStripMenuItem";
            this.findSpecificDoctorToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.findSpecificDoctorToolStripMenuItem.Text = "Find Specific doctor";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(44, 160);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(413, 38);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // cbItems
            // 
            this.cbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(482, 160);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(363, 37);
            this.cbItems.TabIndex = 3;
            // 
            // frmManageDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 710);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.label1);
            this.Name = "frmManageDoctors";
            this.Text = "frmManageDoctors";
            this.Load += new System.EventHandler(this.frmManageDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem addNewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateThisDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findSpecificDoctorToolStripMenuItem;
    }
}