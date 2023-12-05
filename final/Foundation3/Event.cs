using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Adress _adress;
    private string _type;

    public Event(string type, string title, string description, string date, string time, Adress adress)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adress = adress;
        _type = type;
    }

    

    public string getStandart()
    {
        string standart = $"Title: {_title}\n Description: {_description} \n Date: {_date} at {_time} \n {_adress.GetAdress()}";
        return standart;
    }

    public string GetFull()
    {
        string full = $"Type of event: {_type} - Title: {_title}\n Description: {_description} \n Date: {_date} at {_time} \n {_adress.GetAdress()}";
        return full;
    }

    public string GetShort()
    {
        string shortEvent = $"Type of event: {_type} - Title: {_title}\n Date: {_date}";
        return shortEvent;
    }
    
}