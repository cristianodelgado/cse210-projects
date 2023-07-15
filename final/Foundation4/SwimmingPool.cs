using System;
using System.Collections.Generic;
public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _numberOfLaps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_numberOfLaps * 50 / 1000.0 * 0.62);
    }

    public override double GetSpeed()
    {
        return (GetDistance() / getLength()) * 60.0;
    }

    public override double GetPace()
    {
        return getLength() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
