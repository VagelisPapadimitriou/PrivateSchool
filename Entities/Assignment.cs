using System;
using System.Runtime.InteropServices.ComTypes;

namespace CodingCamp.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }

        //Navigation Properties

        public Course Courses { get; set; }

        //Methods

        public void PrintPairingData()
        {
            Console.WriteLine($"{AssignmentId,-7}{Title,-25}{Description}");
        }

        public void Print()
        {
            Console.WriteLine($"{Title,-25}{Description,-25}{OralMark,-15}{TotalMark,-15}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-25}");
        }

    }



}
