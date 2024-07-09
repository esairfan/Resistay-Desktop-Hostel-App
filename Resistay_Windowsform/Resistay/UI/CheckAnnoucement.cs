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
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class CheckAnnoucement : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        IAnnoucement AnnoucementDb;
        public CheckAnnoucement()
        {
            InitializeComponent();
            
            AnnoucementDb = new AnnoucementDb(ConnectionString);
            LoadAnnouncements();
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
                dataTable.Rows.Add(AnnoucementIdList[i], Annoucementlist[i].GetDate(), Annoucementlist[i].GetDescription());
            }

            AnnoucementGridView1.DataSource = dataTable;
             
            



        }

        private void AnnoucementLabel_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnnoucement_Load(object sender, EventArgs e)
        {

        }

        private void AnnoucementGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
