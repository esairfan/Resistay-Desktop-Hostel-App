using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;
using ResistayDll.DlDb;
using ResistayDll.DlFH;
using ResistayDll.DLInterfaces;

namespace ResistayConsole.UI
{
    public class AnnoucementUI
    {
        //private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        private string Path = "D:\\Computer science\\OOP\\Business Application Project\\Project\\TextFiles\\Annoucement.txt";
        IAnnoucement Annoucement;
        public AnnoucementUI()
            {
            this.Annoucement = new AnnoucementFH(Path);
            }
         
        public void ShowAnnouncementMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Announcement");
                Console.WriteLine("2. Delete Announcement");
                Console.WriteLine("3. Show All Announcements");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddAnnouncement();
                        break;
                    case "2":
                        DeleteAnnouncement();
                        break;
                    case "3":
                        ShowAllAnnouncements();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        private void AddAnnouncement()
        {
            Console.Write("Enter announcement description: ");
            string description = Console.ReadLine();
            Console.Write("Enter announcement date: ");
            string date = Console.ReadLine();

             
            Annoucement.AddAnnoucement(new Annoucement(description, date));
            Console.WriteLine("Announcement added successfully.");
        }

        private void DeleteAnnouncement()
        {
            Console.Write("Enter announcement ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Annoucement.DeleteAnnoucement(id);
                Console.WriteLine("Announcement deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }

        private void ShowAllAnnouncements()
        {
            var announcements = Annoucement.GetAllAnnouncements();
            foreach (var announcement in announcements)
            {
                Console.WriteLine($"ID: {announcement.GetId()}, Description: {announcement.GetDescription()}, Date: {announcement.GetDate()}");
            }
        }

    }
}
