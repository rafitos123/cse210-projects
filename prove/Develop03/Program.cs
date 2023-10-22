using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {  
        Reference myReference = new Reference("Moroni", "10","4","5");
        Scripture myScripture = new Scripture("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n"+
        "And by the power of the Holy Ghost ye may know the truth of all things.", myReference);

            //scripture in a list
    myScripture.ListWord();
    string Input;

    do{
        myScripture.Display();
        Console.Write("\n\nPress enter to hide a word or type 'quit' to exit: ");
        Input = Console.ReadLine();

        //hide words
        myScripture.hideWords();
        Console.Clear();

            //finish the program when all words are hidden
            if(myScripture.allHidden()==false)
            {
                myScripture.Display();
                break;
            }
        
    }while (Input == "");
    
    }
 }


    
