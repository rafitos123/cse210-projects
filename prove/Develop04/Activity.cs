using System;
using System.Runtime.InteropServices.Marshalling;

public class Activity
{
    
     protected int _duration;  

     protected void GetStart(string name, string description )
     {
       Console.Clear();
       Console.WriteLine($"Activity: {name}");
       Console.WriteLine($"Description: {description}");
       Console.Write("Duration in seconds of this activity: ");
       _duration = int.Parse(Console.ReadLine());
   
     }

   protected void GetSpinner(int number){
    List<string> animationSpinner = new List<string>();
    animationSpinner.Add("|");
    animationSpinner.Add("/");
    animationSpinner.Add("-");
    animationSpinner.Add("\\");
    animationSpinner.Add("|");
    animationSpinner.Add("/");
    animationSpinner.Add("-");
    animationSpinner.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(number);

    int i = 0;

   
    while(DateTime.Now < endTime)
    {
        string s = animationSpinner[i];
        
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;

        if (i >= animationSpinner.Count)
        {
            i = 0;
        }
    }   
   }

   

    protected void GetEnd(string name, string duration)
    {
        Console.WriteLine($"Nice, another {duration} seconds of {name} completed!");
        Thread.Sleep(3000);
        Console.WriteLine("Good job");
        Thread.Sleep(3000);
        Console.Clear();
    }

}