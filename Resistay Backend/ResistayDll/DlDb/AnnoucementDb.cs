
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
    public class AnnoucementDb: IAnnoucement
    {
        private string ConnectionString = "";
        public AnnoucementDb(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public  bool AddAnnoucement(Annoucement annoucement)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("insert into Annoucement (Details,Date) VALUES('{0}','{1}' )", annoucement.GetDescription(),annoucement.GetDate());
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
        public  bool DeleteAnnoucement(int announcementId )
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Annoucement WHERE AnnoucemntId = {0}", announcementId);
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
        public  List<Annoucement> GetAllAnnouncements( )
        {
            List<Annoucement> announcements = new List<Annoucement>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            
                connection.Open();
                string query = "SELECT * FROM Annoucement";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string description = reader["Details"].ToString();
                    string date = reader["date"].ToString();
                int id = Convert.ToInt32(reader["AnnoucemntId"]);
                Annoucement announcement = new Annoucement(description,date,id);
                    announcements.Add(announcement);
                }

                reader.Close();
            

            return announcements;
        }
        public  List<int> GetAnnoucementId( )
        {
            List<int> announcementIds = new List<int>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "SELECT AnnoucemntId FROM Annoucement";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int announcementId = Convert.ToInt32(reader["AnnoucemntId"]);
                announcementIds.Add(announcementId);
            }

            reader.Close();
            connection.Close();

            return announcementIds;
        }



    }
}
