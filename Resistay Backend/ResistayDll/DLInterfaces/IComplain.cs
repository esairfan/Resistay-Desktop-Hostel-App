using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface IComplain
    {
        bool AddComplain(Complain complain, string username, string connectionString);
        bool DeleteComplain(int complainId, string connectionString);
        List<Complain> GetAllComplainsofStudent(string studentname, string connectionString);
        List<int> GetComplainId(string studentName, string connectionString);
        bool DeleteComplainbyStudentName(string studentName, string connectionString);

    }
}
