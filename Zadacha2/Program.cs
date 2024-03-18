namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter whole sentence:");
            string sentence = Console.ReadLine();
            foreach (char letter in sentence)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
