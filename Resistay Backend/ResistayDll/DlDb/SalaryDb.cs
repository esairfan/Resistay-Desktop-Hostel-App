using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;
using System.Data.SqlClient;


namespace ResistayDll.DlDb 
{
    public class SalaryDb :ISalary
    {
        public List<Salary> GetAllRecievedChecks(string rtName, string connectionString)
        {
            List<Salary> Checklist = new List<Salary>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM Salary WHERE RtName = '{0}' AND RecievedDate IS NOT NULL", rtName);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int salaryAmount = Convert.ToInt32(reader["CheckAmount"]);
                    string issuedate = reader["IssueDate"].ToString();
                    string checkNumber = reader["CheckNumber"].ToString();
                    string recieveddate = reader["RecievedDate"].ToString();
                    Salary salary = new Salary(salaryAmount, checkNumber, issuedate, recieveddate);
                    Checklist.Add(salary);
                }

                reader.Close();
            }

            return Checklist;
        }
        public bool UpdateSalaryandDate( string recieveddate, string rtname, string checknumber, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("UPDATE Salary SET RecievedDate = '{0}' WHERE RtName = '{1}' and CheckNumber = '{2}'",recieveddate, rtname, checknumber);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

        public bool InsertSalary(Salary salary, string rtname, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("insert into Salary (CheckAmount,IssueDate,CheckNumber,RtName) VALUES('{0}','{1}','{2}','{3}' )", salary.GetCheckAmunt(), salary.GetIssueDate(), salary.GetCheckNumber(), rtname);
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
        public List<string> GetCheckNumber(string rtname, string connectionString)
        {
            List<string> Checklists = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT CheckNumber FROM Salary where RtName = '{0}' and CheckAmount > '0' and RecievedDate is Null", rtname);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string checkNo = reader["CheckNumber"].ToString();


                    Checklists.Add(checkNo);
                }

                reader.Close();
            }

            return Checklists;
        }

        public bool DeleteChecksbyRtName(string rtName, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Salary WHERE RtName = '{0}'", rtName);
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

        public Salary GetAmountByChallans(string checkNumber, string connectionString)
        {
            Salary salary = new Salary();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM Salary where CheckNumber = '{0}'", checkNumber);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int salaryamount = Convert.ToInt32(reader["CheckAmount"]);
                    string issuedate = reader["IssueDate"].ToString();
                    string checkNo = reader["CheckNumber"].ToString();
                    string recievedDate = reader["RecievedDate"].ToString();
                    salary = new Salary(salaryamount, checkNo, issuedate, recievedDate);

                }

                reader.Close();
            }

            return salary;
        }


    }
}
