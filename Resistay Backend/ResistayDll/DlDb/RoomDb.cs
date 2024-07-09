using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using ResistayDll.DLInterfaces;

namespace ResistayDll.DlDb
{
    public class RoomDb:IRoom
    {
        Ihostel HostelDb = new HostelDb();
        public  bool InsertRoom(Room room, string hostelName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("INSERT INTO Room (RoomNumber, HostelName, RoomStatus) VALUES ('{0}', '{1}', '{2}')",
                                          room.GetNumber(), hostelName, room.GetRoomStatus());

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = 0;

            connection.Open();
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

        public  List<int> GetRoomNumbersByHostelName(string hostelName, string connectionString)
        {
            List<int> roomNumbers = new List<int>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format( "SELECT RoomNumber FROM Room WHERE HostelName = '{0}'and RoomStatus ='Vacant'",hostelName);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HostelName", hostelName);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                roomNumbers.Add(roomNumber);
            }

            reader.Close();
            connection.Close();

            return roomNumbers;
        }

       
        public  List<Room> GetAvailableRooms(string connectionString)
        {
            List<Room> availableRooms = new List<Room>();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Room WHERE RoomStatus = 'Vacant'";

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                 
                string roomStatus = Convert.ToString(reader["RoomStatus"]);
                string HostelName = Convert.ToString(reader["HostelName"]);

                Room room = new Room(roomNumber, roomStatus,HostelDb.GetHostelByName(HostelName,connectionString));
                availableRooms.Add(room);
            }

            reader.Close();
            connection.Close();
           
            return availableRooms;
        }

        public  bool DeleteRoomByHostelName(string hostelName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int rowsAffected = 0;

            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = string.Format("DELETE FROM Room WHERE HostelName = '{0}'", hostelName);
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowsAffected > 0;
        }
        public  Room GetRoomByRoomNumber(string roomNumber, string connectionString)
        {
            Room room = null;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("SELECT * FROM Room WHERE RoomNumber = '{0}'", roomNumber);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int number = Convert.ToInt32(reader["RoomNumber"]);
                string status = Convert.ToString(reader["RoomStatus"]);
                

                room = new Room(number, status);
            }

            reader.Close();
            connection.Close();

            return room;
        }

        public  bool DeleteRoomByRoomNumber(int roomNumber,string hostel, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("DELETE FROM Room WHERE RoomNumber = '{0}' AND HostelName = '{1}'",roomNumber,hostel);

            int rowsAffected = 0;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  List<int> GetRoomNumbers(string connectionString)
        {
            List<int> roomNumbers = new List<int>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT RoomNumber FROM Room";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int roomNumber = reader.GetInt32(0); 
                roomNumbers.Add(roomNumber);
            }

            reader.Close();
            connection.Close();

            roomNumbers.Distinct().ToList();
            return roomNumbers;
        }

        public  bool UpdateRoomStatusVacant(int roomno, string hostel,string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Room SET RoomStatus = 'Vacant' WHERE RoomNumber = '{0}'and HostelName = '{1}'", roomno,hostel );
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  bool UpdateRoomStatusAlloted(int roomno, string hostel, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Room SET RoomStatus = 'Alloted' WHERE RoomNumber = '{0}'and HostelName = '{1}'", roomno,hostel);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public bool IsDuplicateRoom(string hostelName, int roomNo, string connectionString)
        {
            int foundRoomNo = -1; 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT RoomNumber FROM Room WHERE HostelName = '{0}' AND RoomNumber = '{1}'", hostelName, roomNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                foundRoomNo = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();

            
            return foundRoomNo == -1;
        }

    }
}
