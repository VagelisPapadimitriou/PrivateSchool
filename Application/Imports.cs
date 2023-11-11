using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp
{
    public class Imports
    {
        public static void ExecuteImports()
        {
            MyDatabase db = new MyDatabase();

            string userChoice;

            do
            {
                CreateMenu.PrintCreateMenu();

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("------------------------------------------------------------------------");
                Console.Write("Option: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.ResetColor();
                Validation.InputCheckCreateMenu(userChoice);
                Console.Clear();

                ControllerCreateMenu.ExecuteControllerCreateMenu(userChoice);

            } while (userChoice != "B" && userChoice != "b");
        }

    }
}
