using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)

            {
                try
                {
                    
                    Console.Write("Welcome to the Circle Tester\nEnter Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    Circle circle = new Circle(radius);

                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference(circle.CalculateCircumfrence())}");
                    Console.WriteLine($"Area: {circle.CalculateFormattedArea(circle.CalculateArea())}");
                    count += 1;
                    Console.WriteLine("\nAgain? (y/n)");

                    string again = Console.ReadLine();

                    if (again.ToLower() == "n")
                    { Console.WriteLine($"Goodbye! Enjoy your {count} circle object(s)."); Console.ReadLine() ; }


                    
                    //calculate area and cirucmfrence to 2 decimal places
                    //prompt to continue
                    //display "goodbye" when quit
                }
                catch { Console.WriteLine("That input was invalid. Please try again"); continue; }
                

            }

            
        }
    }
    class Circle
    {
        private double Radius {get; set;}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumfrence()
        {
            return 2 * Radius * Math.PI;
        }
        public string CalculateFormattedCircumference(double NumFromFormat)
        {
            return FormatNumber(NumFromFormat);
        }
        public double CalculateArea()
        {
            return Radius*Radius * Math.PI;
        }
        public string CalculateFormattedArea(double NumFromFormat)
        {
            return FormatNumber(NumFromFormat);
        }
        private string FormatNumber (double x)
        {
            return Math.Round(x, 2).ToString();
        }
        //define private member radius
        //define property to access class member:Radius
    }
}
