using System;

public class ReflectingActivity : Activity
{
    
    private string[] PromptText = {
        "Think of a time when you stood up for someone else. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need. ",
        "Think of a time when you did something truly selfless."
    };

    private string[] Question = {
        "Why was this experience meaningful to you?",
        "Have you ever done something like this before?",
        "How did you start?",
        "How did you feel when it was complete?",
        "What made this time different from other times when you weren't as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    

    public ReflectingActivity(string name, string description) : base(name, description)
    {
    }
    
    public override void StartActivity()
    {
        
        Random random = new Random();
        
        List<int> randomPositions = new List<int>();

        string _prompt = PromptText[random.Next(PromptText.Length)];
        Console.WriteLine($"Consider the following prompt: ");
        Console.WriteLine($"");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine($"When you have something in mind, press enter to continue.");
        Console.ReadKey();
         Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        count(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        
        while (DateTime.Now < end)
        {
            int location = random.Next(Question.Length);
            
            if (!randomPositions.Contains(location))
            {
                randomPositions.Add(location);
            

                Console.Write("> ");
                Console.Write(Question[location]);
            
                Spinner();
            
            }
            
            
        }
    }
}