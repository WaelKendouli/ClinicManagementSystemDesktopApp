using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicLogicLayer.Events;
using System.Windows.Forms;
using ClinicLogicLayer;

namespace ClinicMangementSystemDesktopApp
{
    public partial class frmSaveDoctorsInfo : Form
    {
        public frmSaveDoctorsInfo()
        {
            InitializeComponent();
        }
        HashSet<string> _RecentAddedDoctors = new HashSet<string>();
        enum enMode { eAdd , eUpdate };
        enMode _Mode = enMode.eAdd;
        int _DoctorID = -1;
        public void Save(clsDoctorsEventArgs e)
        {
            clsDoctor Doctor = new clsDoctor();
            string Operation = "";
            switch (_Mode)
            {
                case enMode.eAdd:
                    Doctor = new clsDoctor(e.FirstName.ToUpper(), e.LastName.ToUpper(),
                       e.DateOfBirth, e.Phone, e.Email, e.Address, e.Gender, e.PhotoURL, e.SpecializationID);
                    Operation = " Adding ";
                    break;
                case enMode.eUpdate:
                    if (_DoctorID==-1)
                    {
                        throw new Exception("Docotor Id was not valid because it is negative");
                    }
                    Doctor = clsDoctor.FindDoctorByID(_DoctorID);
                    ctrlSaveDoctorInfos1.FillUserControl(Doctor.DTO);
                    Doctor.ChangeAttribute(e.FirstName.ToUpper(), e.LastName.ToUpper(), e.DateOfBirth, e.Phone,
                        e.Email, e.Address, e.Gender, e.PhotoURL, e.SpecializationID);
                    Operation = " Updating ";
                    break;
            }
            if (_Mode == enMode.eAdd && _RecentAddedDoctors.Add(e.Email)==false)
            {
                MessageBox.Show($"{Operation} wans't performed successfully because {e.Email} has already been set try another one", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Doctor.Save())
            {
                MessageBox.Show($"{Operation} was performed successfully {Doctor.ToString()}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RecentAddedDoctors.Add(e.Email);
            }
            else
            {
                MessageBox.Show($"{Operation} has failed", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSaveDoctorsInfo_Load(object sender, EventArgs e)
        {

        }

        private void ctrlSaveDoctorInfos1_OnDoctorSaved(object sender, clsDoctorsEventArgs e)
        {
            Save(e);
        }

        private void frmSaveDoctorsInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrlSaveDoctorInfos1.ClearUserControl();
            _RecentAddedDoctors = null;
           
        }
    }
}
