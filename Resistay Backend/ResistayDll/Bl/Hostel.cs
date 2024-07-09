using System;
using System.Collections.Generic;

namespace ResistayDLL.Bl
{
    public class Hostel
    {
        private string HostelName;
        private string HostelType;
        private string HostelStatus;
        private List<Room> RoomsList = new List<Room>();
        private List<Student> StudentsList = new List<Student>();
        private RT Rt = new RT();

        public Hostel()
        {

        }

        public Hostel(string hostelName, string hostelType)
        {
            HostelName = hostelName;
            HostelType = hostelType;
            HostelStatus = "Unchecked";
        }

        public Hostel(string hostelName, string hostelType, string hostelStatus)
        {
            HostelName = hostelName;
            HostelType = hostelType;
            HostelStatus = hostelStatus;
        }

        public Hostel(string hostelName, string hostelType, string hostelStatus, List<Room> roomsList)
        {
            HostelName = hostelName;
            HostelType = hostelType;
            HostelStatus = "Unchecked";
            RoomsList = roomsList;
        }

        public Hostel(string hostelName, string hostelType, string hostelStatus, List<Room> roomsList, RT rt)
        {
            HostelName = hostelName;
            HostelType = hostelType;
            HostelStatus = hostelStatus;
            RoomsList = roomsList;
            Rt = rt;
        }

        public string GetHostelName()
        {
            return HostelName;
        }

        public void SetHostelName(string hostelName)
        {
            HostelName = hostelName;
        }

        public string GetHostelType()
        {
            return HostelType;
        }

        public void SetHostelType(string hostelType)
        {
            HostelType = hostelType;
        }

        public string GetHostelStatus()
        {
            return HostelStatus;
        }

        public void SetHostelStatus(string hostelStatus)
        {
            HostelStatus = hostelStatus;
        }

        public List<Room> GetRoomsList()
        {
            return RoomsList;
        }

        public void SetRoomsList(List<Room> roomsList)
        {
            RoomsList = roomsList;
        }

        public List<Student> GetStudentsList()
        {
            return StudentsList;
        }

        public void SetStudentsList(List<Student> studentsList)
        {
            StudentsList = studentsList;
        }

        public RT GetRt()
        {
            return Rt;
        }

        public void SetRt(RT rt)
        {
            Rt = rt;
        }
        public void AddRooms(int room)
        {
            RoomsList.Add(new Room(room));
        }
        public void AddStudents(Student student)
        {
            StudentsList.Add(new Student(student.GetName(), student.GetPassword(), student.GetAge(), student.GetCnic(), student.GetRole(), student.GetGender(), student.GetHostel(), student.GetRoom(), student.GetStudentStatus()));
        }
    }
}
