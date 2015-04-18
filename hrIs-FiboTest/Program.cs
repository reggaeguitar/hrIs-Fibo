
using System;
using System.IO;
using hrIs_Fibo;

namespace hrIs_FiboTest
{
    class Program
    {
        static void Main()
        {
            var inputs = File.ReadAllLines("input6.txt");
            var outputs = File.ReadAllLines("output6.txt");
            for (int index = 1; index < inputs.Length; index++)
            {
                var input = inputs[index];
                var output = Solution.Solve(input);
                if (output != outputs[index - 1])
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
