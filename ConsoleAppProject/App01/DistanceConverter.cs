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

        public const string FEET = "feet";
        public const string MILES = "miles";
        public const string METRES = "metres";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// The method down bellow will input the distance in miles, 
        /// calculate the entered distance in feet and 
        /// display the distance in feet.
        /// </summary>
        /// 


        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please chose the FROM distance unit -> ");
            toUnit = SelectUnit("Select the TO distance unit ->");
            OutputHeading($" Converting  {fromUnit} to { toUnit} !");
            fromDistance = InputDistance($" Enter the number of  {fromUnit} !");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            return ExecuteChoice(choice);
            
        }

        private static string ExecuteChoice(string choice)
        {

            if (choice.Equals(1))
            {
                return FEET;
            }
            else if (choice.Equals(2))
            {
                return METRES;
            }
            else if (choice.Equals(3))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET} ");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            String choice = Console.ReadLine();
            return choice;
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

       

        // The methods down bellow will display in the CMD prompt the result converted in the desired measurement.
        private void OutputDistance()
        {
            Console.WriteLine($" { fromDistance } { fromUnit }" +
                $" is { toDistance } {toUnit} !" );
        }

        ///<summary>
        ///The output method that will display the conversion in miles , feet and metres.
        /// </summary>
        /// 
        private void OutputHeading(string title)
        {
            Console.WriteLine("\n ----------------------------------------- ");
            Console.WriteLine($"{title}            ");
            Console.WriteLine("                by Ionut Boris               ");
            Console.WriteLine("\n ----------------------------------------- ");
        }

    }
}
 