namespace RobotExercise.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RobotCommandParserCan
    {
        [TestMethod]
        public void TransmitAllValidCommandsAndGetFinalPosition()
        {
            RobotCommandParser parser = new RobotCommandParser();
            string[] commands = {
                "Place 0,4,East",
                "Move",
                "Move",
                "Right",
                "Move",
                "Move",
                "Left",
                "Left",
                "Move",
                "Move",
                "Report"
            };
            string[] results = parser.Process(commands);
            Assert.AreEqual(results.Length,1);
            string finalResult = results.First();
            Assert.AreEqual(finalResult,"2,4,North");
        }

        [TestMethod]
        public void IgonreInvalidValues()
        {
            RobotCommandParser parser = new RobotCommandParser();
            string[] commands = {
                "Place 0,4,East",
                "Move",
                "Invalid",
                "Move",
                "Right",
                "Move",
                "Move",
                "Invalid",
                "Left",
                "Left",
                "Move",
                "Move",
                "Report"
            };
            string[] results = parser.Process(commands);
            Assert.AreEqual(results.Length, 1);
            string finalResult = results.First();
            Assert.AreEqual(finalResult, "2,4,North");
        }

        [TestMethod]
        public void ReportMoreThanOnce()
        {
            RobotCommandParser parser = new RobotCommandParser();
            string[] commands = {
                "Place 0,4,East",
                "Move",
                "Report",
                "Move",
                "Right",
                "Move",
                "Move",
                "Left",
                "Left",
                "Move",
                "Move",
                "Report"
            };
            string[] results = parser.Process(commands);
            Assert.AreEqual(results.Length, 2);
            Assert.AreEqual(results[0], "1,4,East");
            Assert.AreEqual(results[1], "2,4,North");
        }

        [TestMethod]
        public void ReportOnlyIfRobotIsPlaced()
        {
            RobotCommandParser parser = new RobotCommandParser();
            string[] commands = {
                "Report",
                "Place 0,4,East",
                "Move",
                "Report"
            };
            string[] results = parser.Process(commands);
            Assert.AreEqual(results.Length, 1);
        }


    }
}