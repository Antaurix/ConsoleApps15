using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;
using ConsoleAppProject.App01;

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
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("BNU CO453 Applications Programming 2021-2022!");
            Console.WriteLine();

            DistanceConverter converter = new DistanceConverter();
            converter.MilesToFeet();
            converter.FeetToMiles();
            converter.MilesToMetres();

        }
    }
}
