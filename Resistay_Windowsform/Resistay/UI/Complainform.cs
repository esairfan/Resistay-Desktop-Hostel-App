using ResistayDLL.Bl;
using ResistayDll.DlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResistayDLL.Utilities;

namespace Resistay.UI
{
    public partial class Complainform : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        Student student;

        public Complainform()
        {
            InitializeComponent();
            LoadComplains();
        }
        public Complainform(Student student): this()
        {
            this.student = student;
        }
        private void LoadComplains()
        {
            if (student != null)
            {
                List<Complain> complainList = ComplainDb.GetAllComplainsofStudent(student.GetName(), ConnectionString);
                List<int> ComplainIdList = ComplainDb.GetComplainId(student.GetName(), ConnectionString);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ComplainId", typeof(int));
                dataTable.Columns.Add("Description", typeof(string));
                dataTable.Columns.Add("Date", typeof(string));

                // Add both announcement ID and description to the DataTable
                for (int i = 0; i < complainList.Count; i++)
                {
                    dataTable.Rows.Add(ComplainIdList[i], complainList[i].GetDate(), complainList[i].GetDescription());
                }

                ComplainGrid.DataSource = dataTable;

                complainIdcombo.Items.Clear(); // Clear existing items to avoid duplicates
                foreach (int complainsId in ComplainIdList)
                {
                    complainIdcombo.Items.Add(complainsId);
                }



            }
        }
        private void Complainform_Load(object sender, EventArgs e)
        {

        }

        private void ComplainBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(complain.Text))
            {
                MessageBox.Show("Added Successfully");
                Complain complein = new Complain(complain.Text,ComplainDate.Text);
                ComplainDb.AddComplain(complein,student.GetName(), ConnectionString);
                LoadComplains();

            }
            else
            {
                MessageBox.Show("Invalid Complain");
            }
        }

        private void RemoveComplainBtn_Click(object sender, EventArgs e)
        {
            ComplainDb.DeleteComplain(int.Parse(complainIdcombo.Text), ConnectionString);
            MessageBox.Show("Deleted Successfully");
            LoadComplains();

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
