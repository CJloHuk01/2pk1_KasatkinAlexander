using System.ComponentModel.Design;

namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число x");
            double x = double.Parse(Console.ReadLine());
            double s;
            double t;
            double v;

            if (y < 2)

                s = y - y * Math.Pow(x, 2) / (x + 1);
            else
                s = -10.6 * x * y;
            if (s > 0)
                t = s - Math.Pow(Math.Cos(s/x), 2);
            else
                t = y * s + Math.Sin(x) + y;

            v = 2 * y * x + 3 * y * s - s * t;
            Console.WriteLine("y = " + y);
            Console.WriteLine("x = " + x);
            Console.WriteLine("s = " + Math.Round(s, 2));
            Console.WriteLine("t = " + Math.Round(t, 2));
            Console.WriteLine("v = " + Math.Round(v, 2));
        }  
    }
}