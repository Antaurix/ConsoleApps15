using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Ionut Boris 10/02/2022
    /// </summary>
    public static class Program
        {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();
        private static StudentGrades marks = new StudentGrades();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("BNU CO453 Applications Programming 2021-2022!");
            Console.WriteLine();
            Console.WriteLine("\n Options \n ");
            Console.WriteLine(" ------------------------- ");
            Console.WriteLine("\n 1. Distance Converter \n");
            Console.WriteLine("\n 2. BMI Calculator \n");
            Console.WriteLine("\n 3. Student Grades \n ");
            Console.WriteLine("Enter your choice ! -> ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                converter.ConvertDistance();
            }
            else if (option == "2")
            {
                calculator.CalculateIndex();
            }
            else if(option == "3")
            {
                marks.Run();
            }
        }
    }
}
