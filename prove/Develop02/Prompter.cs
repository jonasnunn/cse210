class Prompter
{
    public List<string> _prompts = new List<string>();
    public Prompter()
    {
        _prompts.Add("Did you exercise today? ");
        _prompts.Add("Record a spiritual thought you had today! ");
        _prompts.Add("What did you make for breakfast, lunch and dinner? ");
        _prompts.Add("How did you feel today? ");
        _prompts.Add("What is some knowledge you gained today? ");
        _prompts.Add("What are some skills your developed today? ");
        _prompts.Add("What is a goal that you want to accomplish this week? ");
    }   

    public string getPrompt()
    {
        var random = new Random();
        int randNum = random.Next(_prompts.Count);
        string prompt = _prompts[randNum];
        return prompt;
    }

}