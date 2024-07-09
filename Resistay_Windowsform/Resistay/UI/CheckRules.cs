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
    public partial class CheckRules : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        IRule RulesDb;
        public CheckRules()
        {
            InitializeComponent();
            RulesDb = new RulesDb(ConnectionString);
            LoadRules();    
        }
        private void LoadRules()
        {
            List<ResistayDLL.Bl.Rule> Rulelist = RulesDb.GetAllRules();
            List<int> RuleIdList = RulesDb.GetRuleIds();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("RulesId", typeof(int));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            
            for (int i = 0; i < Rulelist.Count; i++)
            {
                dataTable.Rows.Add(RuleIdList[i], Rulelist[i].GetDate(), Rulelist[i].GetDescription());
            }

            RulesGrid.DataSource = dataTable;

             
        }
        private void RulesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CheckRules_Load(object sender, EventArgs e)
        {

        }
    }
}
