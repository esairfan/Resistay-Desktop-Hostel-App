using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Salary
    {
        private int ChecKAmount;
        private string CheckNumber;
        private string IssueDate;
        private string RecievedDate;
        public Salary ()
        {

        }
        public Salary(int checKAmount, string checkNumber, string issueDate)
        {
            ChecKAmount = checKAmount;
            CheckNumber = checkNumber;
            IssueDate = issueDate;
           
        }
    public Salary(int checKAmount, string checkNumber, string issueDate, string recievedDate) : this(checKAmount, checkNumber, issueDate)
        {
            RecievedDate = recievedDate;
        }
        public int GetCheckAmunt() { return  ChecKAmount; }
        public string GetCheckNumber() {  return CheckNumber; }
        public string GetIssueDate() { return IssueDate; }
        public string GetRecievedDate() {  return RecievedDate; }
        public void SetCheckAmount(int Amount) { this.ChecKAmount = Amount; }
        public void SetIssueDate(string issueDate) { this.IssueDate = issueDate; }
        public void SetRecievedDate(string RecievedDate) { this.RecievedDate = RecievedDate; }
        public void SetCheckNumber(string CheckNumber) { this.CheckNumber= CheckNumber; }
    }
}
