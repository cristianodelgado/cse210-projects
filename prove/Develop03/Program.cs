using System;

class Program

{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(
        new Reference("John", 3, 16),
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        bool StudyScripture = true;
        while (StudyScripture)
        {
            Console.Clear();
            scripture.ShowScripture();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
            string option = Console.ReadLine();
            if (option.ToLower() == "quit")
            {
                StudyScripture = false;
            }
            else
            {
                scripture.HideRandomWord();
            }
            
        }

    }
}