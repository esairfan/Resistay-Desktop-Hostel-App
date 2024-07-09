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
using ResistayDLL.Bl;
using ResistayDLL.Utilities;
using ResistayDll.DLInterfaces;
using System.IO;
using ResistayDll.DlFH;
namespace Resistay.UI

{
    public partial class Annoucementform : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
       // private string Path = "D:\\Computer science\\OOP\\Business Application Project\\Project\\TextFiles\\Annoucement.txt";
        IAnnoucement AnnoucementDb; 
        public Annoucementform()
        {
            InitializeComponent();
            
            AnnoucementDb = new AnnoucementDb(ConnectionString);
            LoadAnnouncements();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide(); 
        }

        private void AnnoucementGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Annoucement_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadAnnouncements()
        {
            List<Annoucement> Annoucementlist = AnnoucementDb.GetAllAnnouncements();
            List<int> AnnoucementIdList = AnnoucementDb.GetAnnoucementId();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("AnnouncementId", typeof(int));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));

           
            for (int i = 0; i < Annoucementlist.Count; i++)
            {
                dataTable.Rows.Add(AnnoucementIdList[i], Annoucementlist[i].GetDate(), Annoucementlist[i].GetDescription() );
            }

            AnnoucementGridView1.DataSource = dataTable;

            AnnoucementIdCombo.Items.Clear();
            foreach (int announcementId in AnnoucementIdList)
            {
                AnnoucementIdCombo.Items.Add(announcementId);
            }



        }

        private void AnnoucementBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(Anoucement.Text))
            {
                MessageBox.Show("Added Successfully");
                Annoucement annoucement = new Annoucement(Anoucement.Text,AnnoucementDate.Text);
                AnnoucementDb.AddAnnoucement(annoucement);
                LoadAnnouncements();
                
            }
            else
            {
                MessageBox.Show("Invalid Annoucement");
            }

        }

        private void Anoucement_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AnnoucementIdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveAnnoucementBtn_Click(object sender, EventArgs e)
        {
            AnnoucementDb.DeleteAnnoucement(int.Parse(AnnoucementIdCombo.Text));
            MessageBox.Show("Deleted Successfully");
            LoadAnnouncements();
        }
    }
}
