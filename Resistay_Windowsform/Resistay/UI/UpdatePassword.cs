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
using ResistayDll.DlDb;
using ResistayDLL.Utilities;
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{

    public partial class UpdatePassword : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        string Username;
        string Password;
         
        IStudent StudentDb = new StudentDb();
        IResident ResidentDB = new ResidentDB();
        IRt RtDb = new RtDb();

        public UpdatePassword()
        {
            InitializeComponent();
        }
        public UpdatePassword(string name,string password) : this()
        {
            this.Username = name;
            this.Password = password;
        }
         

        private void Updatepasswordbtn_Click(object sender, EventArgs e)
        {
            if (Username != null)
            {
                if (CurrentPassword.Text == Password)
                {
                    if (Validation.IsValidPassword(NewPassword.Text))
                    {
                        StudentDb.UpdateStudentPassword(NewPassword.Text, Username, ConnectionString);
                        ResidentDB.UpdateResidentPassword(NewPassword.Text, Username, ConnectionString);
                        RtDb.UpdateRtPassword(Password, Username, ConnectionString);
                        MessageBox.Show("Password Updated");
                    }
                    else
                    {
                        MessageBox.Show("Invalid password! Password should be at least 8 characters long, containing at least one uppercase letter, one lowercase letter, and one digit.");
                    }
                }
                else
                {
                    MessageBox.Show("You have entered the wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Student information is not available.");
            }
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
