using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Program");
        string filmName;
        List<Goal> goals = new List<Goal>();
        Prompt prompt = new Prompt();

        int i = 0;
       do 
       {
       Console.WriteLine();
            Console.WriteLine($"You have: {prompt.PromptPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            i = Convert.ToInt32(Console.ReadLine());

        if( i == 1){
            Console.WriteLine("Types of goal: ");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goals");
            Console.WriteLine("3. CheckList Goals");
            Console.WriteLine("Wich type of goal would you like to create? ");
            string typeGoal = Console.ReadLine();

            if(typeGoal == "1")
            {
                Console.WriteLine();
                SimpleGoal simple = new SimpleGoal("","",false, 0);
                simple.AddGoal();
                goals.Add(simple);
                Console.Clear();
            }
            else if(typeGoal == "2")
            {
                Console.WriteLine();
                EternalGoal eternal = new EternalGoal("","", 0);
                eternal.AddGoal();
                goals.Add(eternal);
                Console.Clear();
            }
            else if(typeGoal == "3")
            {
                Console.WriteLine();
                Checklist checklist = new Checklist("","",0, 0,0,0);
                checklist.AddGoal();
                goals.Add(checklist);
                Console.Clear();
            }
        }
        else if( i == 2){
           prompt.ListGoal(goals);

        }
        else if( i == 3){
           Console.WriteLine("What is the name of the file? ");
           filmName = Console.ReadLine();
            if (filmName == "goals.txt")
            {
                prompt.Save(goals, filmName);
                Console.Clear();
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, wrong name");
                Console.Clear();
            }
           
        } 
           

        else if(i == 4)
        {
            Console.WriteLine("What is the name of the file? ");
            filmName = Console.ReadLine();
            if(filmName == "goals.txt")
            {
                prompt.Load(goals, filmName);
                Console.Clear();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, wrong name");
                Console.Clear();
            }
        }

        else if (i == 5)
        {
            prompt.RecordEvent(goals);
            Console.WriteLine($"You now have {prompt.PromptPoints()} points.");
        }
        

        }while (i < 6);
    }
}
