namespace ageofperson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime bd = new DateTime(1999, 12, 15);
            int age = DateTime.Today.Year - bd.Year;
            if (DateTime.Today < bd.AddYears(age))
            {
                age--;
            }
            Console.WriteLine(age);
        }
    }
}