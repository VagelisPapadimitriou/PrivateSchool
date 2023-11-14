using System;
using System.Text.RegularExpressions;

namespace CodingCamp.Aesthetic
{
    public class HideTheMainMenu
    {
        public static void ExecuteHideTheMenu()
        {
            //Hide the Menu after a choice
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Press any key to show the menu again...");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

        }
    }
}
