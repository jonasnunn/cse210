public class Vip : Elevator
{
    private int _destination;
    private int _currentFloor;
    private string _password;
    public Vip()
    {
        _password = "1234";
    }

    public override void SetDestination()
    {
        bool run = true;
        while (run == true)
        {
            Console.Write("Enter a floor (0-31): ");
            int dest = int.Parse(Console.ReadLine());
            if (dest <= 30 && dest >= 0)
            {
                _destination = dest;
                run = false;
            }
            else if(dest == 31)
            {
                Console.Write("Enter the code: ");
                string code = Console.ReadLine();
                if(code == _password)
                {
                    _destination = dest;
                    run = false;
                }
                else
                {
                    Console.WriteLine("Wrong password.");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid floor.");
            }
        }
    }
}