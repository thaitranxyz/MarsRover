using NUnit.Framework;
using System.Collections.Generic;

namespace RoverTest
{
    public class Tests
    {
        public const string ExpectedOutput = "1 3 N";

        [Test]
        public void Test1()
        {
            MarsRover.Rover rover = new MarsRover.Rover();
            rover.SetRoverPosition();

            rover.Move();

            List<string> results = rover.PrintRoverLocation();

            Assert.AreEqual(results, ExpectedOutput);
            Assert.Pass();
        }
    }
}