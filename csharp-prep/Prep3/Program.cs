using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        // Console.WriteLine($"Your random number is {number}");

        bool guessed = false;
        int counter = 0;

        while(guessed == false){
        Console.Write("What is your guess: ");
        int guess = int.Parse(Console.ReadLine());
        Console.WriteLine($"They guessed {guess}");
        counter += 1;

        if (guess > number)
        {
            Console.WriteLine("Your guess is high");
        } 
        else if (guess < number)
        {
            Console.WriteLine("Your guess is low");
        }
        else
        {
            Console.WriteLine("Correct. Perfect. Great job!");
            guessed = true;
        }
        }
        Console.WriteLine($"It took {counter} guesses to guess the number");
    }
}