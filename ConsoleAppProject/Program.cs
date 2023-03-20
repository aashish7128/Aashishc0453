using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    ///  05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Aashish                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("Which App would you like to run?");
            string App = Console.ReadLine();
            Console.WriteLine("You can work in the selected applications");
            if (App == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.run();
            }
            else if (App == "2")
            {
                BMI conversion = new BMI();
                conversion.run();
            }
            else if (App == "3")
            {
                StudentsGrades converter = new StudentGrades();
                converter.run();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

        }
    }
}
