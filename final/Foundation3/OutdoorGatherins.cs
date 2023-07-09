using System;

public class OutdoorGathering: Event
{
    private string _statementWeather;
    public OutdoorGathering(string title, string description, string date, string time,Address address, string statementWeather):base(title, description, date, time,address){
        _statementWeather = statementWeather;
    }
    public override string GetFullDetails(){
        return $"{base.GetFullDetails}\nType: Outdoor Gathering \nWeather: {_statementWeather}";
    }



}