using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;

namespace ResistayDll.DLInterfaces
{
     public interface IAnnoucement
    {
        bool AddAnnoucement(Annoucement annoucement);
        bool DeleteAnnoucement(int announcementId);
        List<Annoucement> GetAllAnnouncements();
        List<int> GetAnnoucementId();
    }
}
