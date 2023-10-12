using System;
using System.Collections.Generic;
using System.IO;


public class Journal{

public List<Entry> _listentry = new List<Entry>();

public string _filename;

public void AddEntry(){

    Entry userEntry = new Entry();

    DateTime CurrentDate = DateTime.Now;
    userEntry._dateString = CurrentDate.ToShortDateString();

    Prompt callprompt = new Prompt();
    userEntry._displayPrompt = callprompt.Display();

    Console.WriteLine(userEntry._displayPrompt);
    userEntry._input = Console.ReadLine();

    _listentry.Add(userEntry);

    
}

    public void Display(){
        foreach (Entry entry in _listentry ){
            entry.Display();
        }

    }

    public void Load(){

        _filename = "Journal.txt";

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines){
            string[] parts = line.Split(",");
            string firstname = parts[0];
            Console.WriteLine(firstname);
        }
    }

    public void save(){
        _filename = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(_filename, true)){
            foreach(Entry entry in _listentry){
                outputFile.WriteLine($"Date: {entry._dateString} - Prompt: {entry._displayPrompt}\n" +
                $"Answer: {entry._input}");
                outputFile.WriteLine();
            }
        }


    }
}
