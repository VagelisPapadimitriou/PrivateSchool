using CodingCamp.Entities;
using System;
using System.Collections.Generic;

namespace CodingCamp.Views
{
    public class Results
    {
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

                foreach (var course in student.Courses)
                {
                    foreach (var assignment in course.Assignments)
                    {
                        Console.Write($"{"",-38}");
                        assignment.PrintTitle();
                    }

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


    }

}
