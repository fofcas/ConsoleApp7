using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            const double b = 0.4;
            double a = Math.Log10(x);
            double c = Math.Pow(a, 2) + Math.Sqrt(b * x);
            double y = Math.Pow(Math.E, 2 * x) + Math.Pow(9.7, c);
            Console.WriteLine("a = "+ a +  " c = " + c + " y = " +y);
            Console.ReadKey();

        }
    }
}
