using System;
using System.Net.NetworkInformation;

public class Goal
{
    private string _name;
    private string _description; 
    private int _point;
    private int _bonus; 
    private bool _complete;

    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
    }

    public string Getname()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string Getdescription()
    {
        return _description;
    }

    public void Setdescription(string description)
    {
        _description = description;
    }

    public int Getpoints()
    {
        return _point;
    }

    public void Setpoints(int points)
    {
        _point = points;
    }

    public bool Getcomplete()
    {
        return _complete;
    }
    public void Setcomplete(bool complete)
    {
        _complete = complete;
    }

    public virtual int Getbonus()
    {
        return 0;
    }

    public virtual void Setbonus(int bonus)
    {
        _bonus = bonus; 
    }

    public virtual int GetCountComplete()
    {
        return 0;
    }

    public virtual int GetCount()
    {
        return 0;
    }

    public virtual void AddGoal(){}
    public virtual void Completed(){}
}