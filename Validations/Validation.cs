using CodingCamp.Database;
using CodingCamp.Entities;
using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace CodingCamp.Validations
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
        public static bool InputCheckName(string input)
        {
            return !Regex.IsMatch(input, @"^[A-Z][a-zA-z]{2,}$");
        }
        public static bool InputCheckTuitionFees(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]+$");
        }
        public static bool InputCheckMarks(string input)
        {
            return Regex.IsMatch(input, @"^(?:100|\d{1,2})$");
        }

        //public static void IsValidId(MyDatabase db, string userChoice)
        //{

        //    db.Any(db => db.) == userChoice)
        //}


    }
}
