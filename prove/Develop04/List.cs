using System;

public class Listing : Activity
{
     private List<string> questions = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
     };

    public List<string> myList = new List<string>{};

    public void GetList()
    {   
        Console.Clear();
        Console.Write("Get ready...");
        GetSpinner(5);
        GetStart("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int endTime = Environment.TickCount + _duration * 1000;
        Console.Clear();
        Random random = new Random();
        int first = random.Next(questions.Count);
        Console.WriteLine(questions[first]);
        Console.WriteLine();
        Console.Write("You may begin in: ");
            for(int i = 4; i > 0; i-- ){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }

        Console.WriteLine();
            while(Environment.TickCount < endTime){
                    string item = Console.ReadLine();
                    myList.Add(item);
            

                    //if(Environment.TickCount >= endTime) break;

                    
            }

            Console.WriteLine($"You listed {myList.Count} items");
         
        GetEnd("Listing",$"{_duration}");
        GetSpinner(5);
    }
}