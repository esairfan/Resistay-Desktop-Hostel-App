using ResistayDLL.Bl;
using ResistayDll.DlDb;
using ResistayDLL.Utilities;
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

namespace Resistay.UI
{
    public partial class AllotSalary : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        ISalary SalaryDb = new SalaryDb();
        IRt RtDb = new RtDb();
        public AllotSalary()
        {
            InitializeComponent();
            List<string> Rtlists = RtDb.GeAllRtNames(ConnectionString);
            AllotRtCombo.DataSource = Rtlists;
        }

        private void AllotementSalary_Click(object sender, EventArgs e)
        {

        }

        private void AllotSalary_Load(object sender, EventArgs e)
        {
         
        }

        private void AllotsalaryBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidAmount(Salary.Text) && Validation.IsEmptyInput(Salary.Text))
            {

                if (int.Parse(Salary.Text) > 0)
                {
                    Salary salary = new Salary(int.Parse(Salary.Text), SalaryCheck.Text, IssueDate.Text) ;
                    SalaryDb.InsertSalary(salary, AllotRtCombo.Text, ConnectionString);
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

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
