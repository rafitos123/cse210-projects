using System;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    private string _file;
    private int _total;

    public void ListGoal(List<Goal> goals)
    {
        Console.WriteLine("Your goal: ");
        foreach(Goal goal in goals)
        {
            string check = "[ ]";

            if(goal is SimpleGoal)
            {
                if(goal.Getcomplete())
                {
                    check = "[x]";
                }
                Console.WriteLine($"{goals.IndexOf(goal) + 1}. {check} {goal.Getname()} ({goal.Getdescription()})");
            }

            else if (goal is EternalGoal)
            {
                Console.WriteLine($"{goals.IndexOf(goal) + 1}. {check} {goal.Getname()} ({goal.Getdescription()})");
            }
            
            else if (goal is Checklist)
            {
                if(goal.GetCount() == goal.GetCountComplete())
                {
                    check = "[x]";
                }
                Console.WriteLine($"{goals.IndexOf(goal) + 1}. {check} {goal.Getname()} ({goal.Getdescription()}) -- Currently Completed: {goal.GetCount()}/{goal.GetCountComplete()}");

            }
        }
    }

    //save goals

    public void Save(List<Goal> goals, string file)
    {
        _file = file;
        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine($"{_total}");

            foreach(Goal goal in goals)
            {
                if(goal is SimpleGoal)
                {
                    output.WriteLine($"Simple Goal: {goal.Getname()}, {goal.Getdescription()}, {goal.Getpoints()}, {goal.Getcomplete()}");
                }
                else if (goal is EternalGoal)
                {
                    output.WriteLine($"Eternal Goal: {goal.Getname()}, {goal.Getdescription()}, {goal.Getpoints()}");
                }
                else if (goal is Checklist)
                {
                    output.WriteLine($"Simple Goal: {goal.Getname()}, {goal.Getdescription()}, {goal.Getpoints()}, {goal.GetCount()}, {goal.GetCountComplete()}, {goal.Getbonus()}");
                }
            }
        }
    }
    
    //Load Goals
    public List<Goal> Load(List<Goal> goals, string file)
    {
        _file = file;
        string[] lines = System.IO.File.ReadAllLines(file);
        _total = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        goals.Clear();

        foreach(string line in lines)
        {
            string[] parts = line.Split(":");
            string name = parts[0];
            string goal = parts[1];


            if(goal == "SimpleGoal")
            {
            string[] part = goal.Split(",");
            SimpleGoal simple = new SimpleGoal(part[0], part[1], bool.Parse(part[2]), int.Parse(part[3]));
            goals.Add(simple);
            }

            else if (goal == "EternalGoal")
            {
                string[] part = goal.Split(",");
                EternalGoal eternal = new EternalGoal(part[0], part[1], int.Parse(part[2]));
                goals.Add(eternal);
            }

            else if (goal == "Checklist")
            {
                string[] part = goal.Split(",");
                Checklist checklist = new Checklist(part[0], part[1], int.Parse(part[2]), int.Parse(part[3]), int.Parse(part[4]), int.Parse(part[5]));
                goals.Add(checklist);
            }
        }
        return goals;
    }

    //record event

    public void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("Your goals: ");
        foreach(Goal goal in goals)
        {
            Console.WriteLine($"{goals.IndexOf(goal) + 1}. {goal.Getname()}");

        }
        Console.WriteLine("Wich goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) -1; 
        goals[goalIndex].Completed();

        if(goals[goalIndex] is Checklist && goals[goalIndex].GetCount() == goals[goalIndex].GetCountComplete())
        {
            _total += (goals[goalIndex].Getpoints() + goals[goalIndex].Getbonus());
        }
        else
        {
            _total += (goals[goalIndex].Getpoints());
        }

    }

    //points 

    public int PromptPoints()
    {
        return _total;
    }
}