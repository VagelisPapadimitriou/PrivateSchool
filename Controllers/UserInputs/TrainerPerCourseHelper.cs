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
    internal class TrainerPerCourseHelper
    {
        public static void MatchTrainerPerCourse(MyDatabase db)
        {
            int userChoiceTrainerId = UserInputTrainerId(db);
            int userChoiceCourseId = UserInputCourseId(db, userChoiceTrainerId);

            Trainer selectedTrainer = db.Trainers.Find(x => x.TrainerId == userChoiceTrainerId);
            Course selectedCourse = db.Courses.Find(x => x.CourseId == userChoiceCourseId);

            selectedCourse.Trainers.Add(selectedTrainer);
            db.Courses.Find(x => x.Trainers.Remove(selectedTrainer));

            PrintMatchMessage(selectedTrainer, selectedCourse);

            Aesthetic.HideTheMainMenu.ExecuteHideTheMenu();
        }

        public static void PrintTrainerData(MyDatabase db, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,25}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-7}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var trainer in db.Trainers)
            {
                trainer.PrintPairingData();
            }
        }
        public static int UserInputTrainerId(MyDatabase db)
        {
            string userChoice;
            int idToFind;
            bool idExists;
            do
            {
                PrintTrainerData(db, "Data of all Trainers");

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------");
                Console.Write("Id: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("-----------");
                Console.ResetColor();
                Console.Clear();

                if (Int32.TryParse(userChoice, out idToFind))
                {
                    idExists = db.Trainers.Any(tr => tr.TrainerId == idToFind);
                }
                else
                {
                    idExists = false;
                }
            } while (!idExists);

            PrintTrainerIdChoice(db, idToFind);

            return idToFind;
        }
        private static void PrintTrainerIdChoice(MyDatabase db, int userChoiceTrainerId)
        {
            PrintTrainerData(db, "Data of all Trainers");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + userChoiceTrainerId + "\n");
            Console.ResetColor();
        }
        public static void PrintCourseData(MyDatabase db, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{message,24}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-7}{"Title",-15}{"StartDate",-15}{"EndDate",-15}{"Type",-15}");
            Console.ResetColor();
            foreach (var course in db.Courses)
            {
                course.PrintPairingData();
            }
        }
        public static int UserInputCourseId(MyDatabase db, int userChoiceTrainerId)
        {
            string userChoice;
            int idToFind;
            bool idExists;
            do
            {
                Console.Clear();
                PrintTrainerIdChoice(db, userChoiceTrainerId);
                PrintCourseData(db, "Data of all Courses");

                //User Input
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------");
                Console.Write("Id: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("-----------");
                Console.ResetColor();
                Console.Clear();

                if (Int32.TryParse(userChoice, out idToFind))
                {
                    idExists = db.Courses.Any(tr => tr.CourseId == idToFind);
                }
                else
                {
                    idExists = false;
                }
            } while (!idExists);


            PrintTrainerIdChoice(db, userChoiceTrainerId);

            PrintCourseData(db, "Data of all Courses");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYour choice was ID: " + idToFind + "\n");
            Console.ResetColor();

            return idToFind;
        }
        private static void PrintMatchMessage(Trainer selectedTrainer, Course selectedCourse)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Trainer ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{selectedTrainer.FirstName} {selectedTrainer.LastName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" moved to course ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{selectedCourse.Title}");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
