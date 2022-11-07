using System.Collections.Generic;
using System.Linq;
using System;

namespace MinMaxSum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            int min = arr.Min();
            int max = arr.Max();
            long sum = 0L;

            for (int i = 0; i < arr.Count(); i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine(Convert.ToString((sum - max) + " " + (sum - min)));
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
