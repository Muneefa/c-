namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now; // Current date and time
            DateTime specificDate = new DateTime(2023, 6, 28);
            string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm");
            Console.WriteLine(formattedDate); // Outputs: 2023-06-28 10:30
            Console.WriteLine(currentDate);
            Console.WriteLine(specificDate);
        }
    }
}