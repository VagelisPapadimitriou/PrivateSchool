using CodingCamp.Database;
using CodingCamp.Entities;
using CodingCamp.Validations;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodingCamp.Controllers.UserInputs
{
    public class TrainerInputHelper
    {
        public static void TrainerInput(MyDatabase db)
        {
            int inputNextId = db.Trainers.Last().TrainerId + 1;
            string inputTrainerFirstName = UserInputTrainerFirstName();
            string inputTrainerLastName = UserInputTrainerLastName();

            Trainer trainerInput = new Trainer()
            {
                TrainerId = inputNextId,
                FirstName = inputTrainerFirstName,
                LastName = inputTrainerLastName
            };

            db.Trainers.Add(trainerInput);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"---Trainer added successfully!---",50}\n");
            Console.ResetColor();
        }

        private static string UserInputTrainerFirstName()
        {
            string inputTrainerFirstName;
            do
            {
                Console.Write("First Name: ");
                inputTrainerFirstName = Console.ReadLine();

            } while (Validation.InputCheckName(inputTrainerFirstName));
            return inputTrainerFirstName;
        }
        private static string UserInputTrainerLastName()
        {
            string inputTrainerLastName;
            do
            {
                Console.Write("Last Name: ");
                inputTrainerLastName = Console.ReadLine();

            } while (Validation.InputCheckName(inputTrainerLastName));
            return inputTrainerLastName;
        }
    }
}
