using System;
namespace Fahim
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2, c, d;
            c = add(a, b);
            Console.WriteLine($"{c}");
            d = add(a, b, c);
            Console.WriteLine($"{d}");
            Console.WriteLine($"{add(10.5f, 25.6f)}");
            Console.ReadKey();
        }
        static int add(int x, int y)
        {
            return x + y;
        }
        static int add(int x, int y, int z)
        {
            return x + y + z;
        }
        static float add(float x, float y)
        {
            return x + y;
        }
    }
}