using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ResistayDll.DLInterfaces;

namespace ResistayDll.DlDb
{
    public class StudentDb:IStudent
    {
        IComplain ComplainDb = new ComplainDb();
        Ihostel HostelDb = new HostelDb();
        IRoom RoomDb = new RoomDb();
        IFees FeesDb = new FeesDb();


        public bool AddStudent(Student resident,int ResidentId ,string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("insert into Student (Username, Password, Age,Gender,Cnic,Role,ResidentId,StudentStatus) VALUES('{0}', '{1}', '{2}','{3}', '{4}', '{5}','{6}','{7}')", resident.GetName(), resident.GetPassword(), resident.GetAge(), resident.GetGender(), resident.GetCnic(), resident.GetRole(),ResidentId,resident.GetStudentStatus());
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool DeleteStudentByHostelName(string hostelName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int rowsAffected = 0;

            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = string.Format("DELETE FROM Student WHERE HostelName = '{0}'", hostelName);
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowsAffected > 0;
        }
        public  List<String> GetNameOfUnallotedStudents(string connectionString)
        {
            List<String> UnallotedStudents = new List<String>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT Username FROM Student where StudentStatus = 'Unalloted'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                UnallotedStudents.Add(username);
            }

            reader.Close();
            connection.Close();

            return UnallotedStudents;

        }
        public List<String> GetNameOfAllotedStudents(string connectionString)
        {
            List<String> allotedStudents = new List<String>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT Username FROM Student where StudentStatus = 'Alloted'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                allotedStudents.Add(username);
            }

            reader.Close();
            connection.Close();

            return allotedStudents;

        }
        public string GetHostelOfSelectedStudent(string username, string connectionString)
        {
            string hostel = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT HostelName FROM Student where Username = '{0}'", username);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                hostel = reader.GetString(0);
            }
            reader.Close();
            connection.Close();
            return hostel;



        }
        public  bool IsDuplicateStudent(string username, string connectionString)
        {
            string resident = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT Username FROM Student WHERE Username = '{0}'", username);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                resident = reader.GetString(0);
            }
            reader.Close();
            connection.Close();

            return resident == null;
        }
        public Student GetStudentByName(string name, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("select * from Student where Username = '{0}' ", name );
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            Student student;
            if (reader.Read())
            {
                string Username = Convert.ToString(reader["Username"]);
                string Password = Convert.ToString(reader["Password"]);
                string Gender = Convert.ToString(reader["Gender"]);
                int Age = Convert.ToInt32(reader["Age"]);
                string Cnic = Convert.ToString(reader["Cnic"]);
                string hostelName = Convert.ToString(reader["HostelName"]);
                string roomNumber = Convert.ToString(reader["RoomNumber"]);
                string studentStatus = Convert.ToString(reader["StudentStatus"]);
                string Role = Convert.ToString(reader["Role"]);

                student = new Student(Username, Password, Age, Cnic, Role, Gender,HostelDb.GetHostelByName(hostelName,connectionString),RoomDb.GetRoomByRoomNumber(roomNumber,connectionString),studentStatus,ComplainDb.GetAllComplainsofStudent(Username,connectionString),FeesDb.GetAllTranscationHistoryofStudent(Username,connectionString));
                return student;
            }
            else return null;
        }
        public  int GetRoomNoOfSelectedStudent(string studentName, string connectionString)
        {
            int roomNumber = -1;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT RoomNumber FROM Student where Username = '{0}'", studentName);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                roomNumber = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return roomNumber;



        }
        public  bool DeleteStudentByRoomNumber(int roomNumber, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "DELETE FROM Student WHERE RoomNumber = '" + roomNumber + "'";

            int rowsAffected = 0;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  bool UpdateStudentStatus(string username, int roomno, string hostelname, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Student SET StudentStatus = 'Alloted', RoomNumber = '{0}', HostelName = '{1}' WHERE Username = '{2}'", roomno, hostelname, username);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  bool UpdateStudentPassword(string password ,string name, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Student SET Password = '{0}'  WHERE Username = '{1}'", password,  name );
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  List<Student> GetStudentsWithAllotedStatus(string connectionString)
        {
            List<Student> allotedStudents = new List<Student>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Student WHERE StudentStatus = 'alloted'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                string password = Convert.ToString(reader["Password"]);
                int age = Convert.ToInt32(reader["Age"]);
                string gender = Convert.ToString(reader["Gender"]);
                string cnic = Convert.ToString(reader["Cnic"]);
                string role = Convert.ToString(reader["Role"]);
                string hostelName = Convert.ToString(reader["HostelName"]);
                string roomNumber = Convert.ToString(reader["RoomNumber"]);
                string studentStatus = Convert.ToString(reader["StudentStatus"]);

                Student student = new Student(username, password, age, cnic, role, gender,HostelDb.GetHostelByName( hostelName,connectionString), RoomDb.GetRoomByRoomNumber(roomNumber,connectionString), studentStatus);
                allotedStudents.Add(student);
            }

            reader.Close();
            connection.Close();

            return allotedStudents;
        }
        public  List<Student> GetStudentsByHostelName(string hostelName,string connectionString)
        {
            List<Student> allotedStudents = new List<Student>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("SELECT * FROM Student WHERE HostelName = '{0}'",hostelName);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                string password = Convert.ToString(reader["Password"]);
                int age = Convert.ToInt32(reader["Age"]);
                string gender = Convert.ToString(reader["Gender"]);
                string cnic = Convert.ToString(reader["Cnic"]);
                string role = Convert.ToString(reader["Role"]);
                string hostelname = Convert.ToString(reader["HostelName"]);
                string roomNumber = Convert.ToString(reader["RoomNumber"]);
                string studentStatus = Convert.ToString(reader["StudentStatus"]);

                Student student = new Student(username, password, age, cnic, role, gender, HostelDb.GetHostelByName(hostelName, connectionString), RoomDb.GetRoomByRoomNumber(roomNumber, connectionString), studentStatus);
                allotedStudents.Add(student);
            }

            reader.Close();
            connection.Close();

            return allotedStudents;
        }

        public List<Student> GetAllStudents(string connectionString)
        {
            List<Student> allotedStudents = new List<Student>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                string password = Convert.ToString(reader["Password"]);
                int age = Convert.ToInt32(reader["Age"]);
                string gender = Convert.ToString(reader["Gender"]);
                string cnic = Convert.ToString(reader["Cnic"]);
                string role = Convert.ToString(reader["Role"]);
                string hostelName = Convert.ToString(reader["HostelName"]);
                string roomNumber = Convert.ToString(reader["RoomNumber"]);
                string studentStatus = Convert.ToString(reader["StudentStatus"]);

                Student student = new Student(username, password, age, cnic, role, gender, HostelDb.GetHostelByName(hostelName, connectionString), RoomDb.GetRoomByRoomNumber(roomNumber, connectionString), studentStatus);
                allotedStudents.Add(student);
            }

            reader.Close();
            connection.Close();

            return allotedStudents;
        }

        public  bool DeleteStudent(string studentName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("DELETE FROM Student WHERE Username = '{0}'", studentName);

            int rowsAffected = 0;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;

        }
        public  List<string> GeAllStudentNames(string connectionString)
        {
            List<string> Students = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);


                Students.Add(username);
            }

            reader.Close();
            connection.Close();

            return Students;
        }
         

        public  List<string> GetStudentNamesByHostelName(string hostelName, string connectionString)
        {
            List<string> studentNames = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT Username FROM Student where Hostelname = '{0}'", hostelName);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                studentNames.Add(name);
            }

            reader.Close();
            connection.Close();

            return studentNames;
        }



    }
}
