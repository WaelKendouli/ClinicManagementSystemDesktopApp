using ClinicDataAccess;
using ClinicDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLogicLayer
{
    public class clsDoctor
    {
        enum Mode { eAdd = 1 , eUpdate = 2 }
        Mode _Mode = Mode.eAdd;
        public int DoctorID { get; set; } = -1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string PhotoURL { get; set; }
        public int SpecializationID { get; set; }
        public DoctorDTO DTO { get; set; }
        // Add compostion specialazation object
        public clsDoctor()
        {
        }
        public clsDoctor( string firstName, string lastName,
            DateTime dateOfBirth, string phone, string email, string address,
            string gender, string photoURL, int specializationID)
        {
            _Mode = Mode.eAdd;
            DoctorID = -1;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Address = address;
            Gender = gender;
            PhotoURL = photoURL;
            SpecializationID = specializationID;
            DTO = new DoctorDTO(this.DoctorID, this.FirstName,
                this.LastName, this.DateOfBirth, this.Phone, this.Email,
                this.Address, this.Gender, this.PhotoURL, this.SpecializationID);
        }
        private clsDoctor(int doctorID, string firstName, string lastName,
            DateTime dateOfBirth, string phone, string email, string address,
            string gender, string photoURL, int specializationID)
        {
            _Mode = Mode.eUpdate;
            DoctorID = doctorID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Address = address;
            Gender = gender;
            PhotoURL = photoURL;
            SpecializationID = specializationID;
            DTO = new DoctorDTO(this.DoctorID, this.FirstName,
              this.LastName, this.DateOfBirth, this.Phone, this.Email,
              this.Address, this.Gender, this.PhotoURL, this.SpecializationID);
        }
        private bool _Add()
        {
            return clsDoctorsDA.AddNewDoctor(this.FirstName, this.LastName, this.DateOfBirth,
                this.Phone, this.Email, this.Address, this.Gender, 
                this.PhotoURL, this.SpecializationID) > 0;
        }
        public clsDoctor FindDoctorByID(int DoctorID)
        {
            this.DTO = clsDoctorsDA.FindDoctorByID(DoctorID);
            return new clsDoctor(this.DoctorID, this.FirstName,
                this.LastName, this.DateOfBirth, this.Phone, this.Email,
                this.Address, this.Gender, this.PhotoURL, this.SpecializationID);
        }
        private bool _Update()
        {
            return clsDoctorsDA.UpdateDoctor(this.DoctorID, this.FirstName, this.LastName, this.DateOfBirth,
                this.Phone, this.Email, this.Address, this.Gender,
                this.PhotoURL, this.SpecializationID);

        }
        public override string ToString()
        {
            return $"Doctor full name {this.FirstName} {this.LastName} , Contact : Email & Phone [ {this.Email} | {this.Phone} ]";
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.eAdd:
                    if (_Add())
                    {
                        _Mode = Mode.eUpdate;
                        return true;
                    }
                    break;
                case Mode.eUpdate:
                    return _Update();
            }
            return false;
        }

    }
}
