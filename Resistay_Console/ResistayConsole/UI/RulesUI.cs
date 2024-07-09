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
    public class RulesUI
    {
        //private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";
        private string Path = "D:\\Computer science\\OOP\\Business Application Project\\Project\\TextFiles\\Rules.txt";
        IRule Rules;
        public RulesUI()
        {
            this.Rules = new RulesFH(Path);
        }

        public void RulesMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Rule");
                Console.WriteLine("2. Delete Rule");
                Console.WriteLine("3. Show All Rules");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddRule();
                        break;
                    case "2":
                        DeleteRule();
                        break;
                    case "3":
                        ShowAllRules();
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

        private void AddRule()
        {
            Console.Write("Enter rule description: ");
            string description = Console.ReadLine();
            Console.Write("Enter rule date: ");
            string date = Console.ReadLine();

            

            Rules.AddRule(new Rule(description, date));
            Console.WriteLine("Rule added successfully.");
        }

        private void DeleteRule()
        {
            Console.Write("Enter rule ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Rules.DeleteRule (id);
                Console.WriteLine("Rule deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }

        private void ShowAllRules()
        {
            var announcements = Rules.GetAllRules();
            foreach (var rule in announcements)
            {
                Console.WriteLine($"ID: {rule.GetId()}, Description: {rule.GetDescription()}, Date: {rule.GetDate()}");
            }
        }

    }
}
