using ResistayConsole.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                int mainMenuOption = MainMenu.ShowMainMenu();

                switch (mainMenuOption)
                {
                    case 1:
                        AnnoucementUI annoucementUI = new AnnoucementUI();
                        annoucementUI.ShowAnnouncementMenu();
                        break;
                    case 2:
                        RulesUI rulesUI = new RulesUI();
                        rulesUI.RulesMenu();
                        break;
                    case 3:
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }

            Console.WriteLine("Program exited.");
        }
    }
}
