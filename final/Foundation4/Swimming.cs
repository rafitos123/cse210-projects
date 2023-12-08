using System;

public class Swimming : Activity
{
    protected double _laps;
 

    public Swimming(DateTime date, string name, double minutes, double laps) : base(date, name, minutes)
    {
        _laps = laps;
       
    }

    public override double GetDistance()
    {
        double _distance = _laps * 50 / 1000;
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_minutes)*60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }
}