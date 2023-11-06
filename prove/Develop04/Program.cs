using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
       do 
       {
       Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            i = Convert.ToInt32(Console.ReadLine());

        if( i == 1){
           Breathing BreathActivity = new Breathing();
           BreathActivity.GetBreath();
        }
        else if( i == 2){
           Reflection ReflectActivity = new Reflection();
           ReflectActivity.GetReflection();
        }
        else if( i == 3){
           Listing ListActivity = new Listing();
           ListActivity.GetList();
        }

        }while (i < 4);
    }
}