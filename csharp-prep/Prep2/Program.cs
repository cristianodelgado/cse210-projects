using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);
        string letter;
        string message;
        if (gradePercentage >= 90)
        {	
             letter = "A";	
            //Console.WriteLine("Your qualification is: A");
        }
        else if (gradePercentage >= 80)
        {   
             letter = "B";
            //Console.WriteLine("Your qualification is: B");
        }
        else if (gradePercentage >= 70)
        {
             letter = "C";
            //Console.WriteLine("Your qualification is: C");
        }
        else if (gradePercentage >= 60)
        {
             letter = "D";
            //Console.WriteLine("Your qualification is: D");
        }
        else
        {
             letter = "F";
            //Console.WriteLine("Your qualification is: F");
        }

        if (gradePercentage >= 70)
        {
            //Console.WriteLine("congratulations you passed!");
             message = "congratulations you passed!";
        }
        else
        {
            //Console.WriteLine("You are close to passing. Cheer up in the next one you can do it!");
             message = "You are close to passing. Cheer up in the next one you can do it!";
        }

        Console.WriteLine($"Your qualification is: {letter}, {message} ");
    }
}