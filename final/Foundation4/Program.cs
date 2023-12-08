using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(new DateTime(2023,12,08), "Running",15,5.2);
        activities.Add(running);
        Cycling cycling = new Cycling(new DateTime(2023,12,08), "Cycling", 30, 12);
        activities.Add(cycling);
        Swimming swimming = new Swimming(new DateTime(2023,12,08),"Swimming", 5,50);
        activities.Add(swimming);

        foreach(Activity item in activities)
        {
            item.GetSummary();
        }
    }
}