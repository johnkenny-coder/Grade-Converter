using System;
using System.Diagnostics.SymbolStore;

namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = Getnumberofgrades();
            double[] grades = Getgrades(numberOfGrades);

            Console.WriteLine("END OF USER INPUT");
            Console.WriteLine("PROCESSING GRADES...");

            double average = Getaverage(grades);

            Console.WriteLine("The average grade is " + average);
            checkaverage(average);

            Console.WriteLine("here are the grades given by your professor:");
            Listofgrade(grades);
        }

        static int Getnumberofgrades()
        {
            Console.Write("Enter how many grades you want to input: ");
            int numberOfGrades = Convert.ToInt16(Console.ReadLine());
            return numberOfGrades;
        }

        static double[] Getgrades(int listofgrades)
        {
            double[] grades = new double[listofgrades];
            for(int counter = 0; counter < listofgrades; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToInt16(Console.ReadLine());
                if (grade > 0 && grade < 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
            return grades;
        }

        static double Getaverage(double[] grades)
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }

        static void checkaverage(double average)
        {
            if (average <= 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (average > 50 && average <= 70)
            {
                Console.WriteLine("FAIR");
            }
            else if (average > 70 && average <= 80)
            {
                Console.WriteLine("GOOD");
            }
            else if (average > 80 && average <= 90)
            {
                Console.WriteLine("VERY GOOD");
            }
            else if (average > 90 && average <= 100)
            {
                Console.WriteLine("EXCELLENT");
            }
        }

        static void Listofgrade(double[] grades)
        {
            string message = string.Join("_", grades);
            Console.WriteLine(message);
        }
    }
}
