using CodingCamp.Database;
using CodingCamp.Entities;
using CodingCamp.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp.Controllers.UserInputs
{
    internal class AssignmentsPerCourseHelper
    {
        public static void MatchAssignmentsPerCourse(MyDatabase db)
        {
            int userChoiceAssignmentId = UserInputAssignmentId(db);
            int userChoiceCourseId = UserInputCourseId(db, userChoiceAssignmentId);

            Assignment selectedAssignment = db.Assignments.Find(x => x.AssignmentId == userChoiceAssignmentId);
            Course selectedCourse = db.Courses.Find(x => x.CourseId == userChoiceCourseId);

            if (!selectedCourse.Assignments.Contains(selectedAssignment))
            {
            selectedCourse.Assignments.Add(selectedAssignment);
            }

            PrintMatchMessage(selectedCourse, selectedAssignment);

            Aesthetic.HideTheMainMenu.ExecuteHideTheMenu();
        }

        public static void PrintCourseData(MyDatabase db, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,25}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-7}{"Course",-15}");
            Console.ResetColor();
            foreach (var course in db.Courses)
            {
                course.PrintLessPairingData();
            }
        }
        public static int UserInputCourseId(MyDatabase db, int userChoiceAssignmentId)
        {
            string userChoice;
            int idToFind;
            bool idExists;
            do
            {
                Console.Clear();
                PrintAssignmentIdChoice(db, userChoiceAssignmentId);
                PrintCourseData(db, "Data of all Courses");

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------");
                Console.Write("Id: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("-----------");
                Console.ResetColor();
                Console.Clear();

                if (Int32.TryParse(userChoice, out idToFind))
                {
                    idExists = db.Courses.Any(co => co.CourseId == idToFind);
                }
                else
                {
                    idExists = false;
                }
            } while (!idExists);

            PrintAssignmentIdChoice(db, idToFind);

            PrintCourseData(db, "Data of all Courses");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + idToFind + "\n");
            Console.ResetColor();

            return idToFind;
        }
        private static void PrintAssignmentIdChoice(MyDatabase db, int userChoiceAssignmentId)
        {
            PrintAssignmentData(db, "Data of all Assignments");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + userChoiceAssignmentId + "\n");
            Console.ResetColor();
        }
        public static void PrintAssignmentData(MyDatabase db, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,29}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-7}{"Title",-25}{"Description"}");
            Console.ResetColor();
            foreach (var assignment in db.Assignments)
            {
                assignment.PrintPairingData();
            }
        }
        public static int UserInputAssignmentId(MyDatabase db)
        {
            string userChoice;
            int idToFind;
            bool idExists;
            do
            {

                PrintAssignmentData(db, "Data of all Assignments");

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------");
                Console.Write("Id: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("-----------");
                Console.ResetColor();
                Console.Clear();

                if (Int32.TryParse(userChoice, out idToFind))
                {
                    idExists = db.Assignments.Any(ass => ass.AssignmentId == idToFind);
                }
                else
                {
                    idExists = false;
                }
            } while (!idExists);


            

            PrintAssignmentData(db, "Data of all Assignments");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + idToFind + "\n");
            Console.ResetColor();

            return idToFind;
        }
        private static void PrintMatchMessage(Course selectedCourse, Assignment selectedAssignment)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Assignment ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{selectedAssignment.Title}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" added to course ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{selectedCourse.Title}.");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
