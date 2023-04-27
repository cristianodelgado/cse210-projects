using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers and press 0 to finish.");
        int Attempts = 9;
        int counter = 1;
        while (counter <= Attempts)
        { 
            Console.WriteLine("Enter a number: ");
            string input1 = Console.ReadLine();
            int listNumber = int.Parse(input1);
            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }
            else
            {
              break;   
            }
        }
        float sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        float average = sum/ numbers.Count;
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The sum is:  {sum}");
        Console.WriteLine($"The average is:  {average}");
        Console.WriteLine($"The Max is:  {max}");
        
    
    }
}