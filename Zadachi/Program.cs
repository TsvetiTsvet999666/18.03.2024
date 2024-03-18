namespace Zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the first variable:");
                string var1 = Console.ReadLine();
                Console.WriteLine("Enter the second variable:");
                string var2 = Console.ReadLine();
                int comparisonResult = string.Compare(var1, var2, StringComparison.OrdinalIgnoreCase);
                if (comparisonResult < 0)
                {
                    Console.WriteLine($"{var1} is smaller than {var2}");
                }
                else if (comparisonResult > 0)
                {
                    Console.WriteLine($"{var1} is greater than {var2}");
                }
                else
                {
                    Console.WriteLine($"{var1} and {var2} are equal");// =
                }

        }

    }
}

