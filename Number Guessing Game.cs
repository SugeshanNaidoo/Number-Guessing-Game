using System;

class GuessTheNumber
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        int guess;
        int attempts = 0;

        do
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
                Console.WriteLine("Too low! Try again.");
            else if (guess > randomNumber)
                Console.WriteLine("Too high! Try again.");
            else
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
        } while (guess != randomNumber);
    }
}