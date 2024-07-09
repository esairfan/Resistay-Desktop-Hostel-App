using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface IResident
    {
        bool AddResidents(Resident resident, string connectionString);
        bool DeleteResidentByHostelName(string hostelName, string connectionString);
        Resident IsResidentFound(string name, string password, string connectionString);
        bool UpdateResidentPassword(string password, string name, string connectionString);
        int GetResidentId(string username, string connectionString);
        void UpdateResidentHostelName(string username, string hostelname, string connectionString);
        bool DeleteResident(string residentName, string connectionString);
        string GetGenderOfSelectedPerson(string username, string connectionString);
    }
}
