using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Bl
{
    public class Fees
    {
        private int FeeAmount;
        private string DueDate;
        private string PayDate;
        private string ChallanNumber;

        public Fees() { }
        public Fees(int FeeAmount,string DueDate, string challanNo) 
        {
            this.FeeAmount = FeeAmount;
            this.DueDate = DueDate;
            this.ChallanNumber = challanNo;
        }
        public Fees(int FeeAmount, string DueDate, string challanNo,string PaidDate)
        {
            this.FeeAmount = FeeAmount;
            this.DueDate = DueDate;
            this.ChallanNumber = challanNo;
            this.PayDate = PaidDate;
        }
        public string GetDueDate() { return DueDate; }
        public void SetDueDate(string Date) { this.DueDate = Date; }
        public string GetPayDate() { return PayDate; }
        public void SetPayDate(string Date) { this.PayDate = Date; }
        public int GetFeeAmount() { return FeeAmount;}
        public void SetFeeAmount(int FeeAmount) {  this.FeeAmount = FeeAmount; }
        public string GetChallanNumber() { return this.ChallanNumber; }
        public void SetChallanNumber(string challanNo) { this.ChallanNumber = challanNo; }
         
        }
}
