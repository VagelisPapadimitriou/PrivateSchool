using CodingCamp.Database;
using CodingCamp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp.Controllers.UserInputs
{
    public class CourseInputHelper
    {
        public static void CourseInput(MyDatabase db)
        {
            int inputNextId = db.Courses.Last().CourseId + 1;
            string inputTitle = UserInputCourseTitle();
            CodingCamp.Enums.Type courseType = UserInputCourseType();
            DateTime inputStartDate = UserInputStartDate();
            DateTime inputEndDate = UserInputEndDate(inputStartDate);

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

        private static string UserInputCourseTitle()
        {
            string inputTitle;
            do
            {
                Console.Write("Course Title: ");
                inputTitle = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(inputTitle));
            return inputTitle;
        }
        private static CodingCamp.Enums.Type UserInputCourseType()
        {
            CodingCamp.Enums.Type courseType;
            string inputType;
            do
            {
                Console.Write("Course Type (FullTime/PartTime): ");
                inputType = Console.ReadLine();

            } while (inputType != "FullTime" && inputType != "PartTime");
            Enum.TryParse(inputType, out courseType);
            return courseType;
        }
        private static DateTime UserInputStartDate()
        {
            DateTime inputStartDate;
            bool isValidStartDate = false;
            do
            {
                Console.Write("Enter the Start date (e.g. 2023/10/22): ");
                string userInput = Console.ReadLine();

                if (DateTime.TryParse(userInput, out inputStartDate))
                {
                    isValidStartDate = true;
                }
            } while (!isValidStartDate);
            return inputStartDate;
        }
        private static DateTime UserInputEndDate(DateTime inputStartDate)
        {
            DateTime inputEndDate;
            bool isValidEndDate = false;
            do
            {
                Console.Write("Enter the End date (e.g. 2024/04/22): ");
                string userInput = Console.ReadLine();

                if (DateTime.TryParse(userInput, out inputEndDate) && inputStartDate < inputEndDate)
                {
                    isValidEndDate = true;
                }

            } while (!isValidEndDate);
            return inputEndDate;
        }
    }
}
