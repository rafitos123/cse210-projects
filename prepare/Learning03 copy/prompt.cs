using System;
using System.Collections.Generic;

public class Prompt
{

       List<string> questions = new List<string>{
       "1 - Who was the most interesting person I interacted with today?",
       "2 - What was the best part of my day?",
       "3 - How did I see the hand of the Lord in my life today?",
       "4 - What was the strongest emotion I felt today?",
       "5 - If I had one thing I could do over today, what would it be?"

       };

       public int _index;
       public string Display()
       {

        var random = new Random();
        _index = random.Next(questions.Count);
        string selectPrompt = questions[_index];
        return selectPrompt;

       }






}