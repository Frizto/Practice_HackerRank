using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Result
    {
        public static void plusMinus(List<int> arr)
        {
            double pos = 0.0;
            double neg = 0.0;
            double zer = 0.0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    ++pos;
                }
                else if (arr[i] < 0)
                {
                    ++neg;
                }
                else
                {
                    ++zer;
                }
            }

            Console.WriteLine("{0:N6}", pos / arr.Count);
            Console.WriteLine("{0:N6}", neg / arr.Count);
            Console.WriteLine("{0:N6}", zer / arr.Count);
        }
    }
}
