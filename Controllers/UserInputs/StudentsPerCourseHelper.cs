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
    internal class StudentsPerCourseHelper
    {
        public static void MatchStudentsPerCourse(MyDatabase db)
        {
            int userChoiceStudentId = UserInputStudentId(db);
            int userChoiceCourseId = UserInputCourseId(db, userChoiceStudentId);

            Student selectedStudent = db.Students.Find(x => x.StudentId == userChoiceStudentId);
            Course selectedCourse = db.Courses.Find(x => x.CourseId == userChoiceCourseId);

            if (!selectedCourse.Students.Contains(selectedStudent))
            {
                selectedCourse.Students.Add(selectedStudent);
                selectedStudent.Courses.Add(selectedCourse);
            }

            PrintMatchMessage(selectedStudent, selectedCourse);

            Aesthetic.HideTheMainMenu.ExecuteHideTheMenu();
        }

        public static void PrintStudentData(MyDatabase db, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,25}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-7}{"FirstName",-15}{"LastName",-18}{"Courses"}");
            Console.ResetColor();
            foreach (var student in db.Students)
            {
                Console.WriteLine("---------------------------------------------------");
                student.PrintPairingData();
                foreach (var course in student.Courses)
                {
                    Console.Write($"{"",40}");
                    course.PrintTitle();
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public static int UserInputStudentId(MyDatabase db)
        {
            string userChoice;
            int idToFind;
            bool idExists;
            do
            {
                PrintStudentData(db, "Data of all Students");

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
                    idExists = db.Students.Any(st => st.StudentId == idToFind);
                }
                else
                {
                    idExists = false;
                }
            } while (!idExists);

            PrintStudentIdChoice(db, idToFind);

            return idToFind;
        }
        private static void PrintStudentIdChoice(MyDatabase db, int userChoiceStudentId)
        {
            PrintStudentData(db, "Data of all Students");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + userChoiceStudentId + "\n");
            Console.ResetColor();
        }
        public static void PrintCourseData(MyDatabase db, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,24}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-7}{"Title",-15}{"StartDate",-15}{"EndDate",-15}{"Type",-15}");
            Console.ResetColor();
            foreach (var course in db.Courses)
            {
                course.PrintPairingData();
            }
        }
        public static int UserInputCourseId(MyDatabase db, int userChoiceStudentId)
        {
            string userChoice;
            int idToFind;
            bool idExists;
            do
            {
                Console.Clear();
                PrintStudentIdChoice(db, userChoiceStudentId);
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
                    idExists = db.Courses.Any(tr => tr.CourseId == idToFind);
                }
                else
                {
                    idExists = false;
                }
            } while (!idExists);


            PrintStudentIdChoice(db, userChoiceStudentId);

            PrintCourseData(db, "Data of all Courses");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + idToFind + "\n");
            Console.ResetColor();

            return idToFind;
        }
        private static void PrintMatchMessage(Student selectedStudent, Course selectedCourse)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Student ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{selectedStudent.FirstName} {selectedStudent.LastName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" assigned to course ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{selectedCourse.Title}.");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
