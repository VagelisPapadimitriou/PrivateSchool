using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp
{
    public class Results
    {
        public static void ExecuteResults()
        {
            MyDatabase db = new MyDatabase();

            string userChoice;

            do
            {
                ResultMenu.PrintResultMenu();

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("------------------------------------------------------------------------");
                Console.Write("Option: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.ResetColor();
                Validation.InputCheckResultMenu(userChoice);
                Console.Clear();

                ControllerResultMenu.ExecuteControllerResultMenu(db, userChoice);

                HideTheResultMenu.ExecuteHideTheResultMenu(userChoice);


            } while (userChoice != "B" && userChoice != "b");
        }

    }
}
