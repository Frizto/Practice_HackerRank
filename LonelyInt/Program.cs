using System;
using System.Collections.Generic;
using System.Linq;

namespace LonelyInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an Array to find the lonely Int number inside it: ");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int res = 0;

            for (int i = 0; i < a.Count; i++)
            {
                res = res ^ a[i];
            }

            Console.WriteLine(res);
        }
    }
}
