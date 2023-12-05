using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string type, string title, string description, string date, string time, Adress adress, string weather) 
    : base(type, title, description, date, time, adress)
    {
        _weather = weather;

    } 

    public string GetOutdoor()
    {
        string OutdoorEvent = $"The weather forecast for this day will be: {_weather}";
        return OutdoorEvent;
    }
}