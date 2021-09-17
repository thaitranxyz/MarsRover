using NUnit.Framework;
using System.Collections.Generic;

namespace RoverTest
{
    public class Tests
    {
        public const string ExpectedOutput = "1 3 N";

        [Test]
        public void TestRoverPosition()
        {
            MarsRover.Rover rover = new MarsRover.Rover(1, 3, "N");

            rover.Move();

            Assert.AreEqual(rover.y, 4);
        }

        [Test]
        public void TestRoverDirection()
        {
            MarsRover.Rover rover = new MarsRover.Rover(1, 3, "N");

            rover.Left();

            Assert.AreEqual(rover.direction, "W");
        }
    }
}