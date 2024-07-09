using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;
using ResistayDLL.Utilities;
using ResistayDLL.Bl;


namespace Resistay.UI
{
    public partial class FeesAllotement : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        
        IStudent StudentDb = new StudentDb();
        IFees FeesDb = new FeesDb();
        public FeesAllotement()
        {
            InitializeComponent();
            List<string> AllotedStudents = StudentDb.GetNameOfAllotedStudents(ConnectionString);
            AllotStudentCombo.DataSource = AllotedStudents;

        }

         

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

         

        private void AllotBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void FeesAllotement_Load(object sender, EventArgs e)
        {

        }

        private void AllotStudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllotfeesBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidAmount(StudentFee.Text) && Validation.IsEmptyInput(StudentFee.Text))
            {

                if (int.Parse(StudentFee.Text) > 0)
                {
                    Fees fees = new Fees(int.Parse(StudentFee.Text), DueDate.Text, FeesChallan.Text);
                    FeesDb.InsertFees(fees, AllotStudentCombo.Text, ConnectionString);
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }

            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
