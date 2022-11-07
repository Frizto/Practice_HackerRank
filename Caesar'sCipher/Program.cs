using System;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */
    public static string caesarCipher(string s, int k)
    {
        string outStr = string.Empty;

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                outStr += (char)(((c + k - offset) % 26) + offset);
            } else
            {
                outStr += c;
            }
        }

        return outStr;
    }

}

class Program
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);
    }
}