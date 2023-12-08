using System;

class Program
{
    static void Main(string[] args)
    {
        Adress adress1 = new Adress("Groove Street","95","Los Angeles","California","USA");
        Event TheEvent = new Event("Reunion", "Harry Potter Friends", "A event that every Harry Potter's fan can reunited to talk about books and movies", "27.05.2024","6:30 PM", adress1);
        
        //standart
        Console.WriteLine("Sandart details: \n");
        Console.WriteLine(TheEvent.getStandart());
        Console.WriteLine();

        //fullEvent:
        Console.WriteLine("Full details: \n");
        Console.WriteLine("Lecture Marketing: \n");
        Lectures lectures = new Lectures("Reunion", "Harry Potter Friends", "A event that every Harry Potter's fan can reunited to talk about books and movies", "27.05.2024","6:30 PM", adress1, "Emma Watson", 50);
        Console.WriteLine(TheEvent.GetFull());
        Console.WriteLine(lectures.GetLectures());
        Console.WriteLine();

        Console.WriteLine("Reception marketing: \n");
        Receptions receptions = new Receptions("Reunion", "Harry Potter Friends", "A event that every Harry Potter's fan can reunited to talk about books and movies", "27.05.2024","6:30 PM", adress1, "wizardreunion@potter.com");
        Console.WriteLine(TheEvent.GetFull());
        Console.WriteLine(receptions.getReceptions());
        Console.WriteLine();

        Console.WriteLine("Outdoor marketing: \n");
        Outdoor outdoor = new Outdoor("Reunion", "Harry Potter Friends", "A event that every Harry Potter's fan can reunited to talk about books and movies", "27.05.2024","6:30 PM", adress1, "Warm day with 80°F");
        Console.WriteLine(TheEvent.GetFull());
        Console.WriteLine(outdoor.GetOutdoor());
        Console.WriteLine();

        //short
        Console.WriteLine("Short details: \n");
        Console.WriteLine(TheEvent.GetShort());
    }   

}