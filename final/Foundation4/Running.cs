using System;

public class Running : Activity
{
    protected double _distance;
 

    public Running(DateTime date, string name, double minutes, double distance) : base(date, name, minutes)
    {
        _distance = distance;
       
    }

    public override double GetDistance()
    {
       return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance/_minutes)*60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }
}