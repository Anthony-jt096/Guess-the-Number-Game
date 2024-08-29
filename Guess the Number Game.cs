using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Guess the number!");
            Console.Write("Press any key to start");
            Console.ReadKey(true);
            Console.Write("\nRemember, you only have 10 attempts, good luck!");
            Console.ReadKey(true);
            Console.WriteLine("\nPick a number between 1 and 100");

            Random number = new Random();
            int num = number.Next(1, 101); // 1 to 100 inclusive

            int guess;
            int attempts = 0;
            const int maxAttempts = 10;

            do
            {
                Console.Write($"Enter your guess: (Attempt {attempts + 1}/{maxAttempts}): ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid input. Please enter a number: ");
                }

                attempts++;

                if (guess < num)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > num)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    break;
                }

                if (attempts == maxAttempts)
                {
                    Console.WriteLine($"You've ran out of attempts.. the number was {num}.");
                }

            } while (guess != num && attempts < maxAttempts);

            while (true)
            {
                Console.Write("\nDo you want to play again? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    playAgain = true;
                    break;
                }
                else if (response == "no")
                {
                    playAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadKey();
    }
}