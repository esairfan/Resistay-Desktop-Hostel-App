using ResistayDLL.Bl;
using ResistayDll.DlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResistayDLL.Utilities;
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class Rooms : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        IComplain ComplainDb = new ComplainDb();
        Ihostel HostelDb = new HostelDb();
        IRoom RoomDb = new RoomDb();
        IStudent StudentDb = new StudentDb();
        IFees FeesDb = new FeesDb();
         IResident ResidentDB = new ResidentDB();
        public Rooms()
        {
            InitializeComponent();
            LoadRooms();
        }
        private void LoadRooms()

        {
            List<Room> availableRooms = RoomDb.GetAvailableRooms(ConnectionString);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("RoomNumber", typeof(int));
            dataTable.Columns.Add("RoomStatus", typeof(string));
            dataTable.Columns.Add("HostelName", typeof(string));

            foreach (Room room in availableRooms)
            {
                dataTable.Rows.Add(room.GetNumber(), room.GetRoomStatus(), room.GetHostel().GetHostelName());
            }

            RoomGrid.DataSource = dataTable;

            List<string> availableHostels = HostelDb.GetHostelNames(ConnectionString);
            HostelName.DataSource = availableHostels;

            List<int> Roomlist = RoomDb.GetRoomNumbers(ConnectionString).Distinct().ToList();

            dltroom.DataSource = Roomlist;






        }
        private void AddHostel_Click(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide(); 
        }

        private void RoomGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveHostelBtn_Click(object sender, EventArgs e)
        {
            List<string> studentNames = StudentDb.GetStudentNamesByHostelName(HostelByroom.Text, ConnectionString);

            
            foreach (string studentName in studentNames)
            {
                ComplainDb.DeleteComplainbyStudentName(studentName, ConnectionString);
                FeesDb.DeleteFeebyStudentName(studentName, ConnectionString);
                ResidentDB.DeleteResident(studentName, ConnectionString);
            }
            RoomDb.DeleteRoomByRoomNumber(int.Parse(dltroom.Text), HostelByroom.Text, ConnectionString);
            StudentDb.DeleteStudentByRoomNumber(int.Parse(dltroom.Text), ConnectionString);
            
            MessageBox.Show("Deleted Succeessfully");
            LoadRooms();
        }

        private void HostelsDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void dltroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dltroom.Text))
            {
                
                if (int.TryParse(dltroom.Text, out int roomNumber))
                {
                    List<string> availableHostel = HostelDb.GetHostelBySelecteddltRoom(roomNumber, ConnectionString);
                    HostelByroom.DataSource = availableHostel;
                }
                else
                {
                    
                    MessageBox.Show("Invalid room number input.");
                }

            }
            else
            {
                HostelName.DataSource = null;
            }
        }

            private void removebtn_Click(object sender, EventArgs e)
        {

            RoomDb.DeleteRoomByRoomNumber(int.Parse(dltroom.Text), HostelByroom.Text, ConnectionString);
            StudentDb.DeleteStudentByRoomNumber(int.Parse(dltroom.Text), ConnectionString);
            MessageBox.Show("Deleted Succeessfully");
            LoadRooms();
        }

        private void HostelName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomAddbtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(RoomNumber.Text) && Validation.IsValidRoom(RoomNumber.Text) && RoomDb.IsDuplicateRoom(HostelName.Text, int.Parse(RoomNumber.Text), ConnectionString))
            {

                Hostel hostel = new Hostel();
                hostel = HostelDb.GetHostelByName(HostelName.Text, ConnectionString);
                hostel.AddRooms(int.Parse(RoomNumber.Text));
                Room room = new Room(int.Parse(RoomNumber.Text));
                RoomDb.InsertRoom(room, HostelName.Text, ConnectionString);
                MessageBox.Show("Added Successfully");

            }
            else
            {
                MessageBox.Show("Invalid Room Input or Duplicate Roomnumber");
            }
            LoadRooms();
        }

        private void Hostellabel_Click(object sender, EventArgs e)
        {

        }

        private void RoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void HostelByroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }
    }
}
