using System;

namespace CodingCamp
{
    public class ControllerMainMenu
    {
        public static void ExecuteControllerMainMenu(string userChoice)
        {
            switch (userChoice)
            {
                case "1": Console.Clear(); Imports.ExecuteImports(); ; break;
                case "2": Console.Clear(); Results.ExecuteResults(); break;

                default: Validation.ErrorMainMenuChoice(userChoice); break;
            }
        }
    }

}
