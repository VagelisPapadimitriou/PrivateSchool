using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCamp
{
    public class InputCourse
    {
        //NA SYNEXISW EDW - DOKIMES GIA IMPORT. SOS NA EXW KAI ID

        public static void CourseInput(MyDatabase db)
        {
            string input;

            Course c = new Course();

            db.Courses.Count();

            Console.Write("Course Title: ");
            input = Console.ReadLine();
        }



    }
}
