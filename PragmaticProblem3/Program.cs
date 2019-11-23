using System;

namespace PragmaticProblem3
{
    class Program
    {
        /// <summary>
        /// Kadane's Algorithm -> Time Complexity O(n)
        /// </summary>
        /// <param name="a"></param>
        static void maxSubVectorSum(int[] a)
        {
            int startIndex = 0, endIndex = 0;
            int maxStartIndex= 0;
            int maxSum = int.MinValue, sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];

                if (maxSum < sum)
                {
                    endIndex = i;
                    maxStartIndex = startIndex;
                    maxSum = sum;
                }

                if (sum < 0)
                {
                    startIndex = i + 1;
                    sum = 0;
                }
            } 
            
            Console.WriteLine($"Start index is {maxStartIndex}, end index {endIndex} and the sum {maxSum}.");
        }



        /// <summary>
        /// Brute Force Solution for the max continous vector sum -> Time Complexity O(n^2)
        /// </summary>
        /// <param name="a"></param>
        static void maxSubVectorSumBruteForce(int[] a)
        {
            int maxSum = int.MinValue;

            for (int start = 0; start < a.Length; start++)
            {
                int sum = a[start];

                maxSum = Math.Max(sum, maxSum);

                for (int end = start + 1; end < a.Length; end++)
                {
                    sum += a[end];
                    maxSum = Math.Max(sum, maxSum);
                }
            }

            Console.WriteLine($"The max sum is {maxSum}.");
        }

        static void Main(string[] args)
        {
            int[] randomArray = { 12, -34, 40, 6, -10, 56, 12, -1, -15, 10, 4 };
            //int[] randomArray = { -12, -34, -40, -6, -10, -56, -12, -1, -15, -10, -4 };
            maxSubVectorSum(randomArray);
            //maxSubVectorSumBruteForce(randomArray);
            Console.ReadKey();
        }
    }
}
