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
    internal class StudentInputHelper
    {

        public static void StudentInput(MyDatabase db)
        {
            int StudentNextId = db.Students.Last().StudentId + 1;

            string inputStudentFirstName = UserInputStudentFirstName();
            string inputStudentLastName = UserInputStudentLastName();
            DateTime inputStudentDateOfBirth = UserInputStudentDateOfBirth();
            double inputStudentTuitionFees = UserInputStudentTuitionFees();

            Student studentInput = new Student()
            {
                StudentId = StudentNextId,
                FirstName = inputStudentFirstName,
                LastName = inputStudentLastName,
                DateOfBirth = inputStudentDateOfBirth,
                TuitionFees = inputStudentTuitionFees
            };

            db.Students.Add(studentInput);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"---Student added successfully!---",50}\n");
            Console.ResetColor();
        }

        private static string UserInputStudentFirstName()
        {
            string inputStudentFirstName;
            do
            {
                Console.Write("First Name: ");
                inputStudentFirstName = Console.ReadLine();

            } while (Validation.InputCheckName(inputStudentFirstName));
            return inputStudentFirstName;
        }
        private static string UserInputStudentLastName()
        {
            string inputStudentLastName;
            do
            {
                Console.Write("Last Name: ");
                inputStudentLastName = Console.ReadLine();

            } while (Validation.InputCheckName(inputStudentLastName));
            return inputStudentLastName;
        }
        private static DateTime UserInputStudentDateOfBirth()
        {
            DateTime inputStudentDateOfBirth;
            bool isValidBirthDate = false;
            do
            {
                Console.Write("Date of Birth (e.g. 2023/10/22): ");
                string userInput = Console.ReadLine();

                if (DateTime.TryParse(userInput, out inputStudentDateOfBirth))
                {
                    isValidBirthDate = true;
                }
            } while (!isValidBirthDate);
            return inputStudentDateOfBirth;
        }
        private static double UserInputStudentTuitionFees()
        {
            string userInput;
            do
            {
                Console.Write("Tuition Fees: ");
                userInput = Console.ReadLine();             
            } while (!Validation.InputCheckTuitionFees(userInput));

            return Convert.ToDouble(userInput);
        }
    }
}
