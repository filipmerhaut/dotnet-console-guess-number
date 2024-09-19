using System;

namespace guessing_game
{
    public class GameManager
    {
        static void PlayGuessingGame()
        {
            int secretNum = new Random().Next(0, 100);
            int guessNum = -1;

            while (true)
            {
                guessNum = GetValidGuess();

                if (guessNum > secretNum)
                    Console.WriteLine("It's less");
                else if (guessNum < secretNum)
                    Console.WriteLine("It's more");
                else
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
        }

        static int GetValidGuess()
        {
            int guessNum;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out guessNum))
                    return guessNum;
                else
                    Console.WriteLine("Invalid input, please enter an integer");
            }
        }
    }
}