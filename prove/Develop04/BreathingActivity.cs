using System;

public class BreathingActivity : Activity
{
    
    
    
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public override void StartActivity()
    {
        
    
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        
        while (DateTime.Now < end)
        {
            Console.WriteLine("");
            Console.Write("Inhale...");
            count(4);
            Console.Write("Exhale...");
            count(6);

        }
    }    
        
    
}