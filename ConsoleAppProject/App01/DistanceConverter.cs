using System;
using ConsoleAppProject;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will convert the chosen unit to another desired unit 
    /// displaying the choices in the console.
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 0.3048;

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
        /// The method down bellow will be the main method which 
        /// will be used to convert a unit to another.
        /// </summary>
        /// 


        public void ConvertDistance()
        {
            OutputHeading();
            fromUnit = SelectUnit(" Please chose the FROM distance unit -> ");
            toUnit = SelectUnit(" Select the TO distance unit ->");
            Console.WriteLine($"Converting {fromUnit} to {toUnit} ");
            fromDistance = InputDistance($" Enter the number of  {fromUnit} ! ");
            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// This method is converting the chosen unit to the desired one.
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = (fromDistance * FEET_IN_MILES);
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = (fromDistance * METRES_IN_MILES);
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = (fromDistance / FEET_IN_MILES);
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = (fromDistance / FEET_IN_METRES);
            }

            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = (fromDistance / METRES_IN_MILES);
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = (fromDistance * FEET_IN_METRES);
            }
            return;
        }

        /// <summary>
        /// This method is displaying the options that you can chose
        /// from a list inside the console.
        ///
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnit(string prompt)
        {
            
         //  while 
        //        {
             string choice = DisplayChoices(prompt);
         //       if choice.Equals(){
         //           errormessage

       //        }


         //}

            string unit = ExecuteChoice(choice);           
            Console.WriteLine($" you choosed {unit}");
            return unit;
        }

        /// <summary>
        /// This method will execute the selected choice that you made above.
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static string ExecuteChoice(string choice)
        {
            string unit = " Invalid Choice ";
            
      
                if (choice.Equals("1"))
                {
                    return FEET;

                }
                else if (choice.Equals("2"))
                {
                    return METRES;


                }
                else if (choice.Equals("3"))
                {
                    return MILES;
                }
                Console.WriteLine("You chosed an invalid option ");
                Console.WriteLine(" ");
     
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
        private void OutputHeading()
        {
            Console.WriteLine("\n ----------------------------------------- ");
            Console.WriteLine("             Converter of unit               ");
            Console.WriteLine("                by Ionut Boris               ");
            Console.WriteLine("\n ----------------------------------------- ");
        }

    }
}
 