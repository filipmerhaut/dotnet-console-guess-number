using System;
using GameManager;

namespace guessing_game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess Number 0-100");
            GameManager.PlayGuessingGame();
        }
    }
}

