using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Assignment for guess my number game using a simple loop.
        // initializing random number generator variable
        Random numberGen = new();
        // initializing Magicnumber to a random value from the numberGen variable.
        int magicNumber = numberGen.Next(1, 201);
        // intializing guessNumber variable to be read into user input later
        int guessNumber = 0;
        //created while loop to set the parameters of the game.
        while (guessNumber != magicNumber)
        
        {
            //prompts user for an initial guess and parses the number into the random number generated earlier
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            //displays a message if the user guesses the correct number
            if (guessNumber == magicNumber)
            {
                Console.WriteLine("Congratulations, You guessed the number correctly!");
            }
            //prompts user to guess higher if the number is lower then the randomly generated number
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Try again, higher");
            }
            //prompts user to guess lower if the number is higher then the randomly generated number
            else
            {
                Console.WriteLine("Try again, Lower");
            }
        }
    }
}