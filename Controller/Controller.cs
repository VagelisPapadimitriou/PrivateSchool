﻿using System;

namespace CodingCamp
{
    public class Controller
    {
        public static void MainMenu(MyDatabase db, string userChoice)
        {
            switch (userChoice)
            {
                case "1": Console.Clear(); Application.ExecuteImports(db); break;
                case "2": Console.Clear(); Application.ExecuteResults(db); break;

                default: Validation.ErrorMainMenuChoice(userChoice); break;
            }
        }

        public static void CreateMenu(MyDatabase db, string userChoice)
        {
            switch (userChoice)
            {
                case "1": InputCourse.CourseInput(db) ; break;
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

        public static void ResultMenu(MyDatabase db, string userChoice)
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
                default: Validation.ErrorResultChoice(userChoice); break;
            }
        }
    }
}