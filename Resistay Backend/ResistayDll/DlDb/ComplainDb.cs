using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;

namespace ResistayDll.DlDb 
{
    public class ComplainDb: IComplain
    {

        public  bool AddComplain( Complain complain,string username, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("insert into Complain (Detail,Date,StudentName) VALUES('{0}','{1}','{2}' )", complain.GetDescription(), complain.GetDate(),username);
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
        public  bool DeleteComplain(int complainId, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Complain WHERE ComplainId = {0}", complainId);
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
        public  List<Complain> GetAllComplainsofStudent(string studentname, string connectionString)
        {
            List<Complain> complains = new List<Complain>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM Complain where StudentName = '{0}'",studentname);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string description = reader["Detail"].ToString();
                    string date = reader["date"].ToString(); 
                    Complain complain = new Complain(description, date);
                    complains.Add(complain);
                }

                reader.Close();
            }

            return complains;
        }

        public  List<int> GetComplainId(string studentName,string connectionString)
        {
            List<int> complainIds = new List<int>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT ComplainId FROM Complain where StudentName= '{0}'",studentName);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int complainId = Convert.ToInt32(reader["ComplainId"]);
                 complainIds.Add(complainId);
            }

            reader.Close();
            connection.Close();

            return complainIds;
        }
        public  bool DeleteComplainbyStudentName(string studentName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Complain WHERE StudentName = '{0}'", studentName);
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
    
    }
}
