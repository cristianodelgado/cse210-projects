using System;

public class Lecture: Event
{
    private string _speacker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speacker, int capacity): base(title, description, date, time, address){
        _speacker = speacker;
        _capacity = capacity;
    }
    public override string GetFullDetails(){
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_speacker}\nCapacity: {_capacity}";
    }


}