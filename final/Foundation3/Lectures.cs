using System;

public class Lectures : Event
{
    private string _speaker; 
    private int _capacity;

    public Lectures(string type, string title, string description, string date, string time, Adress adress, string speaker, int capacity) 
    : base(type, title, description, date, time, adress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectures()
    {
        string LectureEvent = $"Speaker: {_speaker} - {_capacity} of capacity";
        return LectureEvent;
    }
}