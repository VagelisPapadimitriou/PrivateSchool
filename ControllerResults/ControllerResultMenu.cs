namespace CodingCamp
{
    public class ControllerResultMenu
    {
        public static void ExecuteControllerResultMenu(MyDatabase db, string userChoice)
        {
            switch (userChoice)
            {
                case "1": View.Courses(db.Courses, "All Courses"); break;
                case "2": View.Trainers(db.Trainers, "All Trainers"); break;
                case "3": View.TrainersPerCourse(db.Courses, "All Trainers per Course"); break;
                case "4": View.Students(db.Students, "All Students"); break;
                case "5": View.StudentsPerCourse(db.Courses, "All Students per Course"); break;
                case "6": View.AssignmentsPerStudent(db.Students, "All Assignments per Student"); break;
                case "7": View.StudentsManyCourses(db.Students, "Students with more than one course"); break;
                case "8": View.Assignments(db.Assignments, "All Assignments"); break;
                case "9": View.AssignmentsPerCourse(db.Courses, "All Assignments per Course"); break;
                default: Validation.ErrorResultChoice(userChoice); break;
            }
        }
    }

}
