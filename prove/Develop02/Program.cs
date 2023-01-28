class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        bool run = true;
        while (run == true){
            // Get input from user
            Console.Write($"\nMenu:\n1. Write a new Entry\n2. Display the Journal\n3. Save current journal\n4. Load a saved journal\n5. Done\n--> ");
            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);

            // 1. Write a new Entry
            if (input == 1)
            {
                journal1.createNewEntry();
            }
            // 2. Display the Journal
            else if (input == 2)
            {
                Console.WriteLine("Journal Entries:");
                journal1.displayEntrys();
            }
            // 3. Save the journal
            else if (input == 3)
            {   
                journal1.saveEntry();
            }
            // 4. Load a journal
            else if (input == 4)
            {
                journal1.readEntry();
            }
            // 5. End
            else if (input == 5)
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter 1-5");
            }
        }
    }
}