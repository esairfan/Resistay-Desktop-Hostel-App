using ResistayDll.DlDb;
using ResistayDLL.Utilities;
using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class HostelManage : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        IComplain ComplainDb = new ComplainDb();
        Ihostel HostelDb = new HostelDb();
        IRoom RoomDb = new RoomDb();
        IStudent StudentDb = new StudentDb();
        IResident ResidentDB = new ResidentDB();
        IRt RtDb = new RtDb();
        IFees FeesDb = new FeesDb();
        ISalary SalaryDb = new SalaryDb();
        public HostelManage()
        {
            InitializeComponent();
            LoadHostels();
        }

        private void LoadHostels()
        {
            List<Hostel> hostels = HostelDb.GetAllHostels(ConnectionString);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("HostelName", typeof(string));
            dataTable.Columns.Add("HostelType", typeof(string));
            dataTable.Columns.Add("HostelStatus", typeof(string));

            foreach (Hostel hostel in hostels)
            {
                dataTable.Rows.Add(hostel.GetHostelName(), hostel.GetHostelType(), hostel.GetHostelStatus());
            }

            HostelGrid.DataSource = dataTable;

            List<string> Hostels = HostelDb.GetHostelNames(ConnectionString);
            dltHostel.DataSource = Hostels;

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void HostelName_TextChanged(object sender, EventArgs e)
        {
            
        }

 

        private void HostelManage_Load(object sender, EventArgs e)
        {
            
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HostelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HostelNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HostelTypeLabel_Click(object sender, EventArgs e)
        {

        }

         

        private void HostelsDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void RemoveHostelBtn_Click(object sender, EventArgs e)
        {
            string selectedHostelName = dltHostel.Text;

         
            List<string> studentNames = StudentDb.GetStudentNamesByHostelName(selectedHostelName, ConnectionString);
            foreach (string studentName in studentNames)
            {
                ComplainDb.DeleteComplainbyStudentName(studentName, ConnectionString);
                FeesDb.DeleteFeebyStudentName(studentName, ConnectionString);
            }
            List<string> rtNames = RtDb.GeAllRtNamesbyHostel(selectedHostelName, ConnectionString);
            foreach (string rtName in rtNames)
            { 
                SalaryDb.DeleteChecksbyRtName(rtName, ConnectionString);    

            }

            HostelDb.DeleteHostelByHostelName(selectedHostelName, ConnectionString);
            RoomDb.DeleteRoomByHostelName(selectedHostelName, ConnectionString);
            RtDb.DeleteRtByHostelName(selectedHostelName, ConnectionString);
            StudentDb.DeleteStudentByHostelName(selectedHostelName, ConnectionString);
            ResidentDB.DeleteResidentByHostelName(selectedHostelName, ConnectionString);

            MessageBox.Show("Deleted Successfully");
            LoadHostels();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddHostel_Click(object sender, EventArgs e)
        {

        }

        private void HostelAddbtn_Click(object sender, EventArgs e)
        {
            if(Validation.IsEmptyInput(HostelName.Text)&& HostelDb.IsDuplicateHostel(HostelName.Text,ConnectionString))
            {
                Hostel hostel = new Hostel(HostelName.Text,HostelType.Text);
                HostelDb.InsertHostel(hostel, ConnectionString);
                MessageBox.Show("Added Succeessfully");
                LoadHostels();
            }
            else 
            {
                MessageBox.Show("Invalid Input or Duplicate Hostel name");
            }
        }

        private void HostelGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dltHostel_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
    }
}
