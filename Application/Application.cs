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
            const string NumberChoices = @"^[1-9]$";

            do
            {
                View.Menu();

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("---------------------");
                Console.Write("Option: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("---------------------");
                Console.ResetColor();
                View.InputCheck(userChoice);
                Console.Clear();
                
                Controller(db, userChoice);

                //Hide the Menu after a choice
                if (Regex.IsMatch(userChoice, NumberChoices))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Press any key to show the menu again...");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                }
            } while (userChoice != "E" && userChoice != "e");
        }

        private static void Controller(MyDatabase db, string userChoice)
        {
            switch (userChoice)
            {
                case "1": View.Courses(db.Courses, "All Courses"); break;
                case "2": View.Trainers(db.Trainers, "All Trainers"); break;
                case "3": View.TrainersPerCourse(db.Courses, "All Trainers per Course"); break;
                case "4": View.Students(db.Students, "All Students"); break;
                case "5": View.StudentsPerCourse(db.Courses, "All Students per Course"); break;
                case "6": View.AssignmentsPerStudent(db.Students, "All Assignments per Student"); break;
                case "7": View.StudentsManyCourses(db.Students, "Students with more than one course"); break;
                case "8": View.Assignments(db.Assignments, "All Assignments"); break;
                case "9": View.AssignmentsPerCourse(db.Courses, "All Assignments per Course"); break;
                default: View.Error(userChoice); break;
            }
        }
    }

}
