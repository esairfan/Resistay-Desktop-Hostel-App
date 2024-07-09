using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Complain
    {
        private string Date;
        private string Description;

        public Complain (string Description, string date)
        {
            this.Description = Description;
            Date = date;
        }
        public Complain()
        {

        }
        public string GetDescription() { return Description; }
        public void SetDescription(string Description) { this.Description =Description; }
        public string GetDate() { return Date; }
        public void SetDate(string Date) { this.Date = Date; }
    }
}
