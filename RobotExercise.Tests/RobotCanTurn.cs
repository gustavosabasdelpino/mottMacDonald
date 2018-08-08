namespace RobotExercise.Tests
{
    using Location;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RobotExercise;

    [TestClass]
    public class RobotCanTurn
    {

        [TestMethod]
        public void WithoutMoving()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, CardinalPoint.East);
            robot.TurnLeft();
            Assert.AreEqual(robot.Position, new Position(0, 0, CardinalPoint.North));
        }

        [TestMethod]
        public void AndMoveRightRight()
        {
            Robot robot = new Robot();
            robot.Place(0, 2, CardinalPoint.East);
            robot.Move();
            robot.Move();
            robot.TurnRight();
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(2, 0, CardinalPoint.South));
        }

        [TestMethod]
        public void AndMoveLeft()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, CardinalPoint.East);
            robot.Move();
            robot.Move();
            robot.TurnLeft();
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(2, 2, CardinalPoint.North));
        }

        [TestMethod]
        public void AndMoveRightAndReturn()
        {
            Robot robot = new Robot();
            robot.Place(0, 4, CardinalPoint.East);
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.TurnRight();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.TurnRight();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.TurnRight();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(0, 4, CardinalPoint.North));
        }

        [TestMethod]
        public void AndMoveCombinedRigthAndLeft()
        {
            Robot robot = new Robot();
            robot.Place(0, 4, CardinalPoint.East);
            robot.Move();
            robot.Move();
            robot.TurnRight();
            robot.Move();
            robot.Move();
            robot.TurnLeft();
            robot.TurnLeft();
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Position, new Position(2, 4, CardinalPoint.North));
        }


    }
}
