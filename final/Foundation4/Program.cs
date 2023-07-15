using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2023, 7, 15), 45, 3.0));
        activities.Add(new StationaryBicycles(new DateTime(2023, 7, 15), 90, 9.7));
        activities.Add(new Swimming(new DateTime(2023, 7, 15), 60, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
    
        }
    }
}