using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Student: Resident
    {

        private Room Room;
        private string StudentStatus;
        List<Complain> Complains = new List<Complain>();
        List<Fees> FeesList = new List<Fees>();
        public Student(string name, string password, int age, string cnic, string role, string gender) : base(name,password,age,cnic,role,gender)
        {
            this.StudentStatus = "Unalloted";
        }
        public Student(string name, string password, int age, string cnic, string role, string gender,Hostel hostel, Room room,string status) : base(name, password, age, cnic, role, gender,hostel)
        {
            this.Room = room;
            this.StudentStatus= status;

        }
        public Student(string name, string password, int age, string cnic, string role, string gender, Hostel hostel, Room room, string status, List<Complain> complains, List<Fees> feesList)
           : base(name, password, age, cnic, role, gender, hostel)
        {
            this.Room = room;
            this.StudentStatus = status;
            this.Complains = complains;
            this.FeesList = feesList;
        }

        public string GetStudentStatus() { return this.StudentStatus; }
        public void SetStudentStatus(string studentStatus) {  this.StudentStatus = studentStatus; }
        public Room GetRoom() {  return this.Room; }
        public void SetRoom(Room room) { this.Room = room; }
        public List<Complain> GetComplins()
        { return this.Complains; }
        public void SetComplains(List<Complain> complains)
        {
            this.Complains = complains;
        }
        public void AddComplains(Complain complain)
        {
            Complains.Add(new Complain(complain.GetDescription(),complain.GetDate()));
        }
        public void AddFees(Fees fees)
        {
            FeesList.Add(fees);
        }




    }
}
