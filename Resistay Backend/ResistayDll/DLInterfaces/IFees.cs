using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResistayDll.DLInterfaces
{
    public interface IFees
    {
        List<Fees> GetAllTranscationHistoryofStudent(string studentname, string connectionString);
        List<string> GetFeesChallanNumberofStudent(string studentname, string connectionString);
        bool UpdateFeesandDate(int fees, string paiddate, string studentname, string challanNo, string connectionString);
        bool InsertFees(Fees fee, string username, string connectionString);
        bool DeleteFeebyStudentName(string studentName, string connectionString);
        bool IsDuplicateChallanNumber(string challanNumber, string connectionString);
        Fees GetFeesByChallans(string challan, string connectionString);
    }
}
