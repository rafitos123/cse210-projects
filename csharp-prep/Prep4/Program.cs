using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        int item = -1;
    while (item != 0)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        item = int.Parse(Console.ReadLine());
        if (item != 0)
        {
            numbers.Add(item);
        }
   
    }
      int sum = 0;
      foreach (int number in numbers )
      {
        sum += number;
      }
      Console.WriteLine($"The sum is: {sum}");
    }
}