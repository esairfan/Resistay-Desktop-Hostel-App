using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Warden : Resident
    {
        public Warden(string name, string password, int age, string cnic, string role, string gender) : base(name, password, age, cnic, role, gender)
        {

        }
    }
}
