using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            int winNum = randNum.Next(0, 100);

            bool win = false;

            //Starting at 1 here, if we increment at the first guess it double counts
            int numGuess = 1;

            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string input = Console.ReadLine();

                int guess = int.Parse(input);

                if(guess > winNum)
                {
                    Console.WriteLine("Lower!");
                    numGuess++;
                }
                else if(guess < winNum)
                {
                    Console.WriteLine("Higher!");
                    numGuess++;
                }
                else if(guess == winNum)
                {
                    Console.WriteLine($"You got it!\nThe number was: {input} in {numGuess} guesses! \n");

                    Console.WriteLine("Would you like to play again?\nEnter Y/N: ");

                    string again = Console.ReadLine();

                    if(again == "N")
                    {
                        win = true;
                    }
                    else
                    {
                        numGuess = 1;
                        winNum = randNum.Next(0, 100);
                    }
                    
                }

            } while (win == false);

            Console.WriteLine("Thanks for playing!");
            Console.Write("Press any key to finish.");
            //ReadKey(true) acts as interrupt
            Console.ReadKey(true);

        }
    }
}
