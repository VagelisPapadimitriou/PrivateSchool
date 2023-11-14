using System;

namespace CodingCamp.Views.Menus
{
    public class MainMenu
    {
        public static void PrintMainMenu()
        {
            const int spacing = -37;
            const int exitSpacing = 45;
            const int optionSpacing = 46;

            //Choose an Option Message
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{"--------------------- Welcome to our School!!! ---------------------\n\n"}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"--> CHOOSE AN OPTION <--",optionSpacing}");
            Console.WriteLine();
            Console.ResetColor();

            //Choices
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"-------------------------------",spacing}{"-------------------------------"}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"      1 - Import New Data",spacing}{"         2 - View Data"}");
            Console.WriteLine("\n");

            //Exit
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"----------------------",exitSpacing}");
            Console.WriteLine($"{"|                    |",exitSpacing}");
            Console.WriteLine($"{"|------- EXIT -------|",exitSpacing}");
            Console.WriteLine($"{"|                    |",exitSpacing}");
            Console.WriteLine($"{"----------------------",exitSpacing}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"Press E or e to Exit ",exitSpacing}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
