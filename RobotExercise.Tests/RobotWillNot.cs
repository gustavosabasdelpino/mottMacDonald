namespace RobotExercise.Tests
{
    using Location;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RobotWillNot
    {
        

        [TestMethod]
        public void FallOffTheTable()
        {
            Robot robot = new Robot();
            robot.Place(0,0, CardinalPoint.West);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(0, 0, CardinalPoint.West));
            robot.Place(0, 0, CardinalPoint.South);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(0, 0, CardinalPoint.South));

            robot.Place(4, 0, CardinalPoint.East);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(4, 0, CardinalPoint.East));
            robot.Place(4, 0, CardinalPoint.South);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(4, 0, CardinalPoint.South));

            robot.Place(0, 4, CardinalPoint.West);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(0, 4, CardinalPoint.West));
            robot.Place(0, 4, CardinalPoint.North);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(0, 4, CardinalPoint.North));

            robot.Place(4, 4, CardinalPoint.East);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(4, 4, CardinalPoint.East));
            robot.Place(4, 4, CardinalPoint.North);
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(4, 4, CardinalPoint.North));
        }

        [TestMethod]
        public void MoveBeforeBeingPlaced()
        {
            Robot robot = new Robot();
            robot.Move();
            Assert.AreEqual(robot.Position, new NullPosition());
        }
    }
}