using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradeStr = Console.ReadLine();

        int grade = int.Parse(gradeStr);

        string letter = ""; 

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You got an/a {letter}");


        if (grade >= 70)
        {
            Console.WriteLine("Good job. You passed the class!");
        }

        else
            Console.WriteLine("You didn't pass, but you will next time!");
    }
}