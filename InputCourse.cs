using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp
{
    public class InputCourse
    {
        public static void CourseInput(MyDatabase db)
        {
            string inputTitle;
            string inputType;
            DateTime inputStartDate;
            bool isValidStartDate = false;
            DateTime inputEndDate;
            bool isValidEndDate = false;
            int inputNextId;

            //Id Input
            inputNextId = db.Courses.Max(x => x.CourseId) + 1;

            //Title Input
            do
            {
                Console.Write("Course Title: ");
                inputTitle = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(inputTitle));
            //Type Input
            do
            {
                Console.Write("Course Type (FullTime/PartTime): ");
                inputType = Console.ReadLine();

            } while (inputType != "FullTime" && inputType != "PartTime");
            Enum.TryParse(inputType, out Type courseType);
            //Start Date Input
            do
            {
                Console.Write("Enter the Start date (e.g. 2023/10/22): ");
                string userInput = Console.ReadLine();

                if (DateTime.TryParse(userInput, out inputStartDate))
                {
                    isValidStartDate = true;
                }
            } while (!isValidStartDate);
            //End Date Input
            do
            {
                Console.Write("Enter the End date (e.g. 2024/04/22): ");
                string userInput = Console.ReadLine();

                if (DateTime.TryParse(userInput, out inputEndDate) && inputStartDate < inputEndDate)
                {
                    isValidEndDate = true;
                }

            } while (!isValidEndDate);

            Course courseInput = new Course()
            {
                CourseId = inputNextId,
                Title = inputTitle,
                Type = courseType,
                StartDate = inputStartDate,
                EndDate = inputEndDate
            };

            db.Courses.Add(courseInput);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"---Course added successfully!---",50}\n");
            Console.ResetColor();
        }
   }
}
