using System;
using System.Collections.Generic;

namespace CodingCamp
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Type Type { get; set; }

        //Navigation Properties

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();



        

    }
}
