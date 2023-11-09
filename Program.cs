using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CodingCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int firstSpacing = -37;
            const int secondSpacing = -44;
            const int exitfirstSpacing = 72;
            const int optionfirstSpacing = 46;
            string input;

            do
            {
                //Choose an Option Message
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"--> CHOOSE AN OPTION <--",optionfirstSpacing}");
                Console.WriteLine();
                Console.ResetColor();

                //Choices
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{"----------- COURSES -----------",firstSpacing}");
                Console.WriteLine($"{"------------- STUDENTS ------------"}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{"1 - All Courses",firstSpacing}{"4 - All Students"}");
                Console.WriteLine($"{"",firstSpacing}{"5 - All Students per Course",secondSpacing}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{"",firstSpacing}{"6 - All Assignments per Student",secondSpacing}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{"",firstSpacing}{"7 - Students that belong to\n\t\t\t\t\t more than one course",secondSpacing}");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{"----------- TRAINERS ----------",firstSpacing}");
                Console.WriteLine($"{"----------- ASSIGNMENTS -----------"}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{"2 - All Trainers",firstSpacing}{"8 - All Assignments"}");
                Console.WriteLine($"{"3 - All Trainers per Course",firstSpacing}{"9 - All Assignments per Course"}");
                Console.WriteLine();
                Console.WriteLine();

                //Exit
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{"----------------------",exitfirstSpacing}");
                Console.WriteLine($"{"|                    |",exitfirstSpacing}");
                Console.WriteLine($"{"|------- EXIT -------|",exitfirstSpacing}");
                Console.WriteLine($"{"|                    |",exitfirstSpacing}");
                Console.WriteLine($"{"----------------------",exitfirstSpacing}");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{"Press E or e to Exit ",exitfirstSpacing}");
                Console.ResetColor();

                //Option
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("---------------------");
                Console.Write("Option: ");
                input = Console.ReadLine();
                Console.WriteLine("---------------------");
                Console.ResetColor();

                if (Regex.IsMatch(input, @"^[Ee1-9]$"))
                {
                    Console.Beep(1500, 80);
                }
                else
                {
                    Console.Beep();
                }
                Thread.Sleep(100);
                Console.Clear();


























            } while (input != "E" && input != "e");

        }
    }










}
