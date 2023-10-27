using System;

public class Math : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";


    public Math(string name, string topic, string textbookSection, string problems) : base(name, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}