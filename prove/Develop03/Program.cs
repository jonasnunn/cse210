using System;

class Program
{
    static void Main(string[] args)
    {
        Verse ether = new Verse();
        ether.DisplayVerse();
        bool run = true;
        while (run == true){
            Console.WriteLine("Press enter to hide words or type quit");
            string userInput = Console.ReadLine();
            if (userInput == "")
            {
                List<string> newList = ether.hideWords();
                ether.DisplayVerse();
                ether.UpdateVerse(newList);
            }
            else if (userInput.ToLower() == "quit")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}