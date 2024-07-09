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

namespace Resistay.UI
{
    public partial class StudentProfile : Form
    {
        Student student;
        public StudentProfile()
        {
            InitializeComponent();
        }
        public StudentProfile(Student student):this()
        {
            this.student = student;
            username.Text = student.GetName();
            Studentgendr.Text = student.GetGender();
            studentage.Text = student.GetAge().ToString();
            studentcnic.Text = student.GetCnic();
            hostell.Text = student.GetHostel().GetHostelName();
            roomno.Text = student.GetRoom().GetNumber().ToString();




        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Text = student.GetName();
        }

        private void Studentgendr_Click(object sender, EventArgs e)
        {
            Studentgendr.Text=student.GetGender();
        }

        private void studentage_Click(object sender, EventArgs e)
        {
            studentage.Text = student.GetAge().ToString();

        }

        private void studentcnic_Click(object sender, EventArgs e)
        {
            studentcnic.Text = student.GetCnic();
        }

        private void hostell_Click(object sender, EventArgs e)
        {
            hostell.Text= student.GetHostel().GetHostelName();
        }

        private void roomno_Click(object sender, EventArgs e)
        {
            roomno.Text = student.GetRoom().GetNumber().ToString();
        }

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
