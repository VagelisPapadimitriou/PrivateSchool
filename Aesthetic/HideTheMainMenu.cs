using System;
using System.Text.RegularExpressions;

namespace CodingCamp
{
    public class HideTheMainMenu
    {
        public static void ExecuteHideTheMainMenu(string userChoice)
        {
            //Hide the Menu after a choice
            if (Regex.IsMatch(userChoice, @"^[1-2]$"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("Press any key to show the menu again...");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            }
        }
    }
}
