using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        private int x; 
        private int y; 
        private int plateauX;
        private int plateauY;
        private string direction;
        private int numOfRover = 2; 
        private List<string> outputs = new List<string>();

        public void Start()
        {
            InitilizingPlateau();
            IntitializingRover();
        }

        public void InitilizingPlateau()
        {
            string[] coordinate = Console.ReadLine().Split(" ");
            plateauX = Int32.Parse(coordinate[0]);
            plateauY = Int32.Parse(coordinate[1]);
        }

        public void IntitializingRover()
        {
            //Console.WriteLine("How many rovers do you want: ");
            //numOfRover = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numOfRover; i++)
            {
                SetRoverPosition();
                InputInstruction();
                string location = x + " " + y + " " + direction;
                outputs.Add(location);
            }
        }

        public void SetRoverPosition()
        {
            var position = Console.ReadLine().Split(" ");
            x = Int32.Parse(position[0]);
            y = Int32.Parse(position[1]);
            direction = position[2];
        }

        public void InputInstruction()
        {
            char[] instructions = Console.ReadLine().ToCharArray();

            foreach (var instruction in instructions)
            {
                if (instruction == 'M')
                {
                    Move();
                }
                else if (instruction == 'L')
                {
                    Left();
                }
                else if (instruction == 'R')
                {
                    Right();
                }
                else
                {
                    Console.WriteLine("Please input a valid instruction.");
                }
            }
        }

        public List<string> PrintRoverLocation()
        {
            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
            return outputs;
        }

        public void Move()
        {
            switch (direction)
            {
                case "N": 
                    if (y == plateauY)
                    {
                        break;
                    }
                    y += 1; 
                    break; 
                case "W": 
                    if (x == 0)
                    {
                        break;
                    }
                    x -= 1;
                    break;
                case "S":
                    if (y == 0)
                    {
                        break; 
                    }
                    y -= 1;
                    break;
                case "E":
                    if (x == plateauX)
                    {
                        break;
                    }
                    x += 1; 
                    break;
                default: 
                    return; 
            }
        }

        public void Left()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break; 
                case "W": 
                    direction = "S";
                    break;
                case "S":
                    direction = "E";
                    break; 
                case "E":
                    direction = "N";
                    break;
                default: 
                    return; 
            }                    
        }

        public void Right()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "W":
                    direction = "N";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "E":
                    direction = "S";
                    break;
                default:
                    return;
            }
        }
    }
}
