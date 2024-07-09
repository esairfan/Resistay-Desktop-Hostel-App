using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface IRt
    {
        bool DeleteRtByHostelName(string hostelName, string connectionString);
        bool InsertRt(RT resident, int residentId, string connectionString);
        bool DeleteRt(string rtName, string connectionString);
        string GetHostelOfSelectedRt(string username, string connectionString);
        bool IsDuplicateRt(string username, string connectionString);
        bool UpdateRtPassword(string password, string name, string connectionString);
        RT GetRtByName(string name, string connectionString);
        List<RT> GeAllRts(string connectionString);
        List<string> GeAllRtNames(string connectionString);
        List<string> GeAllRtNamesbyHostel(string hostel, string connectionString);
    }
}
