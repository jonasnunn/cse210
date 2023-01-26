class Journal
{
    public string _date = "";
    public List<string> _newEntry = new List<string>();
    public List<List<string>> entries = new List<List<string>>();
    public string fileName = "myFile.txt";  
    public Journal()
    {

    }
    public void createNewEntry()
    {
        Entries entry1 = new Entries();
        _newEntry = entry1.newEntry();
        entries.Add(_newEntry);
    }
    public void displayEntrys()
    {
        for (int i=0; i < entries.Count(); i++)
        {
            Console.WriteLine("");
            foreach (string line in entries[i])
            {
                Console.WriteLine(line);
            }
        }
    }
    public void saveEntry()
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for (int i=0; i < entries.Count(); i++)
            {
                foreach (string line in entries[i])
                {
                    outputFile.WriteLine(line);
                }
            }   
            // // You can add text to the file with the WriteLine method
            // foreach (string line in _newEntry)
            //     outputFile.WriteLine(line);
        }
    }
    public void readEntry()
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}