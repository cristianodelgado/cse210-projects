using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        
        scripture.ShowScripture();

        
        Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            
            scripture.HideWords();
            scripture.ShowScripture();

            
            if (scripture.AllWordsHidden())
            {
                break;
            }

            
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            
        }
        
        Console.ReadLine();

    }
}