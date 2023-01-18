public class Job 
{

    // define member variables
    public string _company ="";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Create a constructor
    public Job()
    {
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}