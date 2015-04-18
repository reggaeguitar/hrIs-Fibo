using System;

namespace hrIs_Fibo
{
    public class Solution
    {
        const double Eps = 1e-5;

        static void Main()
        {
            int numCases = Int32.Parse(Console.ReadLine());
            while (numCases-- > 0)
            {
                Console.WriteLine(Solve(Console.ReadLine()));
            }
        }

        public static string Solve(string input)
        {
            bool isFibo = false;
            long num = Int64.Parse(input);
            long a = 5 * num * num;
            long plusFour = a + 4;
            var plusFourSqrtDbl = Math.Sqrt(plusFour);
            var plusFourSqrtInt = (long)plusFourSqrtDbl;
            if (plusFourSqrtDbl - plusFourSqrtInt < Eps)
            {
                isFibo = true;
            }
            if (!isFibo)
            {
                long minusFour = a - 4;
                var minusFourSqrtDbl = Math.Sqrt(minusFour);
                var minusFourSqrtInt = (long)minusFourSqrtDbl;
                if (minusFourSqrtDbl - minusFourSqrtInt < Eps)
                {
                    isFibo = true;
                }
            }
            return isFibo ? "IsFibo" : "IsNotFibo";
        }
    }
}
