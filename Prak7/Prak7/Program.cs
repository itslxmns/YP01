using System;

namespace Task7
{
    class Program
    {
        static int Diff(int n)
        {
            int d = Math.Abs(n - 123);

            if (n > 123)
            {
                return d * 3;
            }

            return d;
        }

        static void Main()
        {
            Console.WriteLine("Число 100: " + Diff(100));
            Console.WriteLine("Число 150: " + Diff(150));

            Console.ReadLine();
        }
    }
}