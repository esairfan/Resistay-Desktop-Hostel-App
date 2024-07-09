using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Resistay.UI
{
    public partial class RemoveRtandStudent : Form
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
        public RemoveRtandStudent()
        {
            InitializeComponent();
            LoadData();
            
        }
        private void LoadData()
        {
            List<string> Students = StudentDb.GetNameOfAllotedStudents(ConnectionString);
            StudentName.DataSource = Students;

            List<string> Rts = RtDb.GeAllRtNames(ConnectionString);
            dltrt.DataSource = Rts;

        }
        private void RemoveRtandStudent_Load(object sender, EventArgs e)
        {

        }

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            Hide(); 
        }

        private void dltrt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
           int roomNo = StudentDb.GetRoomNoOfSelectedStudent(StudentName.Text, ConnectionString);
           string hostel = StudentDb.GetHostelOfSelectedStudent(StudentName.Text, ConnectionString);

            ComplainDb.DeleteComplainbyStudentName(StudentName.Text, ConnectionString);
            FeesDb.DeleteFeebyStudentName(StudentName.Text, ConnectionString);
            StudentDb.DeleteStudent(StudentName.Text, ConnectionString);
           ResidentDB.DeleteResident(StudentName.Text, ConnectionString);
            if (RoomDb.UpdateRoomStatusVacant(roomNo,hostel, ConnectionString))
            {
                MessageBox.Show("Room status updated to Vacant.");
            }
            else
            {
                MessageBox.Show("Failed to update room status to Vacant.");
            }
            MessageBox.Show("Deleted Successfully");
            LoadData();
        }

        private void RemoveRtBtn_Click(object sender, EventArgs e)
        {
            string hostelName = RtDb.GetHostelOfSelectedRt(dltrt.Text,ConnectionString) ;
            RtDb.DeleteRt(dltrt.Text, ConnectionString);
            ResidentDB.DeleteResident(dltrt.Text, ConnectionString);
            SalaryDb.DeleteChecksbyRtName(dltrt.Text, ConnectionString);
            HostelDb.UpdateHostelStatusUnchecked(hostelName, ConnectionString);
            LoadData();
            MessageBox.Show("Deleted Successfully");

        }
    }
}
