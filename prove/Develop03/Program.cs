using System;
namespace CSE210_Projects;


class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("1 Nephi", "16", "24");
        Scripture scripture = new Scripture(scriptureReference, "And it came to pass that he did ainquire of the Lord, for they had bhumbled themselves because of my words; for I did say many things unto them in the energy of my soul.");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
        

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("I hope you got it memorized");
        }
        
    }