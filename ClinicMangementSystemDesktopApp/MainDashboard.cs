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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDoctors frm = new frmManageDoctors();
            frm.ShowDialog();
        }
    }
}
