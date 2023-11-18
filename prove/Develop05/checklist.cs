using System;

public class Checklist : Goal
{
    private int _bonus;
    private int _count;
    private int _countComplete;


    public Checklist(string name, string description, int points,int bonus, int count, int countComplete) : base(name, description, points)
    {
        SetName(name);
        Setdescription(description);
        Setpoints(points);
        Setbonus(bonus);
        SetcountComplete(countComplete);
        
    }

    public override void AddGoal()
    {
        Console.WriteLine("What is your goal? ");
        string name = Console.ReadLine();
        SetName(name);
        Console.WriteLine("What is the description of your goal? ");
        string description = Console.ReadLine();
        Setdescription(description);
        Console.WriteLine("How many points this goal will value? ");
        int points = int.Parse(Console.ReadLine());
        Setpoints(points);
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?  ");
        int countComplete = int.Parse(Console.ReadLine());
        SetcountComplete(countComplete);
        Console.WriteLine("What is the bonus for accomplishing in that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        Setbonus(bonus);
    }

    public void SetcountComplete(int countComplete)
    {
        _countComplete = countComplete;
    }

    public override int GetCountComplete()
    {
        return _countComplete;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

    public override int GetCount()
    {
        return _count;
    }

    public override void Setbonus(int bonus)
    {
        _bonus = bonus;
    }

    public override int Getbonus()
    {
        return _bonus;
    }

    public override void Completed()
    {
        _count ++;
        Console.WriteLine($"Nice, you earned {Getpoints()} points.");
        if(_count == _countComplete)
        {
            Console.WriteLine($"Good, you earned {Getbonus()} bonus.");
        }
    }
}

