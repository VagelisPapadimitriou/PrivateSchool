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
                ControllerMainMenu.ExecuteControllerMainMenu(userChoice);


            } while (userChoice != "E" && userChoice != "e");





           
        }

    }



}
