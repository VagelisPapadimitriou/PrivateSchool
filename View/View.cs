using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace CodingCamp
{
    public class View
    {
        const string AllValidChoices = @"^[Ee1-9]$";

        public static void Courses(List<Course> courses, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,35}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"Title",-15}{"StartDate",-15}{"EndDate",-15}{"Type",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.Write($"{indexCounter++,-7}");
                course.Print();
            }
        }
        public static void Trainers(List<Trainer> trainers, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,23}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.Write($"{indexCounter++,-7}");
                trainer.PrintName();
            }
        }
        public static void Students(List<Student> students, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,35}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"FirstName",-15}{"LastName",-15}{"DateOfBirth",-15}{"TuitionFees",-15}");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.Write($"{indexCounter++,-7}");
                student.Print();
            }
        }
        public static void Assignments(List<Assignment> assignments, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,45}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"Title",-25}{"Description",-25}{"OralMark",-15}{"TotalMark",-15}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.Write($"{indexCounter++,-7}");
                assignment.Print();
            }
        }
        public static void TrainersPerCourse(List<Course> courses, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,35}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"Course",-15}{"Trainer FullName",20}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.Write($"{indexCounter++,-7}");
                course.PrintTitle();
                foreach (var trainer in course.Trainers)
                {
                    Console.Write($"{"",-22}");
                    trainer.PrintName();
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public static void StudentsPerCourse(List<Course> courses, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,35}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"Course",-15}{"Student FullName",20}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.Write($"{indexCounter++,-7}");
                course.PrintTitle();
                foreach (var student in course.Students)
                {
                    Console.Write($"{"",-22}");
                    student.PrintName();
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public static void StudentsManyCourses(List<Student> students, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,40}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"FirstName",-15}{"LastName",-15}{"Course",-15}");
            Console.ResetColor();

            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.Write($"{indexCounter++,-7}");
                    student.PrintName();
                    foreach (var course in student.Courses)
                    {
                        Console.Write($"{"",-37}");
                        course.PrintTitle();
                    }
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public static void AssignmentsPerStudent(List<Student> students, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,35}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"Student FullName",20}{"Assignment Title",25}");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.Write($"{indexCounter++,-7}");
                student.PrintName();
                foreach (var assignment in student.Assignments)
                {
                    Console.Write($"{"",-38}");
                    assignment.PrintTitle();
                }
            }
            Console.WriteLine("---------------------------------------------------------");
        }
        public static void AssignmentsPerCourse(List<Course> courses, string message)
        {
            int indexCounter = 1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,35}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Index",-7}{"Course",-15}{"Assignment Title",20}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.Write($"{indexCounter++,-7}");
                course.PrintTitle();
                foreach (var assignment in course.Assignments)
                {
                    Console.Write($"{"",-28}");
                    assignment.PrintTitle();
                }
            }
            Console.WriteLine("-----------------------------------------------");
        }
        public static void Error(string userChoice)
        {
            if (!Regex.IsMatch(userChoice, AllValidChoices))
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine($"{"--> Wrong Choice - Choose Again <--",51}");
            Console.WriteLine($"{"|",34}");
            Console.WriteLine($"{"V",34}");
            Console.ResetColor();
            }
        }
        public static void InputCheck(string input)
        {
            if (Regex.IsMatch(input, AllValidChoices))
            {
                Console.Beep(1500, 80);
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(100);
        }
        public static void Menu()
        {
            const int Spacing = -37;
            const int exitSpacing = 72;
            const int optionSpacing = 46;

            //Choose an Option Message
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"--> CHOOSE AN OPTION <--",optionSpacing}");
            Console.WriteLine();
            Console.ResetColor();

            //Choices
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{"----------- COURSES -----------",Spacing}");
            Console.WriteLine($"{"------------- STUDENTS ------------"}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"1 - All Courses",Spacing}{"4 - All Students"}");
            Console.WriteLine($"{"",Spacing}{"5 - All Students per Course"}");
            Console.WriteLine($"{"",Spacing}{"6 - All Assignments per Student"}");
            Console.Write($"{"",Spacing}{"7 - Students that belong to\n\t\t\t\t\t more than one course"}");
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{"----------- TRAINERS ----------",Spacing}");
            Console.WriteLine($"{"----------- ASSIGNMENTS -----------"}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"2 - All Trainers",Spacing}{"8 - All Assignments"}");
            Console.WriteLine($"{"3 - All Trainers per Course",Spacing}{"9 - All Assignments per Course"}");
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

        }

    }







}
