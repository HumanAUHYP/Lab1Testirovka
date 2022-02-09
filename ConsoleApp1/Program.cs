using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double x = int.Parse(Console.ReadLine());

            double y;

            if (x < 10 || b != 0)
                y = (a + 2) * (x*x) + 5 * b;
            else if (x >= 10 && c != 0)
                y = (x + a) / (7 * c);
            else
                y = x / (c + 14);
            Console.WriteLine(y);
        }
    }
}
