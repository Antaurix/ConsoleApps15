﻿using System;
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
        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            Console.WriteLine("                                         ");
            Console.WriteLine(" ----- Converting feet into miles -----  ");
            Console.WriteLine("                                         ");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            Console.WriteLine("                                         ");
            Console.WriteLine(" ----- Converting miles to metres ----- ");
            Console.WriteLine("                                         ");
            InputMetres();
            CalculateMetres();
            OutputMetres();
        }

        /// <summary>
        /// A method that will allow the user to input a number of miles, feet and metres.
        /// </summary>
        /// 
        private void InputMiles()
        {
            Console.Write("enter the number of miles ->");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("enter the number of feet ->");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("enter the number of miles ->");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        // Those methods will convert the miles in feet , miles in metres & feet in miles.

        private void CalculateFeet()
        {
           
            feet = (miles * FEET_IN_MILES);
            feet =+ 1;
        }
        private void CalculateMiles()
        {
            feet = miles / FEET_IN_MILES;
          
        }
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        // The methods down bellow will display in the CMD prompt the result converted in the desired measurement.
        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is ->" + miles + "miles!");
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is ->" + feet + "feet!");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is ->" + metres + "metres!");
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
 