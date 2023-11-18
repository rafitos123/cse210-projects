using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        SetName(name);
        Setdescription(description);
        Setpoints(points);
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
    }

    public override void Completed()
    {
        Console.WriteLine($"Nice, you earned {Getpoints()} points");
        Setcomplete(true);
    }
}