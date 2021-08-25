using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNum = rnd.Next(1, 101);
            Console.WriteLine("Guessing Game!");
            Console.WriteLine("--------------");
            Console.WriteLine();

            Console.WriteLine(@"Choose a difficulty:
                    Easy = 8 chances
                    Medium = 6 chances
                    Hard = 4 chances");

            string difficulty = Console.ReadLine().ToLower();

            int chances = 0;

            if (difficulty == "easy")
            {
                chances = 8;
            }
            else if (difficulty == "medium")
            {
                chances = 6;
            }
            else if (difficulty == "hard")
            {
                chances = 4;
            }
            else if (difficulty == "cheater")
            {
                chances = int.MaxValue;
            }


            Console.WriteLine($"You have {chances} chances to guess the secret number, a number from 1 to 100. Go on now, GUESS!");
            int userNum = int.Parse(Console.ReadLine());

            for(int i=0; i< chances - 1; i++){
                if (userNum < secretNum)
                {
                    Console.WriteLine("Wrong! So sad, truly very sad, just really is... you know I think it's the worst guess in the history of guesses ever...");
                    Console.WriteLine("Your guess was too low. Think more bigly!");
                    Console.WriteLine($"You have {chances - 1 - i} chances left. Guess again!");
                    userNum = int.Parse(Console.ReadLine());
                }
                else if (userNum > secretNum)
                {
                    Console.WriteLine("Wrong! So sad, truly very sad, just really is... you know I think it's the worst guess in the history of guesses ever...");
                    Console.WriteLine("That number is too high. I don't want the numbers to be any higher.");
                    Console.WriteLine($"You have {chances - 1 - i} chances left. Guess again!");
                    userNum = int.Parse(Console.ReadLine());

                }
                else
                {
                    break;
                }
            }

            if (userNum != secretNum)
            {
                Console.WriteLine("You ran outta chances... what a loser!");
            }
            else
            {
                Console.WriteLine($"{userNum} is indeed the secret number! So smart, truly, maybe even the smartest guess anyone has ever made, who knows?");
            }
        }
    }
}