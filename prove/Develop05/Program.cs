using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Goal Tracker");

        Tracker t = new Tracker();
        Menu myMenu = new Menu();
        
        bool run = true;
        while (run == true)
        {
            int user_int = myMenu.MainMenu();
            
            // Exit the while loop.
            if (user_int == 0)
            {
                run = false;
            }
            // Add a new goal
            else if (user_int == 1)
            {
                t.AddGoal();
            }
            // Mark a goal as complete
            else if (user_int == 2)
            {
                t.CompleteGoal();
            }
            // Display the total points the user has.
            else if (user_int == 3)
            {
                t.DisplayPoints();
            }
            // Display the goal list.
            else if (user_int == 4)
            {
                t.DisplayGoals();
            }
        }
    }
}