using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = EnterUserName();
        int userNumber = EnterUserNumber();

        int NumberSquare = SquareNumber(userNumber);

        DisplayResult(userName, NumberSquare);
    }
        static void DisplayMessage()
            {
                Console.WriteLine("Welcome to the program!");
            }
        
        static string EnterUserName()
        {

            Console.Write("What is your name? ");
            string my_name = Console.ReadLine();
            return my_name;

        }

        static int EnterUserNumber()
        {
            Console.Write("Enter a number");
            int my_number = int.Parse(Console.ReadLine());
            return my_number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

         static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Hi {name}, the square of your number is {square}");
        }
}