using System;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;
using ConsoleAppProject.App03;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    /// 
    public class StudentGrades
    {
        // Constants to use

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;


        // 

        public string [] Students { get; set; }

        public int [] Marks { get; set; }   

        public int [] GradeProfile { get; set; }

        public double Mean { get; set; }


        public int MinMark { get; set; }

        public int MaxMark { get; set; }


        public void Run()
        {

            ConsoleHelper.OutputHeading("App03 Student Marks");
            Console.WriteLine("1 -> Input Marks");
            Console.WriteLine("2 -> Output Marks");
            Console.WriteLine("3 -> Output Stats");
            Console.WriteLine("4 -> Output Grades Profile");
            Console.WriteLine("5 -> Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You selected: Input Marks");
                    InputMarks();
                    break;
                case "2":
                    Console.WriteLine("You selected: Output Marks");
                    OutputMarks();
                    break;
                case "3":
                    Console.WriteLine("You selected Output Stats");
                    OutputStats();
                    break;
                case "4":
                    Console.WriteLine("Output Grades Profile: ");
                    OutputGradeProfile();
                    break;
                case "5":
                    Console.WriteLine("You selected QUIT ");
                    break;
                default:
                    Console.WriteLine("Invalit selection, please chose one option from above:");
                    break;
            }
        }

        public StudentGrades()
        {
            Students = new string[] { "Ionut", "Plamena", "Tanya", "Mitko", "John", "George", "Victor",
                "Peter", "Nozomi", "Pamela" };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void InputMarks()
        {
            Console.WriteLine("Please enter the marks for each students -> ");
            int  index = 0;
            foreach(var name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name} enter mark ->", 0, 100);
                Marks[index] = mark;
                index++;
            }
            Run();
        }

        public void OutputGrades()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                Console.WriteLine($"{ Students[i]} mark = {Marks[i]} Grade ={grade} ");
            }
            Run();
        }

        public Grades ConvertToGrades(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            else return Grades.F;

        }

        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle("Student Marks");
           for (int index = 0; index < Students.Length; index++)
           {
               Grades grade = ConvertToGrades(Marks[index]);
               Console.WriteLine($"Mark" + $"for {Students[index]} = {Marks[index]} grade {grade}");
            }
            Run();
        }

       

        public void CalculateStats()
        {
            double total = 0;

            foreach(int mark in Marks)
            {
                total += mark;
            }
            Mean = total / Marks.Length;
            MinMark = Marks.Min();
            MaxMark = Marks.Max();
        }

        public void OutputStats()
        {
            CalculateStats();
            ConsoleHelper.OutputHeading("Student Grades");
            Console.WriteLine("Mean Mark " + Mean);
            Console.WriteLine("Min Mark " + MinMark);
            Console.WriteLine("Max Mark " + MaxMark);
            Run();
        }



         public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrades(mark);
                GradeProfile[(int)grade]++;
            }
          
        }

        public void OutputGradeProfile()
        {
            CalculateGradeProfile();
            Grades grade = Grades.F;
            Console.WriteLine();
            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count} ");
                grade++;
            }
            Run();
        }
    }
}
