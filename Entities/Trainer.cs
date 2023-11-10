using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CodingCamp
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties

        public Course Courses { get; set; }

        //Methods

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }
    }



}
