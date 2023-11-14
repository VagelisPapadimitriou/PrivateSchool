using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CodingCamp.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties

        public Course Courses { get; set; }

        //Methods

        public void PrintPairingData()
        {
            Console.WriteLine($"{TrainerId,-7}{FirstName,-15}{LastName,-15}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }
    }



}
