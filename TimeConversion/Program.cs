using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time to be converted: ");
            string oldDate = Console.ReadLine();
            DateTime newDate = DateTime.Parse(oldDate);
            Console.WriteLine(newDate.ToString("HH:mm:ss"));
        }
    }
}
