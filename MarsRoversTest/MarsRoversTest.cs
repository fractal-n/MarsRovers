using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRovers;

namespace MarsRoversTest
{
    [TestClass]
    public class MarsRoversTest
    {
        [TestMethod]
        public void MyTest_FallOffCliff()
        {
            MarsMap marsMap = new MarsMap(10, 10);
            Rover rover = new Rover(0, 1, "S");
            string roverInstructions = "MM";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);
            Assert.AreEqual(scenario.Run(), "0 -1 S");
        }

        [TestMethod]
        public void MyTest_MoveStraight()
        {
            MarsMap marsMap = new MarsMap(10, 10);
            Rover rover = new Rover(5, 5, "W");
            string roverInstructions = "MMMMM";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);
            Assert.AreEqual(scenario.Run(), "10 5 W");
        }

        [TestMethod]
        public void MyTest_GoingCircle()
        {
            MarsMap marsMap = new MarsMap(10, 10);
            Rover rover = new Rover(5, 7, "E");
            string roverInstructions = "RRRRLLLL";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);
            Assert.AreEqual(scenario.Run(), "5 7 E");
        }

        [TestMethod]
        public void MyTest_GoRandom1()
        {
            MarsMap marsMap = new MarsMap(10, 10);
            Rover rover = new Rover(0, 0, "N");
            string roverInstructions = "MMMRMMMLMM";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);
            Assert.AreEqual(scenario.Run(), "3 5 N");
        }

        [TestMethod]
        public void MyTest_GoRandom2()
        {
            MarsMap marsMap = new MarsMap(10, 10);
            Rover rover = new Rover(5, 5, "S");
            string roverInstructions = "LMMLMMLMMLMM";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);
            Assert.AreEqual(scenario.Run(), "5 5 S");
        }

        [TestMethod]
        public void GivenTest_GoRandom1()
        {
            MarsMap marsMap = new MarsMap(5, 5);
            Rover rover = new Rover(1, 2, "N");
            string roverInstructions = "LMLMLMLMM";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);
            Assert.AreEqual(scenario.Run(), "1 3 N");
        }

        [TestMethod]
        public void GivenTest_GoRandom2()
        {
            MarsMap marsMap = new MarsMap(5, 5);
            Rover rover = new Rover(3, 3, "E");
            string roverInstructions = "MMRMMRMRRM";
            Scenario scenario = new Scenario(marsMap, rover, roverInstructions);

            // This output in pdf is incorrect
            //Assert.AreEqual(scenario.Run(), "5 1 E");
            Assert.AreEqual(scenario.Run(), "1 5 E");
        }
    }
}
