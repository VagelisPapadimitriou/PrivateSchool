using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CodingCamp.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }

        //Navigation Properties

        public List<Course> Courses { get; set; } = new List<Course>();

        //Methods

        public void Print()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}{DateOfBirth.ToString("dd-MMM-yyyy"),-15}{TuitionFees,-15:C}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }
    }



}
