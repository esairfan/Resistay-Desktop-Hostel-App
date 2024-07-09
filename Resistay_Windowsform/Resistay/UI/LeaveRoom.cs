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
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class LeaveRoom : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        public event EventHandler LeaveConfirmed;

        IComplain ComplainDb = new ComplainDb();
        ISalary SalaryDb = new SalaryDb();
        IFees FeesDb = new FeesDb();
        IRoom RoomDb = new RoomDb();
        IStudent StudentDb = new StudentDb();
        IResident ResidentDB = new ResidentDB();
        IRt RtDb = new RtDb();
      private string Name;
       private StudentMenu studentMenu;
        private RtMenu RtMenu;
        public LeaveRoom()
        {
            InitializeComponent();
        }
        public LeaveRoom(string name,StudentMenu studentMenu) : this() 
        {
            this.Name = name;
            this.studentMenu = studentMenu;
           
            
        }
        public LeaveRoom(string name, RtMenu rtMenu) : this()
        {
            this.Name = name;
            this.RtMenu = rtMenu;


        }

        private void leaveRoomBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void leaveRoomBtn2_Click(object sender, EventArgs e)
        {
            int roomNo = StudentDb.GetRoomNoOfSelectedStudent(Name, ConnectionString);
            string hostel = StudentDb.GetHostelOfSelectedStudent(Name, ConnectionString);
            ComplainDb.DeleteComplainbyStudentName(Name, ConnectionString);
            StudentDb.DeleteStudent( Name, ConnectionString);
            ResidentDB.DeleteResident(Name, ConnectionString);
            RtDb.DeleteRt( Name, ConnectionString);
            RoomDb.UpdateRoomStatusVacant(roomNo, hostel, ConnectionString);
            FeesDb.DeleteFeebyStudentName(Name, ConnectionString);
            SalaryDb.DeleteChecksbyRtName(Name, ConnectionString);
            
                MessageBox.Show("You left room.");
            Hide();
            OnLeaveConfirmed(EventArgs.Empty);
            MainPage mainpage = new MainPage();
            mainpage.Show();





        }
        protected virtual void OnLeaveConfirmed(EventArgs e)
        {
            LeaveConfirmed?.Invoke(this, e);
        }
        private void LeaveRoom_Load(object sender, EventArgs e)
        {

        }

        private void leaveRoomlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
