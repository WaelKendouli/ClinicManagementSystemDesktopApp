using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLogicLayer.Events
{
    public class clsDoctorsEventArgs : EventArgs
    {
        public int DoctorID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Phone { get; }
        public string Email { get; }
        public string Address { get; }
        public string Gender { get; }
        public string PhotoURL { get; }
        public int SpecializationID { get; }

        public clsDoctorsEventArgs(
            int doctorID,
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string phone,
            string email,
            string address,
            string gender,
            string photoURL,
            int specializationID)
        {
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
        }

        public clsDoctorsEventArgs(
    string firstName,
    string lastName,
    DateTime dateOfBirth,
    string phone,
    string email,
    string address,
    string gender,
    string photoURL,
    int specializationID)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Address = address;
            Gender = gender;
            PhotoURL = photoURL;
            SpecializationID = specializationID;
        }


        public override string ToString()
        {
            return $"DoctorID: {DoctorID}, Name: {FirstName} {LastName}, Email: {Email}";
        }
    }
}
