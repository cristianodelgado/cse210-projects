using System;

public abstract class Goal
{
    private string _name;
    private int _points;
    private string _description;
    

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        

    }
    
    public string GetName()
    {
        return _name;

    }
    
    public string GetDescription()
    {
        return _description;

    }
    
    public int GetPoints() 
    {
        return _points;

    }
    
    
    public abstract int RecordEvent();
    public abstract bool isComplete();
}
