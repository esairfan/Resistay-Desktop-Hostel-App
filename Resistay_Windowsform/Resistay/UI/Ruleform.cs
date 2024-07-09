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
using ResistayDll.DlFH;
using ResistayDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class Ruleform : Form
    {
        //private string Path = "D:\\Computer science\\OOP\\Business Application Project\\Project\\TextFiles\\Rules.txt";
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        IRule RulesDb;
        public Ruleform()
        {
            InitializeComponent();
            RulesDb = new RulesDb(ConnectionString);
            LoadRules();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {

            Hide();
             
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

            rulesId.Items.Clear(); 
            foreach (int ruleId in RuleIdList)
            {
                rulesId.Items.Add(ruleId);
            }
        }

        private void Rule_Load(object sender, EventArgs e)
        {

        }

        private void RulesDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void RulesBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(Rule.Text))
            {
                MessageBox.Show("Added Successfully");
                ResistayDLL.Bl.Rule rule = new ResistayDLL.Bl.Rule(Rule.Text, RulesDate.Text);
                RulesDb.AddRule(rule);
                LoadRules();

            }
            else
            {
                MessageBox.Show("Invalid Annoucement");
            }

        }

         

        private void rulesId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveRuleBtn_Click(object sender, EventArgs e)
        {

            RulesDb.DeleteRule(int.Parse(rulesId.Text));
            MessageBox.Show("Deleted Successfully");
            LoadRules();


        }
    }
}
