namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of zeros and ones:");
            string binaryString = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(binaryString, 2);
            Console.WriteLine($"The binary number entered is: {decimalNumber}");
        }
    }
}
