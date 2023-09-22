using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,10);
        int my_guess = 0;

        while (my_guess != number)
        {
            Console.Write("What is your guess? ");
            my_guess = int.Parse(Console.ReadLine());
            if (my_guess < number)
            {
                Console.WriteLine("Higher");
                
            }
            else if (my_guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}