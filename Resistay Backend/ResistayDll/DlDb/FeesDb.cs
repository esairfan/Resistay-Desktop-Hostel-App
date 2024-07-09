using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;
using ResistayDLL.Utilities;
using System.Data.SqlClient;

namespace ResistayDll.DlDb
{
    public class FeesDb : IFees
    {

        public List<Fees> GetAllTranscationHistoryofStudent(string studentname, string connectionString)
        {
            List<Fees> FeesHistory = new List<Fees>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM Fees WHERE StudentName = '{0}' AND PaymentDate IS NOT NULL", studentname);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int fees = Convert.ToInt32(reader["StudentFees"]);
                    string duedate = reader["DueDate"].ToString(); 
                    string challanNo = reader["ChallanNo"].ToString();
                    string paiddate = reader["PaymentDate"].ToString();
                    Fees fee = new Fees(fees, duedate,challanNo,paiddate);
                    FeesHistory.Add(fee);
                }

                reader.Close();
            }

            return FeesHistory;
        }
        public List<string> GetFeesChallanNumberofStudent(string studentname, string connectionString)
        {
            List<string> StudentChallans = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT ChallanNo FROM Fees where StudentName = '{0}' and StudentFees > '0'", studentname);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                { 
                    string challanNo = reader["ChallanNo"].ToString();
      
                     
                    StudentChallans.Add(challanNo);
                }

                reader.Close();
            }

            return StudentChallans;
        }
        public Fees GetFeesByChallans(string challan, string connectionString)
        {
            Fees fee = new Fees();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM Fees where ChallanNo = '{0}'", challan);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int fees = Convert.ToInt32(reader["StudentFees"]);
                    string duedate = reader["DueDate"].ToString();
                    string challanNo = reader["ChallanNo"].ToString();
                    string paiddate = reader["PaymentDate"].ToString();
                    fee = new Fees(fees, duedate, challanNo, paiddate);
                     
                }

                reader.Close();
            }

            return fee;
        }
        public bool UpdateFeesandDate(int fees,string paiddate,string studentname,string challanNo, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Fees SET StudentFees = '{0}',PaymentDate = '{1}' WHERE StudentName = '{2}' and ChallanNo = '{3}'" ,fees,paiddate,studentname,challanNo );
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
        public bool InsertFees(Fees fee, string username, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("insert into Fees (StudentFees,DueDate,ChallanNo,StudentName) VALUES('{0}','{1}','{2}','{3}' )", fee.GetFeeAmount(), fee.GetDueDate(),fee.GetChallanNumber(), username);
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

        public bool DeleteFeebyStudentName(string studentName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Fees WHERE StudentName = '{0}'", studentName);
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
        public bool IsDuplicateChallanNumber(string challanNumber, string connectionString)
        {
            string challanNo = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("SELECT ChallanNo FROM Fees WHERE ChallanNo = '{0}'", challanNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                challanNo = reader.GetString(0);
            }
            reader.Close();
            connection.Close();

            return challanNo == null;
        }
    }
}
