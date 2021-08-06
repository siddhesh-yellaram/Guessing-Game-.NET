using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessNumber();
        }

        static void GuessNumber()
        {
            Console.WriteLine("Guess the Number!");
            Console.WriteLine("I am thinking of no from 1 to 10");

            Random rnd = new Random();
            int guess = rnd.Next(1, 10);
            int tries = 0;
            string userGuess;
            int userVal;
            string choice;
            
            Console.Write("Your Guess: ");
            userGuess = Console.ReadLine();
            userVal = Convert.ToInt32(userGuess);
            
            while(userVal != guess)
            {
                if(userVal < guess)
                {
                    Console.WriteLine("Too Low");
                    Console.Write("Your Guess: ");
                    userGuess = Console.ReadLine();
                    userVal = Convert.ToInt32(userGuess);
                    tries++;
                }
                else
                {
                    Console.WriteLine("Too High");
                    Console.Write("Your Guess: ");
                    userGuess = Console.ReadLine();
                    userVal = Convert.ToInt32(userGuess);
                    tries++;
                }
            }
            Console.WriteLine("You guessed it in " + tries + " tries..");
           
            Console.Write("Do you want to play again ? (y/n): ");
            choice = Console.ReadLine();
            if(choice.Equals("y"))
            {
                GuessNumber();
            }
            else
            {
                Console.WriteLine("Thank you for playing this game!!! See you next time :)");
            }

            Console.ReadLine();
        }
    }
}
