using System;
using System.Runtime.InteropServices;

public class Breathing : Activity
{
    
    public void GetBreath(){

        Console.Clear();
        Console.Write("Get ready...");
        GetSpinner(5);
         GetStart("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int endTime = Environment.TickCount + _duration * 1000;


        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
        while(Environment.TickCount < endTime){
            Console.Write("Breath in...");
            for(int i = 4; i > 0; i-- ){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            if(Environment.TickCount >= endTime) break;

            Console.Write("Breath out...");
                for (int i = 6; i > 0; i-- ){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        
    }

         
        GetEnd("Breath",$"{_duration}");
        GetSpinner(5);
    }
        
    

    
}