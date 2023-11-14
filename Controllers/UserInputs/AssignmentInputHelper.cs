using CodingCamp.Database;
using CodingCamp.Entities;
using CodingCamp.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp.Controllers.UserInputs
{
    internal class AssignmentInputHelper
    {
        public static void AssignmentInput(MyDatabase db)
        {
            int AssignmentNextId = db.Assignments.Last().AssignmentId + 1;

            string inputAssignmentTitle = UserInputAssignmentTitle();
            string inputAssignmentDescription = UserInputAssignmentDescription();
            double inputAssignmentOralMark = UserInputAssignmentOralMark();
            double inputAssignmentTotalMark = UserInputAssignmentTotalMark();

            Assignment assignmentInput = new Assignment()
            {
                AssignmentId = AssignmentNextId,
                Title = inputAssignmentTitle,
                Description = inputAssignmentDescription,
                OralMark = inputAssignmentOralMark,
                TotalMark = inputAssignmentTotalMark
            };

            db.Assignments.Add(assignmentInput);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"---Assignment added successfully!---",50}\n");
            Console.ResetColor();
        }

        private static string UserInputAssignmentTitle()
        {
            string inputTitle;
            do
            {
                Console.Write("Assignment Title: ");
                inputTitle = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(inputTitle));
            return inputTitle;
        }
        private static string UserInputAssignmentDescription()
        {
            string inputDescription;
            do
            {
                Console.Write("Assignment Description: ");
                inputDescription = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(inputDescription));
            return inputDescription;
        }    
        private static double UserInputAssignmentOralMark()
        {
            string userInputMark;
            do
            {
                Console.Write("Oral Mark: ");
                userInputMark = Console.ReadLine();
            } while (!Validation.InputCheckMarks(userInputMark));

            return Convert.ToDouble(userInputMark);
        }
        private static double UserInputAssignmentTotalMark()
        {
            string userInputMark;
            do
            {
                Console.Write("Total Mark: ");
                userInputMark = Console.ReadLine();
            } while (!Validation.InputCheckMarks(userInputMark));

            return Convert.ToDouble(userInputMark);
        }
    }
}

