namespace insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine("current string is: " + str);
            string newString = str.Insert(5, " beautiful");
            Console.WriteLine("new string: " + newString);
        }
    }
}