using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicLogicLayer;
using ClinicLogicLayer.Events;
using LogicLayer;
namespace ClinicMangementSystemDesktopApp
{
    public partial class ctrlSaveDoctorInfos : UserControl
    {
        public ctrlSaveDoctorInfos()
        {
            InitializeComponent();
        }
        string Gender = "Male";

        public event EventHandler<clsDoctorsEventArgs> OnDoctorSaved;
        string _PhotosURL = string.Empty;
        protected virtual void DoctorSaved(clsDoctorsEventArgs e)
        {
            OnDoctorSaved?.Invoke(this, e);
        }
        private Dictionary<string, int> _dicSpecialazation = new Dictionary<string, int>();
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void InitialazSpecialazations()
        {
            _dicSpecialazation = clsSpecialazation.GetSpecialazations();
            try
            {
                if (_dicSpecialazation.Count > 0)
                {
                    foreach (var item in _dicSpecialazation)
                    {
                        cbSpecializations.Items.Add(item.Key);
                    }
                    cbSpecializations.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
        private void ctrlSaveDoctorInfos_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            InitialazSpecialazations();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtFirstName, e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtFirstName, e, clsInputValidator.IsNameNotValid, "Name is not valid");

        }

        private void rxtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtLastName , e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtLastName, e, clsInputValidator.IsNameNotValid, "Last name is not valid");

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtEmail, e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtEmail, e, clsInputValidator.IsEmailNotValid, "Email is not valid");

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPhone, e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPhone, e, clsInputValidator.IsNameNotValid, "Phone is not valid");

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtAddress, e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtAddress, e, clsInputValidator.IsNameNotValid, "Address is not valid");

        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void cbSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ClearUserControl()
        {
            _dicSpecialazation = null;
            Gender = null;
            _PhotosURL = null;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            DoctorSaved(new clsDoctorsEventArgs(txtFirstName.Text, txtLastName.Text,
                dtpDateOfBirth.Value, txtPhone.Text, txtEmail.Text, txtAddress.Text, Gender , _PhotosURL, _dicSpecialazation[cbSpecializations.SelectedText]));
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            _PhotosURL = clsPhotosHandeling._SelectPhotoCover(pbPicture);
        }
    }
}
