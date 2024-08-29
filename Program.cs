using System;
namespace dotnet_console_guess_number;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess Number 0-100");
        int secretNum = new Random().Next(0,100);
        int guessNum = -1;        
        while (true)
        {
            bool validInput = false;
            while (!validInput)          
                if (!(validInput = int.TryParse(Console.ReadLine(), out guessNum)))
                    Console.WriteLine("Invalid input, please enter integer");
            if (guessNum > secretNum)
                Console.WriteLine("It's less");
            else if (guessNum < secretNum)
                Console.WriteLine("It's more");
            else if (guessNum == secretNum)
            {
                Console.WriteLine("You won!");
                return;
            }
            else
                Console.WriteLine("Unknown condition");
        }

    }
}
