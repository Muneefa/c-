namespace eachcharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";

            foreach (char c in word)
            {
                Console.WriteLine(c);
            }
        }
    }
}