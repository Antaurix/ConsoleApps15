using System;
using ConsoleAppProject;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Ionut Boris
    ///  version v1.0 - 2022
    /// </author>
    /// 
    public enum UnitSystems
    {
        Metric,
        Imperial,
    }

    /// <summary>
    /// Creating the variables that i will be using in the programm.
    /// </summary>
    public class BMI
    {
        public const int POUNDS_IN_STONES = 14;
        public const int INCHES_IN_FEET = 12;

        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE_CLASS_I = 34.9;
        public const double OBESE_CLASS_II = 39.9;
        public const double OBESE_CLASS_III = 40.0;

        private double pound;
        private int inch;
        private double kilogram;
        private double metre;

        public double indexBMI;

        /// <summary>
        /// Displaying the title of the app and 
        /// calling the main methods that will be used
        /// to calculate the body index.
        /// </summary>
        public void CalculateIndex()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("       BMI Calculator    ");
            Console.WriteLine(" ----------------------------- ");
            UnitSystems unitSystems = SelectUnits();
            if (unitSystems == UnitSystems.Imperial)
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }
            else
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }

            OutputHealthMessage();
            OutputBameMessage();



        }

        /// <summary>
        /// Selecting the measurement unit that we would like (metric or imperial)
        /// </summary>
        /// <returns></returns>
        private UnitSystems SelectUnits()
        {
            Console.WriteLine("1. Imperial ");
            Console.WriteLine("2. Metric ");
            Console.Write("\n Chose unit -> ");
            string typeChoice = Console.ReadLine();
            if (typeChoice == "1") return UnitSystems.Imperial;
            else return UnitSystems.Metric;
        }

        /// <summary>
        /// Reading the desired number from the console.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public double InputNumber(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value); 
            return number; 
        }


        /// <summary>
        /// Adding the imperial details and 
        /// convert height into inches and 
        /// weight into pounds.
        /// </summary>
        private void InputImperialDetails()
        {
            Console.WriteLine("Input your weight \n");
            double stones = InputNumber("Input weight in stones ->");
            pound = InputNumber("Input weight in pounds ->");
            pound += stones * POUNDS_IN_STONES;
            Console.WriteLine("Input your height \n");
            double feet = InputNumber("Input height in feet - >");
            inch = (int)InputNumber("Input height in inches - >");
            inch += (int)feet * INCHES_IN_FEET;
        }

        /// <summary>
        /// Enetering the metric details.
        /// </summary>
        private void InputMetricDetails()
        {
            metre = InputNumber("Input height in metres - > ");
            kilogram = InputNumber("Input weight in kilograms -> ");
        }

        /// <summary>
        /// Calculating the BMI based on imperial units.
        /// </summary>
        public void CalculateImperialBMI()
        {
            indexBMI = pound * 703 / (inch * inch);
        }


        public void CalculateMetricBMI()
        {
            indexBMI = kilogram / (metre * metre);
        }

        /// <summary>
        /// Displaying the BMI with the correct health message for each class.
        /// </summary>
        public void OutputHealthMessage()
        {
            if (indexBMI < UNDERWEIGHT)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore " + $"you are Underweight ");
            }
            else if (indexBMI <= NORMAL)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore " + $"you are Normal ");
            }
            else if (indexBMI <= OVERWEIGHT)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore " + $"you are overweight ");
            }
            else if (indexBMI <= OBESE_CLASS_I)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore " + $"you are Obese Class 1 !!! ");
            }
            else if (indexBMI <= OBESE_CLASS_II)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore " + $"you are Obese Class 2 !!! ");
            }
            else if(indexBMI <= OBESE_CLASS_III)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore " + $"you are Obese Class 3 !!! ");
            }
        }

        /// <summary>
        /// Displaying heading.
        /// </summary>
        public void OutputBameMessage()
        {
            Console.WriteLine("---------------------- *** ----------------- " );
            Console.WriteLine("There are higher risk for ");
            Console.WriteLine("Black, Asian or other minority group ");
            Console.WriteLine(" ------------------------------------- ");
        }

    }
}
