using System;

namespace задача64
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sum(int N, int M)
            {
                if (N == M) return $"{M} ";
                return Sum(N - 1, M) + N + " ";
            }
            Console.WriteLine(Sum(15, 5));
        }
    }
}
