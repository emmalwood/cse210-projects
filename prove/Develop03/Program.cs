using System;

public class Program
{
    public static void Main(string[] args)
    {
        // creates a Scripture object with the given verse
        var scripture = new Scripture("D&C", 6, 36, "Look unto me in every thought; doubt not, fear not.");


        while (true)
        {
            // clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());


            // prompts the user to continue or quit
            Console.WriteLine("\nPress Enter to hide more words, type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }


            // hides random words in the scripture
            scripture.HideRandomWords();


            // checks if the scripture is completely hidden and congrats if so
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You've memorized the scripture.");
                break;
            }
        }
    }
}
