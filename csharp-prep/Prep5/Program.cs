using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);
            return number;
        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        static void DisplayResult(int numberSquared, string name)
        {
            Console.WriteLine($"{name}, your favorite number squared is {numberSquared}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int numSquare = SquareNumber(userNum);
        DisplayResult(numSquare, userName);
    }
}