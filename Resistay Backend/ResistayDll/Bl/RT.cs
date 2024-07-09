using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class RT : Resident
    {
        private string PhoneNumber;
        private List<Salary> Checks;
        public RT() 
        {


        }

        public RT(string name, string password, int age, string cnic, string role, string gender) :  base(name, password, age, cnic, role, gender)
        {


        }
        public RT(string name, string password, int age, string cnic, string role, string gender, Hostel hostel, string phonenumber) : base(name, password, age, cnic, role, gender, hostel)
        {
            this.PhoneNumber = phonenumber;
        }
        public RT (string name, string password, int age, string cnic, string role, string gender, Hostel hostel, string phonenumber,List<Salary> Checks) : this (name, password, age, cnic, role, gender, hostel , phonenumber)

        {
            this.Checks = Checks;
        }
        public string GetPhoneNumber() { return this.PhoneNumber; }
        public void SetPhoneNumber(string phoneNumber) { this.PhoneNumber = phoneNumber; }

    }
}
