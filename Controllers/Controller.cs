using CodingCamp.Controllers.UserInputs;
using CodingCamp.Database;
using CodingCamp.Validations;
using CodingCamp.Views;
using System;

namespace CodingCamp.Controllers
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
                case "1": CourseInputHelper.CourseInput(db); break;
                case "2": TrainerInputHelper.TrainerInput(db); break;
                case "3": TrainerPerCourseHelper.MatchTrainerPerCourse(db); break;
                case "4": StudentInputHelper.StudentInput(db); break;
                case "5": StudentsPerCourseHelper.MatchStudentsPerCourse(db); break;
                case "6": AssignmentInputHelper.AssignmentInput(db); break;
                case "7": AssignmentsPerCourseHelper.MatchAssignmentsPerCourse(db); break;

                default: Validation.ErrorCreateChoice(userChoice); break;
            }
        }

        public static void ResultMenu(MyDatabase db, string userChoice)
        {
            switch (userChoice)
            {
                case "1": Results.Courses(db.Courses, "All Courses"); break;
                case "2": Results.Trainers(db.Trainers, "All Trainers"); break;
                case "3": Results.TrainersPerCourse(db.Courses, "All Trainers per Course"); break;
                case "4": Results.Students(db.Students, "All Students"); break;
                case "5": Results.StudentsPerCourse(db.Courses, "All Students per Course"); break;
                case "6": Results.AssignmentsPerStudent(db.Students, "All Assignments per Student"); break;
                case "7": Results.StudentsManyCourses(db.Students, "Students with more than one course"); break;
                case "8": Results.Assignments(db.Assignments, "All Assignments"); break;
                case "9": Results.AssignmentsPerCourse(db.Courses, "All Assignments per Course"); break;
                default: Validation.ErrorResultChoice(userChoice); break;
            }
        }
    }
}