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
    public class RulesDb:IRule
    {
        private string ConnectionString = "";
        public RulesDb(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public  bool AddRule(Rule rule)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("insert into Rules (Description, Date) VALUES('{0}', '{1}')", rule.GetDescription(), rule.GetDate());
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
        public bool DeleteRule(int ruleId )
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Rules WHERE rulesId = {0}", ruleId);
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
        public List<Rule> GetAllRules( )
        {
            List<Rule> rules = new List<Rule>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Rules ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string description = reader["description"].ToString();
                    string date = reader["date"].ToString();
                    Rule rule = new Rule(description, date);
                    rules.Add(rule);
                }

                reader.Close();
            }

            return rules;
        }
        public List<int> GetRuleIds()
        {
            List<int> ruleIds = new List<int>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "SELECT RulesId FROM Rules";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ruleId = Convert.ToInt32(reader["RulesId"]);
                ruleIds.Add(ruleId);
            }

            reader.Close();
            connection.Close();

            return ruleIds;
        }
    }
}

