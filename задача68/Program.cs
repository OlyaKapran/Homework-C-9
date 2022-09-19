using System;

namespace задача68
{
    class Program
    {
        static void Main(string[] args)
        {
            int Akkerman(int m, int n)
            {
                if (m == 0) return n + 1;
                else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
                else return (Akkerman(m - 1, Akkerman(m, n - 1)));

            }
            Console.WriteLine(Akkerman(3, 2));
        }
    }
}
