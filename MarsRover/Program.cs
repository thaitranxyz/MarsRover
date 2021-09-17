using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover rover = new Rover(); 
            rover.Start();
            rover.PrintRoverLocation();
        }
    }
}
