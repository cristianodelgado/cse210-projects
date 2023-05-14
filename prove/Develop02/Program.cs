using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

    	Console.WriteLine("Wellcome to the Daily Journal");
        Console.WriteLine("-----------------------------");
        bool quit = false;
        while(!quit)
        {
     		
      	    Console.WriteLine("choose an option:  ");
      	    Console.WriteLine("1- Write ");
      
      	    Console.WriteLine("2- Display ");
      
      	    Console.WriteLine("3- Save ");
      
      	    Console.WriteLine("4- Load ");
      	
    	    Console.WriteLine("5- Quit ");
      
  		    Console.WriteLine("What do you like to do?: ");
      	    int option = int.Parse(Console.ReadLine());
			
		    if (option == 1)
            {
               string prompt = promptGenerator.GetRandomPrompt();
               Console.WriteLine(prompt);
               string response = Console.ReadLine();
               string date = DateTime.Now.ToString("MM/dd/yyyy");                       
               Entry entry = new Entry(prompt, response, date);
               journal.AddEntry(entry);
               
            }
	        else if (option == 2)
            {
               journal.DisplayEntries();
               
            }

		    else if (option == 3)
            {
               Console.WriteLine("Enter a file name:");
               string fileName = Console.ReadLine();
               journal.SaveToFile(fileName);
               
            }

		    else if (option == 4)
            {
               Console.WriteLine("Enter the name of your file: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                
            }

		    else if (option == 5)
            {
                quit = true;
                break;
            }
	        else
            {
			   Console.WriteLine("You have entered an invalid option.");
            }






		}
    }
}
