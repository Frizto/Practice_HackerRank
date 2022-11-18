

namespace PalindromeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of cases: ");
            int cases = int.Parse(Console.ReadLine());
            List<string> palCases = new List<string>();
            Console.WriteLine();

            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine($"Write the palindrome of nº {i + 1}: ");
                string s = Console.ReadLine();
                palCases.Add(s);
                Console.WriteLine($"This case is: {isPalindrome(palCases[i])}.");
                Console.WriteLine();
            }

            static bool isPalindrome(string s)
            {
                char[] arr1 = s.ToCharArray();
                Array.Reverse(arr1);
                string temp = new string(arr1);
                string first = temp.Substring(0, s.Length / 2);

                string second = s.Substring(0, s.Length / 2);

                bool result = first.Equals(second);
                return result ? true : false;
            }
        }
    }
}