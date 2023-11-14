using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodingCamp.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CodingCamp.Enums.Type Type { get; set; }

        //Navigation Properties

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        //Methods

        public void PrintPairingData()
        {
            Console.WriteLine($"{CourseId,-7}{Title,-15}{StartDate.ToString("dd-MMM-yyyy"),-15}{EndDate.ToString("dd-MMM-yyyy"),-15}{Type,-15}");
        }

        public void Print()
        {
            Console.WriteLine($"{Title,-15}{StartDate.ToString("dd-MMM-yyyy"),-15}{EndDate.ToString("dd-MMM-yyyy"),-15}{Type,-15}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-15}");
        }



    }
}
