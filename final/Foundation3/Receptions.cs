using System;
using System.Dynamic;

public class Receptions : Event
{
    private string _email;

    public Receptions(string type, string title, string description, string date, string time, Adress adress, string email) 
    : base(type, title, description, date, time, adress)
    {
        _email = email;
    }

    public string getReceptions()
    {
        string ReceptionsEvent = $"Send your confirmation to this e-mail: {_email}";
        return ReceptionsEvent;
    }
}
