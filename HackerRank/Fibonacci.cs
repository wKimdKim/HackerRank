using System;
namespace HackerRank
{
    public class FibonacciCalculator
    {
        public FibonacciCalculator()
        {
        }

        public static int Calculate(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Calculate(n - 1) + Calculate(n - 2);
            }
        }

        public void Run()
        {
                var nTerm = Convert.ToInt32(Console.ReadLine());
                var result = FibonacciCalculator.Calculate(nTerm);
                Console.WriteLine(result);

        }
    }
}
