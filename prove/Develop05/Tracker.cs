public class Tracker
{

    public int totalPoints = 0;
    public List<Goal> goalList = new List<Goal>();

    public Tracker()
    {
        
    }

    public void AddGoal()
    {
        Console.Write("What do you want to name this goal: ");
        string nameOfGoal = Console.ReadLine(); 

        Console.Write("How many points is this goal worth: ");
        int pointWorth = int.Parse(Console.ReadLine()); 

        Goal newName = new Goal(nameOfGoal, pointWorth);
        goalList.Add(newName);
    }

    public void CompleteGoal()
    {
        Console.Write($"Which goal did you complete(1-{goalList.Count}): ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;
        goalList[goalNum].MarkCompleted();
        totalPoints += goalList[goalNum].GetPoints();
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {totalPoints} points!");
    }

    public void DisplayGoals()
    {
        if (goalList.Count() == 0)
        {
            Console.WriteLine("You don't have any goals yet!");
        }
        else
        {
            int counter = 0;
            foreach (Goal currentGoal in goalList)
            {
            counter ++;
            string check = "[]";
            if (currentGoal.IsCompleted())
                check = "[X]";
            Console.WriteLine($"{check} Goal {counter}: {currentGoal.GetName()} Worth: {currentGoal.GetPoints()}");
            }
        }
    }

}