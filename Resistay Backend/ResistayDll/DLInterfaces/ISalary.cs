using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface ISalary
    {
       List<Salary> GetAllRecievedChecks(string rtName, string connectionString);
       bool UpdateSalaryandDate(string recieveddate, string rtname, string checknumber, string connectionString);
        bool InsertSalary(Salary salary, string rtname, string connectionString);
        List<string> GetCheckNumber(string rtname, string connectionString);
        bool DeleteChecksbyRtName(string rtName, string connectionString);
        Salary GetAmountByChallans(string checkNumber, string connectionString);
    }
}
