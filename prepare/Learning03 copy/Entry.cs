using System;
using System.Collections.Generic;

public class Entry{
    public string _input;
    public string _dateString;
    public string _displayPrompt;

    public void Display(){
         Console.WriteLine($"Date: {_dateString} - Prompt: {_displayPrompt}\n" +
        $"Answer: {_input}");
        Console.WriteLine();
    }
}