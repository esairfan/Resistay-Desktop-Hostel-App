using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayConsole.UI
{
    public class MainMenu
    {
        public static int ShowMainMenu()
        {
            int option = 0;
            while ( option < 1 || option > 3)
            {
                Console.WriteLine("Annoucements");
                Console.WriteLine("Rules");
                Console.WriteLine("Exit");
                option = int.Parse(Console.ReadLine());
                
            }
            return option;
            
        }
    }
}
