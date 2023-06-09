using System;

class Activity
{
    private string _activityName;
    private string _description;
    public int _duration;
       
     private string[] PausingSpinner = 
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\",
        "|"
    };

    

    public Activity(string name, string description)
    {
        this._activityName = name;
        this._description = description;
        this._duration = 0;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"welcome to {_activityName}!");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        
    }
    
    public virtual void Pausing()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        
        
    }
    public void conteo(int inicio){
        for (int j = inicio; j >0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        
        }
        Console.WriteLine();
    }
    public virtual void Spinner(){
        foreach (string s in PausingSpinner)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        Console.Clear();
    }
    public virtual void StartActivity(){

    }
    public virtual void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Good job!");
        foreach (string s in PausingSpinner)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        foreach (string s in PausingSpinner)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        Console.Clear();
    }
    

    public void Ejecutar()
    {
        DisplayStartingMessage();
        Pausing();
        Spinner();
        StartActivity();
        DisplayEndingMessage();
    }
}