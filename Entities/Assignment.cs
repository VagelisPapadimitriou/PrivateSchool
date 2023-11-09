namespace CodingCamp
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

    }



}
