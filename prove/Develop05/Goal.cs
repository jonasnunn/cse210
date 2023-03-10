public class Goal
{

    public string name = "";
    public int points = 0;
    public bool completed = false;

    public Goal(string nameOfGoal, int numPoints)
    {
        name = nameOfGoal;
        points = numPoints;
    }
   
    public int GetPoints()
    {
        return points;
    }

    public string GetName()
    {
        return name;
    }
    // public void SetName()
    // {
    //     Console.Write("What should the name of this goal be: ");
    //     name = Console.ReadLine();
    // }

    public void MarkCompleted()
    {
        completed = true;
    }

    public bool IsCompleted()
    {
        if (completed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}


// public virtual void CreateGoal()
// {
//     SetName();
//     SetPoints();
// }

// public void SetPoints()
// {
//     Console.Write("How many points should this goal be worth: ");
//     points = int.Parse(Console.ReadLine());
// }
