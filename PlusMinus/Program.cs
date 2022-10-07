using System.Linq;
using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Array: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter the positive, negative and zeros inside the Array separating them with Space: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
