using System;
using ConsoleAppProject;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private double metres;

        /// <summary>
        /// The method down bellow will input the distance in miles, 
        /// calculate the entered distance in feet and 
        /// display the distance in feet.
        /// </summary>
        /// 


        public void MilesToFeet()
        {
            OutputHeading();
            miles = InputDistance("enter the number of miles -> ");
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            Console.WriteLine("                                         ");
            Console.WriteLine(" ----- Converting feet into miles -----  ");
            Console.WriteLine("                                         ");
            feet = InputDistance("enter the number of feet -> ");
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            Console.WriteLine("                                         ");
            Console.WriteLine(" ----- Converting miles to metres ----- ");
            Console.WriteLine("                                         ");
            metres =  InputDistance("enter the number of miles -> ");
            CalculateMetres();
            OutputMetres();
        }

        /// <summary>
        /// A method that will allow the user to input a number of miles, feet and metres.
        /// </summary>
        /// 
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        

        // Those methods will convert the miles in feet , miles in metres & feet in miles.

        private void CalculateFeet()
        {
           
            feet = (miles * FEET_IN_MILES);
        }
        private void CalculateMiles()
        {
            miles = (feet / FEET_IN_MILES);
          
        }
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        // The methods down bellow will display in the CMD prompt the result converted in the desired measurement.
        private void OutputDistance(double fromDistance, string fromUnit, double toDistance, string toUnit)
        {
            Console.WriteLine($" { fromDistance } { fromUnit } is { toDistance } {toUnit}" );
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is -> " + feet + " feet!");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is -> " + metres + " metres!");
        }
        ///<summary>
        ///The output method that will display the conversion in miles , feet and metres.
        /// </summary>
        /// 
        private void OutputHeading()
        {
            Console.WriteLine("\n ----------------------------------------- ");
            Console.WriteLine("            Convert miles to feet            ");
            Console.WriteLine("                by Ionut Boris               ");
            Console.WriteLine("\n ----------------------------------------- ");
        }

    }
}
 