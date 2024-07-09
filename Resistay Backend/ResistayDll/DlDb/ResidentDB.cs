using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;

namespace ResistayDll.DlDb
{
    public class ResidentDB: IResident
    {
        
        public  bool AddResidents(Resident resident, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("insert into Resident (Username, Password, Age,Gender,Cnic,Role) VALUES('{0}', '{1}', '{2}','{3}', '{4}', '{5}')", resident.GetName(), resident.GetPassword(), resident.GetAge(), resident.GetGender(), resident.GetCnic(), resident.GetRole());
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
        public  bool DeleteResidentByHostelName(string hostelName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int rowsAffected = 0;

            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = string.Format("DELETE FROM Resident WHERE HostelName = '{0}'", hostelName);
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowsAffected > 0;
        }
         
        public  Resident IsResidentFound(string name, string password, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("select * from Resident where Username = '{0}' and Password = '{1}' ", name, password);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            Resident resident;
            if (reader.Read())
            {
                string Username = Convert.ToString(reader["Username"]);
                string Password = Convert.ToString(reader["Password"]);
                string Gender = Convert.ToString(reader["Gender"]);
                int Age = Convert.ToInt32(reader["Age"]);
                string Cnic = Convert.ToString(reader["Cnic"]);
                string Role = Convert.ToString(reader["Role"]);

                resident = new Resident(Username, Password, Age, Cnic, Role, Gender);
                return resident;
            }
            else return null;
        }
        public  bool UpdateResidentPassword(string password, string name, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Resident SET Password = '{0}'  WHERE Username = '{1}'", password, name);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public  int GetResidentId(string username, string connectionString)
        {
            int residentId = -1; // Default value in case the resident ID is not found
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("select ResidentId from Resident where Username = '{0}'", username);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                residentId = Convert.ToInt32(reader["ResidentId"]);
            }

            reader.Close();
            connection.Close();

            return residentId;
        }
        public  void UpdateResidentHostelName(string username , string hostelname, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("UPDATE Resident SET HostelName = '{0}' WHERE Username = '{1}'", hostelname, username);
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public  bool DeleteResident(string residentName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("DELETE FROM Resident WHERE Username = '{0}'", residentName);

            int rowsAffected = 0;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;

        }
        
        public  string GetGenderOfSelectedPerson(string username, string connectionString)
        {
            string gender = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT Gender FROM Resident where Username = '{0}'", username);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                gender = reader.GetString(0);
            }
            reader.Close();
            connection.Close();
            return gender;



        }
    }
}
