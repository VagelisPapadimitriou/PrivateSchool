using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace CodingCamp
{
    public class Validation
    {
        public static void ErrorResultChoice(string userChoice)
        {
            if (!Regex.IsMatch(userChoice, @"^[Bb1-9]$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine($"{"--> Wrong Choice - Choose Again <--",51}");
                Console.WriteLine($"{"|",34}");
                Console.WriteLine($"{"V",34}");
                Console.ResetColor();
            }
        }
        public static void InputCheckResultMenu(string input)
        {
            if (Regex.IsMatch(input, @"^[Bb1-9]$"))
            {
                Console.Beep(1500, 80);
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(100);
        }

        public static void ErrorCreateChoice(string userChoice)
        {
            if (!Regex.IsMatch(userChoice, @"^[Bb1-8]$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine($"{"--> Wrong Choice - Choose Again <--",51}");
                Console.WriteLine($"{"|",34}");
                Console.WriteLine($"{"V",34}");
                Console.ResetColor();
            }
        }
        public static void InputCheckCreateMenu(string input)
        {
            if (Regex.IsMatch(input, @"^[Bb1-8]$"))
            {
                Console.Beep(1500, 80);
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(100);
        }

        public static void ErrorMainMenuChoice(string userChoice)
        {
            if (!Regex.IsMatch(userChoice, @"^[Ee1-2]$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine($"{"--> Wrong Choice - Choose Again <--",51}");
                Console.ResetColor();
            }
        }

        public static void InputCheckMainMenu(string input)
        {
            if (Regex.IsMatch(input, @"^[Ee1-2]$"))
            {
                Console.Beep(1500, 80);
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(100);
        }


    }
}
