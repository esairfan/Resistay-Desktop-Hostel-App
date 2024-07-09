using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;

namespace ResistayDll.DlFH
{
    public class RulesFH : IRule
    {
        private string Path;
        private int Id = 0;
        public RulesFH(string Path)
        {
            this.Path = Path;
            LoadRulesFromFile();
        }
        private List<Rule>  Rules = new List<Rule>();

        private bool AddRuleInList(Rule rule)
        {
            if (rule != null)
            {
                Rules.Add(rule);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LoadRulesFromFile()
        {
            string record;
            StreamReader streamReader = new StreamReader(Path);
            List<Rule> ruless = new List<Rule>();
            if (File.Exists(Path))
            {
                while ((record = streamReader.ReadLine()) != null)
                {
                    string[] splitrecord = record.Split('|');
                    int ruleId = Convert.ToInt32(splitrecord[0]);
                    string ruleDetail = splitrecord[1];
                    string ruleDate = splitrecord[2];
                    Rule rule = new Rule (ruleDetail, ruleDate, ruleId);
                    Id++;
                    AddRuleInList(rule);
                }
                streamReader.Close();
            }
        }
        public List<Rule> GetAllRules()
        {
            return Rules;
        }
        public bool AddRule(Rule rule)
        {
            bool Check = false;
            Id++;
            rule.SetId(Id);
            StreamWriter streamWriter = new StreamWriter(Path, false);
            if (AddRuleInList(rule) == true)
            {
                Check = true;
            }
            foreach (Rule Rule in Rules)
            {
                streamWriter.WriteLine(Rule.GetId() + "|" + Rule.GetDescription() + "|" + Rule.GetDate());
                streamWriter.Flush();
            }
            streamWriter.Close();
            return Check;
        }
        public List<int> GetRuleIds()
        {
            List<int> ruleIds = new List<int>();
            foreach (Rule Rule in Rules)
            {
                ruleIds.Add(Rule.GetId());
            }
            return ruleIds;
        }
        public bool DeleteRule(int ruleId)
        {
            foreach (Rule Rule in Rules)
            {
                if (Rule.GetId() == ruleId)
                {
                    Rules.Remove(Rule);
                    Id--;
                    UpdateFile();
                    return true;
                }
            }
            return false;
        }
        private void UpdateFile()
        {
            StreamWriter streamWriter = new StreamWriter(Path, false);
            foreach (Rule rule in Rules)
            {
                streamWriter.WriteLine(rule.GetId() + "|" + rule.GetDescription() + "|" + rule.GetDate());
            }
            streamWriter.Close();
        }
    }
}
