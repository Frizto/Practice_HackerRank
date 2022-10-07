using System.Collections.Generic;
using System.Linq;
using System;


namespace Mini_Max_Sum
{
    class Result
    {
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
}
