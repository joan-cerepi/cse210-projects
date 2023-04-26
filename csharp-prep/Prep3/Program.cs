using System;

class Program
{
    static void Main(string[] args)
    {   
        // Instantiate a random number generator.
        Random randomGenerator = new Random();

        // Assign a boolean variable that will switch to false
        // if the user doesn't want to play anymore.
        bool playAgain = true;

        // Main loop that determines if the game should run again
        // or not.
        while (playAgain)
        {
            Console.WriteLine("Guess My Number Game.\n");
            int randomNumber = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int guesses = 0;

            // Game loop. It will keep running for as long as
            // the user does not guess the correct number.
            while (userGuess != randomNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess > randomNumber)
                {
                    Console.WriteLine("Try again! Go lower!\n");
                } else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Try again! Go higher!\n");
                } else {
                    Console.WriteLine("Congratulations! You guessed the correct number!");
                    Console.WriteLine("You deserve a reward!");
                }
                guesses++;
            }
            Console.WriteLine($"It took you {guesses} guesses to guess the correct number.\n");
            Console.Write("Would you like to play again? ");
            string userAnswer = Console.ReadLine().Trim().ToLower();
            if (userAnswer == "no")
            {
                playAgain = false;
            } else
            {
                Console.WriteLine();
            }
        }
    }
}