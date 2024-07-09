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
using ResistayDLL.Utilities;
using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class SignUp : Form
    {
        private ErrorProvider errorProvider;
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
         
        IStudent StudentDb = new StudentDb();
        IResident ResidentDB = new ResidentDB();
        
        public SignUp()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; 
        }
         

        private void SignUp_Load(object sender, EventArgs e)
        {
             
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(ConfirmPassword.Text!=password.Text)
            {
                errorProvider.SetError(ConfirmPassword,"Password is not same. So plz match it");
            }
            else
            {
                errorProvider.SetError(ConfirmPassword, "");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidPassword(password.Text))
            {
                errorProvider.SetError(password, "Invalid password! Password should be at least 8 characters long, containing at least one uppercase letter, one lowercase letter, and one digit.");
            }
            else
            {
                errorProvider.SetError(password, ""); 
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage Main = new MainPage();
            Main.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
             
                if (!Validation.IsValidUsername(username.Text) || !StudentDb.IsDuplicateStudent(username.Text,ConnectionString))
                {
                    errorProvider.SetError(username, "Invalid username! or Duplicate Username ");
                }
                else
                {
                    errorProvider.SetError(username, "");
                }
            
            
        }

        private void Cnic_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidCNIC(Cnic.Text))
            {
                errorProvider.SetError(Cnic, "Invalid CNIC! CNIC should start with '33' and contain exactly 13 digits.");
            }
            else
            {
                errorProvider.SetError(Cnic, ""); 
            }
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidGender(gender.Text))
            {
                errorProvider.SetError(gender, "Invalid gender! Gender should be either 'Male' or 'Female'.");
            }
            else
            {
                errorProvider.SetError(gender, ""); 
            }
        }

        private void role_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidRole(role.Text))
            {
                errorProvider.SetError(role, "Invalid role! Role should be either 'student'.");
            }
            else
            {
                errorProvider.SetError(role, "");
            }
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            if  (!Validation.IsValidAge(age.Text))            {
                errorProvider.SetError(role, "Invalid Age");
            }
            else 
            {
                errorProvider.SetError(role, "");
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidGender(gender.Text) &&
               Validation.IsValidPassword(password.Text) &&
               Validation.IsValidAge(age.Text) &&
               ConfirmPassword.Text == password.Text &&
               Validation.IsValidRole(role.Text) &&
               Validation.IsValidCNIC(Cnic.Text) &&
               Validation.IsValidUsername(username.Text)
               && StudentDb.IsDuplicateStudent(username.Text, ConnectionString))
            {
                MessageBox.Show("Registered Successfully");
                Resident resident  = new Student(username.Text,password.Text, int.Parse(age.Text),Cnic.Text,role.Text.ToLower(),gender.Text.ToLower());
                Student Student = new Student(username.Text, password.Text, int.Parse(age.Text), Cnic.Text, role.Text.ToLower(), gender.Text.ToLower());

                ResidentDB.AddResidents(resident, ConnectionString);
                int Id = ResidentDB.GetResidentId(resident.GetName(), ConnectionString);
                StudentDb.AddStudent(Student,Id, ConnectionString);
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

         
            private void reset_Click(object sender, EventArgs e)
            {
               
                username.Text = "";
                password.Text = "";
                ConfirmPassword.Text = "";
                Cnic.Text = "";
                gender.Text = "";
                role.Text = "";
                age.Text = "";

                 
                errorProvider.Clear();
            }

        }
    }

