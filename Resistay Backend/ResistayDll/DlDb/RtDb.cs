using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;

using ResistayDll.DLInterfaces;

namespace ResistayDll.DlDb
{
    public class RtDb:IRt
    {
        Ihostel HostelDb = new HostelDb();

        public bool DeleteRtByHostelName(string hostelName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int rowsAffected = 0;

            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = string.Format("DELETE FROM Rt WHERE HostelName = '{0}'", hostelName);
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowsAffected > 0;
        }

        public  bool InsertRt(RT resident ,int residentId,string connectionString)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("insert into Rt (Username, Password, Age,Gender,Cnic,Role,PhoneNo,ResidentId,HostelName) VALUES('{0}', '{1}', '{2}','{3}', '{4}', '{5}','{6}','{7}','{8}')", resident.GetName(), resident.GetPassword(), resident.GetAge(), resident.GetGender(), resident.GetCnic(), resident.GetRole(),resident.GetPhoneNumber(), residentId,resident.GetHostel().GetHostelName());
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
         
        public  bool DeleteRt(string rtName,string  connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("DELETE FROM Rt WHERE Username = '{0}'",rtName);

            int rowsAffected = 0;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;

        }

        public  string GetHostelOfSelectedRt(string username, string connectionString)
        {
            string hostel = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT HostelName FROM Rt where HostelName = '{0}'", username);
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
        public  bool IsDuplicateRt(string username, string connectionString)
        {
            string resident = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT Username FROM Rt WHERE Username = '{0}'", username);
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
        public  bool UpdateRtPassword(string password, string name, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Rt SET Password = '{0}'  WHERE Username = '{1}'", password, name);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  RT GetRtByName(string name, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("select * from Rt where Username = '{0}' ", name);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            RT rt;
            if (reader.Read())
            {
                string Username = Convert.ToString(reader["Username"]);
                string Password = Convert.ToString(reader["Password"]);
                string Gender = Convert.ToString(reader["Gender"]);
                int Age = Convert.ToInt32(reader["Age"]);
                string Cnic = Convert.ToString(reader["Cnic"]);
                string hostelName = Convert.ToString(reader["HostelName"]);
                 
                string phoneNo = Convert.ToString(reader["PhoneNo"]);
                string Role = Convert.ToString(reader["Role"]);

                rt = new RT(Username, Password, Age, Cnic, Role, Gender, HostelDb.GetHostelByName(hostelName, connectionString),phoneNo);
                return rt;
            }
            else return null;
        }
        public  List<RT> GeAllRts (string connectionString)
        {
            List<RT> Rts = new List<RT>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Rt";
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
                string phoneNumber = Convert.ToString(reader["PhoneNo"]);


                RT rt = new RT(username, password, age, cnic, role, gender, HostelDb.GetHostelByName(hostelName, connectionString), phoneNumber);
                Rts.Add(rt);
            }

            reader.Close();
            connection.Close();

            return Rts;
        }
        public List<string> GeAllRtNames(string connectionString)
        {
            List<string> Rts = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Rt";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]); 


                 Rts.Add(username);
            }

            reader.Close();
            connection.Close();

            return Rts;
        }
        public List<string> GeAllRtNamesbyHostel(string hostel, string connectionString)
        {
            List<string> Rts = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("SELECT * FROM Rt where HostelName = '{0}'",hostel);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);


                Rts.Add(username);
            }

            reader.Close();
            connection.Close();

            return Rts;
        }

    }
}
