using System;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string form = (Console.ReadLine());
            double area = 0;
            if (form == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (form == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (form == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI*r*r;
            }
            else if (form == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
            }

            Console.WriteLine($"{area:f3}");
        }
    }
}
