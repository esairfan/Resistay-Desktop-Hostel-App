using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Room
    {
        private int Number;
        private string  RoomStatus;
        Hostel Hostel;

        public Room()
        {
        }

        public Room(int number)
        {
            this.Number = number;
            this.RoomStatus = "Vacant";
        }
        public Room (int number, string roomStatus)
        {
            this.Number = number;
            this.RoomStatus = roomStatus;
        }
        public Room(int number, string roomStatus, Hostel hostel)
        {
            this.Number = number;
            this.RoomStatus = roomStatus;
            this.Hostel = hostel;
        }
        public int GetNumber()  {  return Number; }

        public void SetNumber(int number){ this.Number = number;}

        public string GetRoomStatus()  { return RoomStatus;}

        public void SetRoomStatus(string roomStatus) { this.RoomStatus = roomStatus; }
        public void SetHostel(Hostel hostel) { this.Hostel = hostel;}   
        public Hostel GetHostel() { return this.Hostel; }


    }
}
