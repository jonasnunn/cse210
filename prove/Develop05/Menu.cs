public class Menu
{

    public Menu()
    {

    }

    public int MainMenu()
    {
        Console.WriteLine("\nPlease select one of the following options");
        Console.WriteLine("0. to quit");
        Console.WriteLine("1. Create a Goal");
        Console.WriteLine("2. Check off a Goal");
        Console.WriteLine("3. See your total Points");
        Console.WriteLine("4. See a list of your goals");
        Console.Write(":>");
        return int.Parse(Console.ReadLine());
    }

}