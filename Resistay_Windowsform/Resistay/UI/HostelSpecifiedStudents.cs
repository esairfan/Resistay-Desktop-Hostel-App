using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;
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
    public partial class HostelSpecifiedStudents : Form
    {
        private RT rt;
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
         
        IStudent StudentDb = new StudentDb();
       
        public HostelSpecifiedStudents()
        {
            InitializeComponent();
            LoadStudents();
        }
        public HostelSpecifiedStudents(RT rt): this()
        {
           this.rt = rt ;
            LoadStudents();
        }
        public void LoadStudents()
        {
            if (rt  != null)
            {
                List<Student> studentList = StudentDb.GetStudentsByHostelName(rt.GetHostel().GetHostelName(),ConnectionString);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("Cnic", typeof(string));
                dataTable.Columns.Add("Age", typeof(int));
                dataTable.Columns.Add("RoomNumber", typeof(int));
                 
                for (int i = 0; i < studentList.Count; i++)
                {
                     
                        dataTable.Rows.Add(studentList[i].GetName(), studentList[i].GetGender(), studentList[i].GetCnic(), studentList[i].GetAge(), studentList[i].GetRoom().GetNumber());
                    
                    }
                StudentGrid.DataSource = dataTable;
            }
        }



        private void HostelSpecifiedStudents_Load(object sender, EventArgs e)
        {

        }

        private void StudentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
