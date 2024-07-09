using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Rule
    {
        private string Description;
        private string Date;
        private int Id;
        public Rule() { }
        public Rule(string description, string date)
        {
            Description = description;
            Date = date;
        }
        public Rule(string description, string date,int ruleId)
        {
            Description = description;
            Date = date;
            Id = ruleId;
        }

        public string GetDescription() { return Description; }
        public void SetDescription(string description) { this.Description = description; }
        public string GetDate() { return Date; }
        public void SetDate(string date) { this.Date = date; }

        public int GetId() { return Id; }
        public void SetId(int id) { this.Id = id; }

    }
}
