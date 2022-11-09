using System;

namespace ZigZagSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Int Array: ");
            int arraySize = Int32.Parse(Console.ReadLine());

            int[] arr = new int[arraySize];
            int len = arr.Length;
            int midIndex = len / 2;
            int lastIndex = len - 1;

            Console.WriteLine("Now enter the numbers to be zigzagged: ");
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' ', ',', '.'), Convert.ToInt32);

            //Sorting
            Array.Sort(arr);
            //Console.WriteLine(string.Join(",", arr));

            //Swapping elements
            int max = arr[lastIndex];
            arr[lastIndex] = arr[midIndex];
            arr[midIndex] = max;

            // Reverse elements
            int leftIndex = midIndex + 1;
            int rightIndex = lastIndex - 1;

            while (leftIndex < rightIndex)
            {
                int tmp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = tmp;

                leftIndex++;
                rightIndex--;
            }

            Console.WriteLine(string.Join(",", arr));
        }

    }
}

