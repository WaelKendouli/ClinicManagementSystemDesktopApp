using ClinicLogicLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMangementSystemDesktopApp
{
    public partial class frmManageDoctors : Form
    {
        public frmManageDoctors()
        {
            InitializeComponent();
        }
        DataTable _dtDoctors = new DataTable();
        private void _Refresh()
        {
            _dtDoctors = clsDoctor.ShowListOfDoctors();
            clsCustomDataGridViewUserControl.LoadData(_dtDoctors, dgvDoctors, cbItems, null, 150);
        }
        private void frmManageDoctors_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveDoctorsInfo frm = new frmSaveDoctorsInfo();
            frm.ShowDialog();
            _Refresh();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsCustomDataGridViewUserControl.HandleTextBoxChangingEvent(txtInput, cbItems, _dtDoctors);
        }

        private void updateThisDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveDoctorsInfo frm = new frmSaveDoctorsInfo((int)dgvDoctors.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
