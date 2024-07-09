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
using ResistayDLL.Bl;

namespace Resistay.UI
{
    public partial class CheckComplain : Form
    {
        RT rt;
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        IComplain ComplainDb = new ComplainDb();
         
        IStudent StudentDb = new StudentDb();
         
        public CheckComplain()
        {
            InitializeComponent();
            LoadComplains();
        }
        public CheckComplain(RT rt):this()
            
        {
            this.rt = rt;
            LoadComplains();
        }
        public void LoadComplains()
        {
            if (rt != null)
            {
                List<Student> studentList = StudentDb.GetStudentsByHostelName(rt.GetHostel().GetHostelName(), ConnectionString);
                List<(Student student, Complain complain)> allComplains = new List<(Student, Complain)>();

               
                foreach (var student in studentList)
                {
                    List<Complain> studentComplains = ComplainDb.GetAllComplainsofStudent(student.GetName(), ConnectionString);

                 
                    foreach (var complain in studentComplains)
                    {
                        allComplains.Add((student, complain));
                    }
                }

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Student Name", typeof(string));
                dataTable.Columns.Add("Complaint Description", typeof(string));
                dataTable.Columns.Add("Complaint Date", typeof(DateTime)); 

                
                foreach (var (student, complain) in allComplains)
                {
                    dataTable.Rows.Add(student.GetName(), complain.GetDescription(), complain.GetDate());
                }

                ComplainGrid.DataSource = dataTable;
            }
        }


        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CheckComplain_Load(object sender, EventArgs e)
        {

        }
    }
}
