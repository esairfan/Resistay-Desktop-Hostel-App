using ResistayDLL.Bl;
using ResistayDll.DlDb;
using ResistayDLL.Utilities;
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
    public partial class AddRt : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        private ErrorProvider errorProvider;
         
        Ihostel HostelDb = new HostelDb();
       
        IResident ResidentDB = new ResidentDB();
        IRt RtDb = new RtDb();
        public AddRt()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            RtHostel.SelectedIndexChanged += RtHostel_SelectedIndexChanged; 
            gender.TextChanged += gender_TextChanged; 
            LoadRts();
        }

        private void RtHostel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void gender_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidGender(gender.Text))
            {
                errorProvider.SetError(gender, "Invalid gender! Gender should be either 'Male' or 'Female'.");
            }
            else
            {
                errorProvider.SetError(gender, ""); 
            }

          
            UpdateHostelComboBox();
        }

        private void UpdateHostelComboBox()
        {
            if (!string.IsNullOrEmpty(gender.Text))
            {
                string rtGender = gender.Text.ToLower(); 
                List<string> availableHostels = HostelDb.GetHostelNamesByGender(rtGender, ConnectionString);

                if (availableHostels != null && availableHostels.Count > 0)
                {
                    RtHostel.DataSource = availableHostels;
                }
                else
                {
                    RtHostel.DataSource = null;
                }
            }
            else
            {
                RtHostel.DataSource = null;
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

        private void AddRtBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidGender(gender.Text) &&
               Validation.IsValidPassword(password.Text) &&
               Validation.IsValidAge(age.Text) &&
               ConfirmPassword.Text == password.Text &&
               Validation.IsValidPhoneNumber(PhoneNo.Text) &&
               Validation.IsValidCNIC(Cnic.Text) &&
               Validation.IsValidUsername(username.Text) &&
                RtDb.IsDuplicateRt(username.Text, ConnectionString))
            {
                RT Rt = new RT(username.Text, password.Text, int.Parse(age.Text), Cnic.Text, "rt", gender.Text.ToLower(), HostelDb.GetHostelByName(RtHostel.Text, ConnectionString), PhoneNo.Text);
                Resident Resident = new Resident(username.Text, password.Text, int.Parse(age.Text), Cnic.Text, "rt", gender.Text.ToLower(), HostelDb.GetHostelByName(RtHostel.Text, ConnectionString));
                HostelDb.GetHostelByName(RtHostel.Text, ConnectionString).SetRt(Rt);
                RtDb.InsertRt(Rt, ResidentDB.GetResidentId(username.Text, ConnectionString), ConnectionString);
                ResidentDB.AddResidents(Resident, ConnectionString);
                HostelDb.UpdateHostelStatusChecked(RtHostel.Text, ConnectionString);
                MessageBox.Show("Added Successfully");
                LoadRts();
            }
            else
            {
                MessageBox.Show("Invalid User");
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

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text != password.Text)
            {
                errorProvider.SetError(ConfirmPassword, "Password is not same. So please match it");
            }
            else
            {
                errorProvider.SetError(ConfirmPassword, "");
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidUsername(username.Text) ||   !RtDb.IsDuplicateRt(username.Text, ConnectionString))
            {
                errorProvider.SetError(username, "Invalid username!");
            }
            else
            {
                errorProvider.SetError(username, "");  
            }

            UpdateHostelComboBox();
        }

        private void PhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidPhoneNumber(PhoneNo.Text))
            {
                errorProvider.SetError(PhoneNo, "Invalid Phone Number! Phone should start with '03' and contain exactly 11 digits.");
            }
            else
            {
                errorProvider.SetError(PhoneNo, ""); 
            }
        }
        private void HostelNameLabel_Click(object sender, EventArgs e)
        { 

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
             
        }
        private void LoadRts()
        {
            List<RT> Rtlist = RtDb.GeAllRts(ConnectionString);  
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Cnic", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Hostel", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));

             
            for (int i = 0; i < Rtlist.Count; i++)
            {
                dataTable.Rows.Add(Rtlist[i].GetName(), Rtlist[i].GetGender(), Rtlist[i].GetCnic(), Rtlist[i].GetAge(), Rtlist[i].GetHostel().GetHostelName(), Rtlist[i].GetPhoneNumber() );
            }

            RtGrid.DataSource = dataTable;

             
             }

        private void AddRt_Load(object sender, EventArgs e)
        {

        }

        private void RtHostel_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
