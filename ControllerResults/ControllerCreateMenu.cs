using System;

namespace CodingCamp
{
    public class ControllerCreateMenu
    {
        public static void ExecuteControllerCreateMenu(string userChoice)
        {
            switch (userChoice)
            {
                case "1": Console.WriteLine("1 - Create new Course"); ; break;
                case "2": Console.WriteLine("2 - Create new Trainer"); ; break;
                case "3": Console.WriteLine("3 - Match Trainers per Course"); ; break;
                case "4": Console.WriteLine("4 - Create new Student"); ; break;
                case "5": Console.WriteLine("5 - Match Students per Course"); ; break;
                case "6": Console.WriteLine("6 - Match Assignments per Student"); ; break;
                case "7": Console.WriteLine("7 - Create new Assignment"); ; break;
                case "8": Console.WriteLine("8 - Match Assignments per Course"); ; break;
                
                default: Validation.ErrorCreateChoice(userChoice); break;
            }
        }
    }
}