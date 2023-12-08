using System;

public class Cycling : Activity
{
    protected double _speed;
 

    public Cycling(DateTime date, string name, double minutes, double speed) : base(date, name, minutes)
    {
        _speed = speed;
       
    }

    public override double GetDistance()
    {
        double _distance = (_speed/_minutes)*60;
       return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }
}