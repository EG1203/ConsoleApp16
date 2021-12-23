using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("введите 1 2 или 3");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("введите x");
                int x = int.Parse(Console.ReadLine());
                double a = 0, b = 0, z, y;
                switch (n)
                {
                    case 1: a = 2.2; b = 2.4; break;
                    case 2: a = 1.6; b = 1.7; break;
                    case 3: a = 1.3; b = 4.2; break;
                }
                z = Math.Log(Math.Abs(Math.Tan(b * x)));
                if (x < a) y = a + Math.Pow(z * Math.Cos(Math.Pow((b * x), 3)), 2);
                else if (a <= x && x <= b) y = a + Math.Pow(Math.Sin(Math.Pow(b, 2)), 2) + Math.Log(z * x);
                else y = Math.Sqrt(Math.Sqrt(0.3 * b + Math.Sqrt(Math.Abs(a - Math.Pow(z, 2) - Math.Cos(x)))));
                Console.WriteLine("y={0:F2}", y);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}