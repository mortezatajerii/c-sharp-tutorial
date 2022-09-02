// See https://aka.ms/new-console-template for more information
using System;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter side A: ");
            double aSide = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter side B: ");
            double bSide = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter angel Between(side A and side B) in degrees: ");
            double angel = Convert.ToDouble(Console.ReadLine());

            // According to Law of cosines c^2 = a^2 + b^2 -2*a*b*(cos θ)

            double result = (Math.Pow(aSide, 2)) + (Math.Pow(bSide, 2));
            result -= 2 * aSide * bSide * Math.Cos(Math.PI * angel / 180);
            result = Math.Sqrt(result);

            System.Console.WriteLine($"\nResult is [{Math.Round(result, 2)}]");
        }
    }
}
