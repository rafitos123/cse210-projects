using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {  
        Journal journal = new Journal();
       
       int i = 0;
       do 
       {
       Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            i = Convert.ToInt32(Console.ReadLine());
            
       if( i == 1){
            //access the Entry class
            journal.AddEntry();

       }
       else if ( i == 2) {
        journal.Display();

       }
       else if (i == 3){
        Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                if (filename == "journal.txt")
                {
                    journal.Load();
                    Console.WriteLine("Loading...");
                    Console.WriteLine("File loaded");
                    Console.WriteLine();
                }
                else
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, this file doesn't exist.");
                        Console.WriteLine();
                    }
                }
       }
       else if (i == 4){
            Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                if (filename == "journal.txt")
                {
                    journal.save();
                    Console.WriteLine("It's saved");
                    Console.WriteLine();
                }
                else
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, try again. Wrong File name.");
                        Console.WriteLine();
                    }
                }
       }
       } while (i < 5);


    }

}