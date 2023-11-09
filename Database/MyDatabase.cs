using System;
using System.Collections.Generic;

namespace CodingCamp
{
    public class MyDatabase
    {
        // Properties of MyDatabase
        public List<Course> Courses { get; set; } = new List<Course>();

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        //Constructor for Synthetic Data
        public MyDatabase()
        {
            #region Seeding Courses
            //================== Seeding Courses ==================

            Course c1 = new Course()
            {
                CourseId = 1,
                Title = "C#",
                Type = Type.PartTime,
                StartDate = new DateTime(2023, 9, 1),       //starts at 01-Sep-2023
                EndDate = new DateTime(2024, 3, 31)         //ends   at 31-Mar-2024
            };

            Course c2 = new Course()
            {
                CourseId = 2,
                Title = "Python",
                Type = Type.FullTime,
                StartDate = new DateTime(2023, 9, 1),       //starts at 01-Sep-2023
                EndDate = new DateTime(2023, 12, 31)        //ends   at 31-Dec-2023
            };
            Course c3 = new Course()
            {
                CourseId = 3,
                Title = "JavaScript",
                Type = Type.PartTime,
                StartDate = new DateTime(2023, 9, 1),       //starts at 01-Sep-2023
                EndDate = new DateTime(2024, 3, 31)         //ends   at 31-Mar-2024
            };
            #endregion

            #region Seeding Trainers
            //================== Seeding Trainers ==================

            Trainer t1 = new Trainer()
            {
                TrainerId = 1,
                FirstName = "Labros",
                LastName = "Papadimitriou"
            };
            t1.Courses = c1;
            c1.Trainers.Add(t1);

            Trainer t2 = new Trainer()
            {
                TrainerId = 2,
                FirstName = "Kiki",
                LastName = "Tasiopoulou"
            };

            t2.Courses = c1;
            c1.Trainers.Add(t2);

            Trainer t3 = new Trainer()
            {
                TrainerId = 3,
                FirstName = "Panos",
                LastName = "Sakelarios"
            };

            t3.Courses = c2;
            c2.Trainers.Add(t3);

            Trainer t4 = new Trainer()
            {
                TrainerId = 4,
                FirstName = "Georgia",
                LastName = "Giannakopoulou"
            };

            t4.Courses = c3;
            c3.Trainers.Add(t4);
            #endregion

            #region Seeding Students
            //================== Seeding Students ==================

            Student s1 = new Student()
            {
                StudentId = 1,
                FirstName = "Christos",
                LastName = "Antoniou",
                DateOfBirth = new DateTime(1995, 3, 23),
                TuitionFees = 2500
            };
            s1.Courses = new List<Course>() { c1 };
            c1.Students.Add(s1);

            Student s2 = new Student()
            {
                StudentId = 2,
                FirstName = "Marios",
                LastName = "Ioannidis",
                DateOfBirth = new DateTime(1994, 4, 22),
                TuitionFees = 2500
            };
            s2.Courses = new List<Course>() { c1 };
            c1.Students.Add(s2);

            Student s3 = new Student()
            {
                StudentId = 3,
                FirstName = "Grigoris",
                LastName = "Papaioannou",
                DateOfBirth = new DateTime(1997, 9, 10),
                TuitionFees = 2300
            };
            s2.Courses = new List<Course>() { c2 };
            c2.Students.Add(s3);

            Student s4 = new Student()
            {
                StudentId = 4,
                FirstName = "Stamatios",
                LastName = "Iordanou",
                DateOfBirth = new DateTime(1990, 7, 9),
                TuitionFees = 2300
            };
            s4.Courses = new List<Course>() { c2 };
            c2.Students.Add(s4);

            Student s5 = new Student()
            {
                StudentId = 5,
                FirstName = "Alex",
                LastName = "Katsaros",
                DateOfBirth = new DateTime(1996, 6, 18),
                TuitionFees = 1900
            };
            s5.Courses = new List<Course>() { c3 };
            c3.Students.Add(s5);

            Student s6 = new Student()
            {
                StudentId = 6,
                FirstName = "Vasia",
                LastName = "Kontou",
                DateOfBirth = new DateTime(2000, 11, 15),
                TuitionFees = 4000
            };
            s6.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s6);
            c3.Students.Add(s6);

            Student s7 = new Student()
            {
                StudentId = 7,
                FirstName = "Pavlos",
                LastName = "Dimitriou",
                DateOfBirth = new DateTime(1999, 12, 10),
                TuitionFees = 1900
            };
            s7.Courses = new List<Course>() { c3 };
            c3.Students.Add(s7);

            Student s8 = new Student()
            {
                StudentId = 8,
                FirstName = "Martha",
                LastName = "Georgiou",
                DateOfBirth = new DateTime(1993, 8, 21),
                TuitionFees = 2300
            };
            s8.Courses = new List<Course>() { c2 };
            c2.Students.Add(s8);

            Student s9 = new Student()
            {
                StudentId = 9,
                FirstName = "Theofilos",
                LastName = "Raptis",
                DateOfBirth = new DateTime(2001, 5, 4),
                TuitionFees = 4000
            };
            s9.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s9);
            c3.Students.Add(s9);

