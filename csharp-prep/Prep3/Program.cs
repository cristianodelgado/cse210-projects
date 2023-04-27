using System;

class Program
{
    static void Main(string[] args)
    {
       
        
	    int Attempts = 7;
	    int counter = 1;


	    while (counter <= Attempts) 
		{
		
		    Console.WriteLine("What is the magic number? ");
    	    string input1 = Console.ReadLine();
		    int magicNumber = int.Parse(input1);
		
		    Console.WriteLine("What is your guess? ");
    		string input2 = Console.ReadLine();
		    int yourGuess = int.Parse(input2);
		
		    if(magicNumber == yourGuess)
			{
		
			    Console.WriteLine("You guessed it! ");
				
			

		    }
	
		    if(magicNumber > yourGuess)
			{
		
			    Console.WriteLine("Higher ");
				
			    

		    }
		    else
			{

			    Console.WriteLine("Lower");

		    }
		    counter++;
	    }
 
        
        
    }
}