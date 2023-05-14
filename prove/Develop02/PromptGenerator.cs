using System;
using System.Collections.Generic;



public class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see God's hand in your life today?",
            "What was the strongest emotion you felt today?",
            "If you could do one thing today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}

