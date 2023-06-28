using System;

class Program
{
    static void Main()
    {
        string lineOfText = "The quick brown fox jumps over the lazy dog";
        string searchWord = "fox";

        bool found = lineOfText.Contains(searchWord, StringComparison.OrdinalIgnoreCase);

        if (found)
        {
            Console.WriteLine("The word '" + searchWord + "' was found in the line of text.");
        }
        else
        {
            Console.WriteLine("The word '" + searchWord + "' was not found in the line of text.");
        }
    }
}
