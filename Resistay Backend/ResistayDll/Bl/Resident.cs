using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
   public class Resident
    {
        protected string Name;
        protected string Password;
        protected int Age;
        protected string Cnic;
        protected string Role;
        protected string Gender;
        protected Hostel HostelName;

        public Resident(string name, string password, int age, string cnic, string role, string gender)
        {
            Name = name;
            Password = password;
            Age = age;
            Cnic = cnic;
            Role = role;
            Gender = gender;
          
        }
        public Resident() { }
        public Resident(string name, string password, int age, string cnic, string role, string gender, Hostel hostel ) : this(name, password, age, cnic, role, gender)
        { 
            this.HostelName = hostel;
        }
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void SetPassword(string password)
        {
            Password = password;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public string GetCnic()
        {
            return Cnic;
        }

        public void SetCnic(string cnic)
        {
            Cnic = cnic;
        }

        public string GetRole()
        {
            return Role;
        }

        public void SetRole(string role)
        {
            Role = role;
        }

        public string GetGender()
        {
            return Gender;
        }

        public void SetGender(string gender)
        {
            Gender = gender;
        }

        public Hostel GetHostel()
        {
            return this.HostelName;
        }

        public void SetHostel(Hostel hostel)
        {
            this.HostelName = hostel;
        }

    }
}
