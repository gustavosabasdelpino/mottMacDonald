namespace RobotExercise.Tests
{
    using Location;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RobotExercise;

    [TestClass]
    public class RobotCanMove
    {
        [TestMethod]
        public void Forward()
        {
            Robot robot = new Robot();
            robot.Place(0,0, CardinalPoint.East);
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(4,0, CardinalPoint.East));
        }

        [TestMethod]
        public void ForwardAndBePlacedAgain()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, CardinalPoint.East);
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(4, 0, CardinalPoint.East));
            robot.Place(0, 0, CardinalPoint.North);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(0, 1, CardinalPoint.North));
        }
    }
}
