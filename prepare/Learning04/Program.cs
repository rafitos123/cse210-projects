using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test1 = new Assignment("Rafael Antunes", "Math");
        Console.WriteLine(test1.GetSummary());

        Math test2 = new Math("Roberto Santos","Fraction","Section 7.3", "Problems 8-19");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());

        WrittingAssignment test3 = new WrittingAssignment("Davi Silva","Art","The art of Van Gogh");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}