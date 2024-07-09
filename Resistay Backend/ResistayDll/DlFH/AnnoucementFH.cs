using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;
using ResistayDll.DLInterfaces;

namespace ResistayDll.DlFH
{
    public class AnnoucementFH : IAnnoucement
    {
        private string Path;
        private int Id = 0;
        public AnnoucementFH(string Path) 
        {
            this.Path = Path;
            LoadAnnoucementFromFile();
        }
        private List<Annoucement> Annoucements = new List<Annoucement>();

        private bool AddAnnoucementInList(Annoucement annoucement)
        {
            if (annoucement != null)
            {
                

                Annoucements.Add(annoucement);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LoadAnnoucementFromFile()
        {
            string record;
            StreamReader streamReader = new StreamReader(Path);
            List<Annoucement> annoucements = new List<Annoucement>();
            if(File.Exists(Path)) 
            {
                while((record =streamReader.ReadLine())!=null)
                {
                    string[] splitrecord = record.Split(',');
                    int annoucementId = Convert.ToInt32(splitrecord[0]);
                    string annoucementDetail = splitrecord[1];
                    string annoucementDate = splitrecord[2];
                    Annoucement annoucement = new Annoucement(annoucementDetail,annoucementDate,annoucementId);
                    Id++;
                    AddAnnoucementInList(annoucement);
                }
                streamReader.Close();
            }
        }
        public List<Annoucement> GetAllAnnouncements()
        {
            return Annoucements;
        }
        public bool AddAnnoucement(Annoucement annoucement)
        {
            bool Check = false;
            Id++;
            annoucement.SetId(Id);
            StreamWriter streamWriter = new StreamWriter(Path,false);
            if(AddAnnoucementInList(annoucement)==true)
            {
                Check = true;
            }
            foreach(Annoucement Annoucement in Annoucements)
            {
                streamWriter.WriteLine(Annoucement.GetId() + "," + Annoucement.GetDescription() + "," + Annoucement.GetDate());
                streamWriter.Flush();
            }
            streamWriter.Close();
            return Check;
        }
        public List<int> GetAnnoucementId()
        {
            List<int> announcementIds = new List<int>();
            foreach (Annoucement annoucement in Annoucements)
            {
                announcementIds.Add(annoucement.GetId());
            }
            return announcementIds;
        }
        public bool DeleteAnnoucement(int announcementId)
        {
            foreach (Annoucement annoucement in Annoucements)
            {
                if (annoucement.GetId() == announcementId)
                {
                    Annoucements.Remove(annoucement);
                    return true;
                }
            }
            return false;
        }


    }
}
