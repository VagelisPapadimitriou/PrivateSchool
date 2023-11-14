using System;

namespace CodingCamp.Views.Menus
{
    public class CreateMenu
    {
        public static void PrintCreateMenu()
        {
            const int spacing = -37;
            const int exitSpacing = 45;
            const int optionSpacing = 46;

            //Choose an Option Message
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"--> CHOOSE AN OPTION <--",optionSpacing}");
            Console.WriteLine();
            Console.ResetColor();

            //Choices
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{"----------- COURSES -----------",spacing}");
            Console.WriteLine($"{"------------- STUDENTS ------------"}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"1 - Create new Course",spacing}{"4 - Create new Student"}");
            Console.WriteLine($"{"",spacing}{"5 - Match Students per Course"}");
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{"----------- TRAINERS ----------",spacing}");
            Console.WriteLine($"{"----------- ASSIGNMENTS -----------"}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"2 - Create new Trainer",spacing}{"6 - Create new Assignment"}");
            Console.WriteLine($"{"3 - Match Trainers per Course",spacing}{"7 - Match Assignments per Course"}");
            Console.WriteLine("\n");

            //Back
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"----------------------",exitSpacing}");
            Console.WriteLine($"{"|                    |",exitSpacing}");
            Console.WriteLine($"{"|------- BACK -------|",exitSpacing}");
            Console.WriteLine($"{"|                    |",exitSpacing}");
            Console.WriteLine($"{"----------------------",exitSpacing}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"Press B or b to GoBack ",exitSpacing + 1}");
            Console.ResetColor();
        }
    }
}
