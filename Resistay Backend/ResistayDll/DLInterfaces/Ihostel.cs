using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface Ihostel
    {
        bool InsertHostel(Hostel hostel, string connectionString);
        bool DeleteHostelByHostelName(string hostelName, string connectionString);
        List<Hostel> GetAllHostels(string connectionString);
        List<string> GetHostelNames(string connectionString);
        List<string> GetHostelNamesByGender(string gender, string connectionString);
        Hostel GetHostelByName(string hostelName, string connectionString);
        List<string> GetHostelBySelecteddltRoom(int room, string connectionString);
        bool IsDuplicateHostel(string hostelName, string connectionString);
        bool UpdateHostelStatusUnchecked(string hostelName, string connectionString);
        bool UpdateHostelStatusChecked(string hostelName, string connectionString);
    }
}
