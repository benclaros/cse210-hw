using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What number would be the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());
       Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());
        {
            if (magicNumber > guess)
        {
            Console.WriteLine ("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine ("Lower");
        }
        else 
        {
            Console.WriteLine ("You guessed it!");
        
        }
        }
    }
}