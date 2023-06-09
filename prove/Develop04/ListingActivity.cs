using System;

class ListingActivity : Activity

{
    
    
    private string[] Question = {
        
        "Who are the people you appreciate?",
        "What are your personal strengths?",
        "Who are the people you've helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public override void StartActivity()
    {
        
        List<string> _response = new List<string>();
        Random random = new Random();
        string mensaje = Question[random.Next(Question.Length)];
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{mensaje}---");
        Thread.Sleep(1000);        
        Console.WriteLine("You may begin in: ");
         Console.WriteLine("");
            Console.WriteLine("Inhale...");
            conteo(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        
        
        while (DateTime.Now < end)
        {
                                             
            Console.Write(">");
            string response = Console.ReadLine();
            _response.Add(response);
            //Console.Write(i);
                                                                   
        }
        
        Console.WriteLine($"You listed {_response.Count} items.");
        //Console.ReadKey();
        Thread.Sleep(2000);
        
        
    }    

    
}