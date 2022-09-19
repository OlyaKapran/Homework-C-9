using System;

namespace gmvkr
{
    class Program
    {
        static void Main(string[] args)
        {
            void GapNumberSum (int M, int N, int sum)
            {
                if (M > N) 
                {
                    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
                    return;
                }
                sum = sum + (M++);
                GapNumberSum(M, N, sum);
            }

            GapNumberSum(5, 15, 0);
        }
    }
}
