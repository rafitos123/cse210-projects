using System;

public class Activity
{
 protected DateTime _date; 
 protected double _minutes; 
 protected string _name;  

 public Activity(DateTime date, string name, double minutes)
 {
    _date = date;
    _minutes = minutes;
    _name = name;
 }

    public string GetName()
    {
        return _name;
    }

    public virtual double GetDistance(){
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }


    public virtual void GetSummary()
    {
        Console.WriteLine( $"{_date.ToString("dd MMM yyyy")} {GetName()} ({_minutes}) min - Distance: {Math.Round(GetDistance())} km, Speed: {Math.Round(GetSpeed())} kph, Pace: {Math.Round(GetPace())} min per km");

        
    }

}