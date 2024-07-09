using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Annoucement
    {
        private string Description;
        private string Date;
        private int Id;

        public Annoucement()
        {

        }
        public Annoucement(string description,string date)
            {
            this.Description = description;
            this.Date = date;
        }
        public Annoucement(string description, string date,int Id)
        {
            this.Description = description;
            this.Date = date;
            this.Id = Id;
        }
        public string GetDescription() { return Description; }
        public void SetDescription(string description) { this.Description = description;}
        public string GetDate() { return Date;}
        public void SetDate(string date) { }
        public int GetId() { return Id;}
        public void SetId(int id) {  this.Id = id;}

    }
}
