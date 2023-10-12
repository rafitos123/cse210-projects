using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {  
        Fraction option1 = new Fraction();
        Console.WriteLine(option1.GetFractionString());
        Console.WriteLine(option1.DecimalValue());

        Fraction option2 = new Fraction(5);
        Console.WriteLine(option2.GetFractionString());
        Console.WriteLine(option2.DecimalValue());

        Fraction option3 = new Fraction(3, 4);
        Console.WriteLine(option3.GetFractionString());
        Console.WriteLine(option3.DecimalValue());

        Fraction option4 = new Fraction(1, 3);
        Console.WriteLine(option4.GetFractionString());
        Console.WriteLine(option4.DecimalValue());
    }

}