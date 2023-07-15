using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public int getLength(){
        return _length;
    }

    public abstract double GetDistance();
    
    public abstract double GetSpeed();
    

    public abstract double GetPace();
    

    public virtual string GetSummary()
    {
        return $"{_date:d MMM yyyy} {GetType().Name} ({_length} min)";
    }
}