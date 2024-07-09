using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface IRoom
    {
        bool InsertRoom(Room room, string hostelName, string connectionString);
        List<int> GetRoomNumbersByHostelName(string hostelName, string connectionString);
        List<Room> GetAvailableRooms(string connectionString);
        bool DeleteRoomByHostelName(string hostelName, string connectionString);
        Room GetRoomByRoomNumber(string roomNumber, string connectionString);
        bool DeleteRoomByRoomNumber(int roomNumber, string hostel, string connectionString);
        List<int> GetRoomNumbers(string connectionString);
        bool UpdateRoomStatusVacant(int roomno, string hostel, string connectionString);
        bool UpdateRoomStatusAlloted(int roomno, string hostel, string connectionString);
        bool IsDuplicateRoom(string hostelName, int roomNo, string connectionString);
    }
}
