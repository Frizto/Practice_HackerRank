namespace AdjacentElementsProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an Array: ");
            string[] input = Console.ReadLine().Split(' ', ',', '.');
            int[] inputArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputArray.SetValue(int.Parse(input[i]), i);
            }

            //DEBUG
            /*foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }*/

            int Solution(int[] inputArray)
            {
                return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();
            }

            Console.WriteLine(Solution(inputArray));
        }
    }
}