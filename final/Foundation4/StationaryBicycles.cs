using System;
using System.Collections.Generic;
public class StationaryBicycles : Activity
{
    private double _speed;

    public StationaryBicycles(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return 0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60.0 / _speed);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}
