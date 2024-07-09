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

namespace Resistay.UI
{
    public partial class StudentMenu : Form
    {
        Student student;
        public StudentMenu()
        {
            InitializeComponent();
        }
        public StudentMenu(Student student): this()
        {
            this.student = student;
            ProfileLabel.Text = $"Hi {student.GetName()}! Welcome to your Student Profile";
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogOut logOutForm = new LogOut();
            logOutForm.LoggedOut += LogOutForm_LoggedOut;
            logOutForm.Show();
        }
        private void LogOutForm_LoggedOut(object sender, EventArgs e)
        {
            this.Close(); 
            ((LogOut)sender).Close(); 
        }

        private void AnnoucemntBtn_Click(object sender, EventArgs e)
        {
            CheckAnnoucement checkAnnoucement = new CheckAnnoucement();
            checkAnnoucement.Show();
        }

        private void RulesBtn_Click(object sender, EventArgs e)
        {
            CheckRules checkRules = new CheckRules();
            checkRules.Show();
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void LeaveRoom_LeaveConfirmed(object sender, EventArgs e)
        {
            this.Close();
            ((LeaveRoom)sender).Close(); 
        }

        private void leaveroombtn_Click(object sender, EventArgs e)
        {
            LeaveRoom leaveRoom = new LeaveRoom(student.GetName(), this);
            leaveRoom.LeaveConfirmed += LeaveRoom_LeaveConfirmed;
            leaveRoom.Show();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
         StudentProfile studentProfile = new StudentProfile(student);
         studentProfile.Show();
        }

        private void UpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword(student.GetName(),student.GetPassword());
            updatePassword.Show();
        }

        private void ComplainsBtn_Click(object sender, EventArgs e)
        {
            StudentComplain studentComplain = new StudentComplain(student);
            studentComplain.Show();
        }

        private void feesbtn_Click(object sender, EventArgs e)
        {
            FeesPayment feesPayment = new FeesPayment(student);
            feesPayment.Show();
        }
    }
}
