using System;
using System.Collections.Generic;

namespace CodingCamp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }

        //Navigation Properties

        public List<Course> Courses { get; set; }

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
    }



}
