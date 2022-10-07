using System.Collections.Generic;
using System.Linq;
using System;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array of numbers separate them with a space: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