            Student s10 = new Student()
            {
                StudentId = 10,
                FirstName = "Valentina",
                LastName = "Papageorgiou",
                DateOfBirth = new DateTime(2002, 6, 29),
                TuitionFees = 4000
            };
            s10.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s10);
            c3.Students.Add(s10);
            #endregion

            #region Seeding Assignments
            //================== Seeding Assignments ==================

            Assignment a1 = new Assignment()
            {
                AssignmentId = 1,
                Title = "Addition_C#",
                Description = "Add 2 Numbers",
                OralMark = 40,
                TotalMark = 100
            };
            a1.Courses = c1;
            c1.Assignments.Add(a1);

            Assignment a2 = new Assignment()
            {
                AssignmentId = 2,
                Title = "Substract_C#",
                Description = "Substract 2 Numbers",
                OralMark = 60,
                TotalMark = 100
            };
            a2.Courses = c1;
            c1.Assignments.Add(a2);

            Assignment a3 = new Assignment()
            {
                AssignmentId = 3,
                Title = "Multiply_C#",
                Description = "Multiply 2 Numbers",
                OralMark = 40,
                TotalMark = 100
            };
            a3.Courses = c1;
            c1.Assignments.Add(a3);

            Assignment a4 = new Assignment()
            {
                AssignmentId = 4,
                Title = "Division_C#",
                Description = "Divide 2 Numbers",
                OralMark = 60,
                TotalMark = 100
            };
            a4.Courses = c1;
            c1.Assignments.Add(a4);

            Assignment a5 = new Assignment()
            {
                AssignmentId = 5,
                Title = "Power_Python",
                Description = "Find Power of 111",
                OralMark = 40,
                TotalMark = 100
            };
            a5.Courses = c2;
            c2.Assignments.Add(a5);

            Assignment a6 = new Assignment()
            {
                AssignmentId = 6,
                Title = "Square_Python",
                Description = "Find Square of 10",
                OralMark = 60,
                TotalMark = 100
            };
            a6.Courses = c2;
            c2.Assignments.Add(a6);

            Assignment a7 = new Assignment()
            {
                AssignmentId = 7,
                Title = "Addition_Python",
                Description = "Add 3 Numbers",
                OralMark = 40,
                TotalMark = 100
            };
            a7.Courses = c2;
            c2.Assignments.Add(a7);

            Assignment a8 = new Assignment()
            {
                AssignmentId = 8,
                Title = "Substract_Python",
                Description = "Substract 3 Numbers",
                OralMark = 60,
                TotalMark = 100
            };
            a8.Courses = c2;
            c2.Assignments.Add(a8);

            Assignment a9 = new Assignment()
            {
                AssignmentId = 9,
                Title = "Multiply_JavaScript",
                Description = "Multiply 3 Numbers",
                OralMark = 40,
                TotalMark = 100
            };
            a9.Courses = c3;
            c3.Assignments.Add(a9);

            Assignment a10 = new Assignment()
            {
                AssignmentId = 10,
                Title = "Division_JavaScript",
                Description = "Divide 3 Numbers",
                OralMark = 60,
                TotalMark = 100
            };
            a10.Courses = c3;
            c3.Assignments.Add(a10);

            Assignment a11 = new Assignment()
            {
                AssignmentId = 11,
                Title = "Power_JavaScript",
                Description = "Find Power of 222",
                OralMark = 40,
                TotalMark = 100
            };
            a11.Courses = c3;
            c3.Assignments.Add(a11);

            Assignment a12 = new Assignment()
            {
                AssignmentId = 12,
                Title = "Square_JavaScript",
                Description = "Find Square of 15",
                OralMark = 60,
                TotalMark = 100
            };
            a12.Courses = c3;
            c3.Assignments.Add(a12);
            #endregion

            #region Add Assignments to Students
            s1.Assignments.Add(a1);
            s1.Assignments.Add(a2);
            s1.Assignments.Add(a3);
            s1.Assignments.Add(a4);

            s2.Assignments.Add(a1);
            s2.Assignments.Add(a2);
            s2.Assignments.Add(a3);
            s2.Assignments.Add(a4);

            s3.Assignments.Add(a5);
            s3.Assignments.Add(a6);
            s3.Assignments.Add(a7);
            s3.Assignments.Add(a8);

            s4.Assignments.Add(a5);
            s4.Assignments.Add(a6);
            s4.Assignments.Add(a7);
            s4.Assignments.Add(a8);

            s5.Assignments.Add(a9);
            s5.Assignments.Add(a10);
            s5.Assignments.Add(a11);
            s5.Assignments.Add(a12);

            s6.Assignments.Add(a1);
            s6.Assignments.Add(a2);
            s6.Assignments.Add(a3);
            s6.Assignments.Add(a9);
            s6.Assignments.Add(a11);

            s7.Assignments.Add(a9);
            s7.Assignments.Add(a10);
            s7.Assignments.Add(a11);
            s7.Assignments.Add(a12);

            s8.Assignments.Add(a5);
            s8.Assignments.Add(a6);
            s8.Assignments.Add(a7);
            s8.Assignments.Add(a8);

            s9.Assignments.Add(a1);
            s9.Assignments.Add(a2);
            s9.Assignments.Add(a4);
            s9.Assignments.Add(a10);
            s9.Assignments.Add(a12);

            s10.Assignments.Add(a1);
            s10.Assignments.Add(a2);
            s10.Assignments.Add(a3);
            s10.Assignments.Add(a10);
            s10.Assignments.Add(a11);
            s10.Assignments.Add(a12);
            #endregion

            #region Populate Lists of MyDatabase
            List<Course> courses = new List<Course>() { c1, c2, c3 };   //populate SyntheticData inside a temporary list
            Courses.AddRange(courses);                                  //store the temp list to the final

            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4 };
            Trainers.AddRange(trainers);

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            Students.AddRange(students);

            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12 };
            Assignments.AddRange(assignments);
            #endregion
        }





    }










}
