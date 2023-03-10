public class Elevator
{
    private int _currentFloor;
    private int _destination;
     
    public Elevator()
    {
        _currentFloor = 1;
        _destination = 0;
        
    }

    public virtual void SetDestination()
    {
        bool run = true;
        while (run == true)
        {
            Console.Write("Enter a floor (0-30): ");
            int dest = int.Parse(Console.ReadLine());
            if (dest <= 30 && dest >= 0)
            {
                _destination = dest;
                run = false;
            }
            else
            {
                Console.WriteLine("That is not a valid floor.");
            }
        }
    }

    public void MoveElevator()
    {
        while (_currentFloor != _destination)
        {    
            if (_currentFloor > _destination)
            {
                _currentFloor--;
            }
            else
            {
                _currentFloor++;
            }
        }
        Console.WriteLine($"You have arrived at floor {_destination}.");
    }
}