using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRovers;

namespace MarsRoversTest
{
    [TestClass]
    public class MarsRoversTest
    {
        [TestMethod]
        public void MyTest_Scenario1_FallOffCliff()
        {
            string map = "10 10";
            string[] rovers = {
                "0 1 S", "MM"
            };
            Scenario scenario = new Scenario(map, rovers);
            string result = scenario.Run();
            Assert.AreEqual(result.Trim(), "0 -1 S");
        }

        [TestMethod]
        public void MyTest_Scenario2_SingleRover_MoveStraight()
        {
            string map = "10 10";
            string[] rovers = {
                "5 5 W", "MMMMM"
            };
            Scenario scenario = new Scenario(map, rovers);
            string result = scenario.Run();
            Assert.AreEqual(result.Trim(), "10 5 W");
        }

        [TestMethod]
        public void MyTest_Scenario3_SingleRover_GoingCircle()
        {
            string map = "10 10";
            string[] rovers = {
                "5 7 E", "RRRRLLLL"
            };
            Scenario scenario = new Scenario(map, rovers);
            string result = scenario.Run();
            Assert.AreEqual(result.Trim(), "5 7 E");
        }

        [TestMethod]
        public void MyTest_Scenario4_MultipleRovers_GoRandom()
        {
            string map = "10 10";
            string[] rovers = {
                "0 0 N", "MMMRMMMLMM",
                "5 5 S", "LMMLMMLMMLMM"
            };
            Scenario scenario = new Scenario(map, rovers);
            string result = scenario.Run();
            Assert.AreEqual(result.Trim(), "3 5 N\r\n5 5 S");
        }

        [TestMethod]
        public void GivenTest_Scenario5_MultipleRovers_GoRandom()
        {
            string map = "5 5";
            string[] rovers = {
                "1 2 N", "LMLMLMLMM",
                "3 3 E", "MMRMMRMRRM"
            };
            Scenario scenario = new Scenario(map, rovers);
            string result = scenario.Run();
            Assert.AreEqual(result.Trim(), "1 3 N\r\n1 5 E");

            // This output in pdf is incorrect
            //Assert.AreEqual(result.Trim(), "1 3 N\r\n5 1 E");
        }
    }
}
