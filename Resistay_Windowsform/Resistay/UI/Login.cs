using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using ResistayDLL.Bl;
using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;
using ResistayDLL.Utilities;

namespace Resistay.UI
{
    public partial class Login : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
         
        IStudent StudentDb = new StudentDb();
        IResident ResidentDB = new ResidentDB();
        IRt RtDb = new RtDb();
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage Main = new MainPage();
            Main.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOnBtn_Click(object sender, EventArgs e)
        {
            Resident resident = ResidentDB.IsResidentFound(Username.Text, Password.Text, ConnectionString);
             if (resident != null) {
                
                if (resident.GetRole() == "warden")
                {
                   
                    this.Hide();
                    Warden warden = new Warden(resident.GetName(), resident.GetPassword(), resident.GetAge(), resident.GetCnic(), resident.GetRole(), resident.GetGender());
                    AdminMenu adminmenu = new AdminMenu(warden);

                    adminmenu.Show();
                }
                else if (resident.GetRole() == "student")
                {
                    Student student = StudentDb.GetStudentByName(resident.GetName(), ConnectionString);
                     
                        if (student.GetStudentStatus() != "Unalloted")
                        {
                            this.Hide();
                            StudentMenu studentmenu = new StudentMenu(student);
                            studentmenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sorry , You can not login as you are unalloted. You can log In until being alloted");
                        }
                    
                     

                }
                else if (resident.GetRole() == "rt")
                {
                    RT rt = RtDb.GetRtByName(resident.GetName(), ConnectionString);

                     
                        this.Hide();
                        RtMenu rtmenu = new RtMenu(rt);
                        rtmenu.Show();
                     

                }


            }
            else MessageBox.Show("You Entered Non Creditional Data");
        }
    }
}
