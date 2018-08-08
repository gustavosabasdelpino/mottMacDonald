namespace RobotExercise.PositionTransformers
{
    using Location;

    public class EastHeadingPositionTransformer : IPositionTransformer
    {
        public CardinalPoint Heading => CardinalPoint.East;

        public IPositionTransformer TurnRight()
        {
            return new SouthHeadingPositionTransformer();
        }

        public IPositionTransformer TurnLeft()
        {
            return new NorthHeadingPositionTransformer();
        }

        public Coordinate CoordinateForward(Coordinate origin)
        {
            return new Coordinate(origin.X + 1, origin.Y);
        }

    }
}