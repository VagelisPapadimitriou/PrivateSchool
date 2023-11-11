using System;
using System.Text.RegularExpressions;

namespace CodingCamp
{
    public class Application
    {
        public static void Run()
        {
            MyDatabase db = new MyDatabase();

            string userChoice;

            do
            {
                MainMenu.PrintMainMenu();

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("--------------------------------------------------------------------");
                Console.Write("Option: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.ResetColor();
                Validation.InputCheckMainMenu(userChoice);
                Console.Clear();

                //Switch Choice
                Controller.MainMenu(db, userChoice);


            } while (userChoice != "E" && userChoice != "e");
        }

        public static void ExecuteImports(MyDatabase db)
        {
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

                Controller.CreateMenu(userChoice);

            } while (userChoice != "B" && userChoice != "b");
        }

        public static void ExecuteResults(MyDatabase db)
        {
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

                Controller.ResultMenu(db, userChoice);

                HideTheResultMenu.ExecuteHideTheResultMenu(userChoice);


            } while (userChoice != "B" && userChoice != "b");
        }
    }



}
