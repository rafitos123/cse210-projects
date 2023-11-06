using System;

public class Reflection : Activity
{
   
        private List<string> firstQuestions = new List<string>{
       "Think of a time when you stood up for someone else.",
       "Think of a time when you did something really difficult.",
       "Think of a time when you helped someone in need.",
       "Think of a time when you did something truly selfless.",

        
       };

        private List<string> secondQuestions = new List<string>{
       "Why was this experience meaningful to you?",
       "Have you ever done anything like this before?",
       "How did you get started?",
       "How did you feel when it was complete?",
       "What made this time different than other times when you were not as successful?",
       "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?",

       };


    public void GetReflection()
    {
        Console.Clear();
        Console.Write("Get ready...");
        GetSpinner(5);
        GetStart("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);

        int endTime = Environment.TickCount + _duration * 1000;

        Random random = new Random();
        int first = random.Next(firstQuestions.Count);
        Console.WriteLine("--- " + firstQuestions[first] + "---");
        Console.WriteLine();
        string test;
        do {
             Console.WriteLine("When you have something in mind, press ENTER to continue. "); 
             test = Console.ReadLine();
              while(Environment.TickCount < endTime){
            
                  
                    
                        Console.WriteLine(secondQuestions[random.Next(secondQuestions.Count)]);
                        GetSpinner(8);
                        
                        

                
                    Console.WriteLine();
                    if(Environment.TickCount >= endTime) break;

                }

       
    }while (test != "");
      
    GetEnd("Reflection",$"{_duration}");
        GetSpinner(5);
    }
}