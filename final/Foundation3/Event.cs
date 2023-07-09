using System;

public class Event
{
    private String _title;
    private String _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, string date, string time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }
    public virtual string GetStandarDetails(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time} Hs.\nAddress: {_address}";
    }
    public virtual string GetFullDetails(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time} Hs.\nAddress: {_address}";
    }

    public virtual string GetShortDescription(){
        return $"Title: {_title}\nDate: {_date}";
    }




}