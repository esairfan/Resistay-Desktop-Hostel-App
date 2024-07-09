using ResistayDLL.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDll.DLInterfaces
{
    public interface IStudent
    {
        bool AddStudent(Student resident, int ResidentId, string connectionString);
        bool DeleteStudentByHostelName(string hostelName, string connectionString);
        List<string> GetNameOfUnallotedStudents(string connectionString);
        string GetHostelOfSelectedStudent(string username, string connectionString);
        bool IsDuplicateStudent(string username, string connectionString);
        Student GetStudentByName(string name, string connectionString);
        int GetRoomNoOfSelectedStudent(string studentName, string connectionString);
        bool DeleteStudentByRoomNumber(int roomNumber, string connectionString);
        bool UpdateStudentStatus(string username, int roomno, string hostelname, string connectionString);
        bool UpdateStudentPassword(string password, string name, string connectionString);
        List<Student> GetStudentsWithAllotedStatus(string connectionString);
        List<Student> GetStudentsByHostelName(string hostelName, string connectionString);
        List<Student> GetAllStudents(string connectionString);
        bool DeleteStudent(string studentName, string connectionString);
        List<string> GeAllStudentNames(string connectionString);
        List<string> GetStudentNamesByHostelName(string hostelName, string connectionString);
        List<String> GetNameOfAllotedStudents(string connectionString);
    }
}
