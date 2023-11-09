using System.Collections.Generic;

namespace CodingCamp
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties

        public Course Courses { get; set; }

    }



}
