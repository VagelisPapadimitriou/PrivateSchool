using System;

namespace CodingCamp.Views.Menus
{
    public class ResultMenu
    {
        public static void PrintResultMenu()
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
            Console.WriteLine($"{"1 - All Courses",spacing}{"4 - All Students"}");
            Console.WriteLine($"{"",spacing}{"5 - All Students per Course"}");
            Console.WriteLine($"{"",spacing}{"6 - All Assignments per Student"}");
            Console.Write($"{"",spacing}{"7 - Students that belong to\n\t\t\t\t\t more than one course"}");
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{"----------- TRAINERS ----------",spacing}");
            Console.WriteLine($"{"----------- ASSIGNMENTS -----------"}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"2 - All Trainers",spacing}{"8 - All Assignments"}");
            Console.WriteLine($"{"3 - All Trainers per Course",spacing}{"9 - All Assignments per Course"}");
            Console.WriteLine("\n");

            //Back
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"----------------------",exitSpacing}");
            Console.WriteLine($"{"|                    |",exitSpacing}");
            Console.WriteLine($"{"|------- BACK -------|",exitSpacing}");
            Console.WriteLine($"{"|                    |",exitSpacing}");
            Console.WriteLine($"{"----------------------",exitSpacing}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"Press B or b to GoBack ",exitSpacing+1}");
            Console.ResetColor();

        }
    }





}
