using System;

namespace dotnet_console_guess_number;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess Number 0-100");
        int secretNum = new Random().Next(0,100);
        int guessNum = -1;
        Console.WriteLine("Debug info: {0}", secretNum);
        while (true)
        {
            bool validInput = false;
            while (!validInput)
            {
                validInput = int.TryParse(Console.ReadLine(), out guessNum);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input, please enter integer");
                }
            }
            if (guessNum > secretNum)
            {
                Console.WriteLine("It's less");
            }
            else if (guessNum < secretNum)
            {
                Console.WriteLine("It's more");
            }
            else if (guessNum == secretNum)
            {
                Console.WriteLine("You won!");
                return;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

    }
}
