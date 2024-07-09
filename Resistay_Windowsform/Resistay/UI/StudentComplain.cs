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
using ResistayDLL.Utilities;

namespace Resistay.UI
{
    public partial class StudentComplain : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        Student student;

        IComplain ComplainDb = new ComplainDb();
        
        public StudentComplain()
        {
            InitializeComponent();
            LoadComplains();
        }
        public StudentComplain(Student student) : this ()
        {
            this.student = student;
        }
        
        public void LoadComplains()
        {    if (student != null)
            {
                List<Complain> complainList = ComplainDb.GetAllComplainsofStudent(student.GetName(), ConnectionString);
                List<int> ComplainIdList = ComplainDb.GetComplainId(student.GetName(), ConnectionString);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ComplainId", typeof(int));
                dataTable.Columns.Add("Description", typeof(string));
                dataTable.Columns.Add("Date", typeof(string));

                
                for (int i = 0; i < complainList.Count; i++)
                {
                    dataTable.Rows.Add(ComplainIdList[i], complainList[i].GetDescription(), complainList[i].GetDate());
                }

                ComplainGrid.DataSource = dataTable;

                ComplainIdCombo.Items.Clear();
                foreach (int complainsId in ComplainIdList)
                {
                    ComplainIdCombo.Items.Add(complainsId);
                }
            }
        }
        private void Complainlabel1_Click(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ComplainBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(ComplainDetails.Text))
            {
                MessageBox.Show("Added Successfully");
                Complain complain = new Complain(ComplainDetails.Text, ComplainDate.Text);
                student.AddComplains(complain);
                ComplainDb.AddComplain(complain,student.GetName(), ConnectionString);
                LoadComplains();

            }
            else
            {
                MessageBox.Show("Invalid Complains");
            }
        }

        private void RemoveComplainBtn_Click(object sender, EventArgs e)
        {
            ComplainDb.DeleteComplain(int.Parse(ComplainIdCombo.Text), ConnectionString);
            MessageBox.Show("Deleted Successfully");
            LoadComplains();
        }

        private void StudentComplain_Load(object sender, EventArgs e)
        {

        }

        private void ComplainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
