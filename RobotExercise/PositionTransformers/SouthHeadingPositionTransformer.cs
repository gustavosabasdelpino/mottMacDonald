namespace RobotExercise.PositionTransformers
{
    using Location;

    public class SouthHeadingPositionTransformer : IPositionTransformer
    {
        public CardinalPoint Heading => CardinalPoint.South;

        public IPositionTransformer TurnRight()
        {
            return new WestHeadingPositionTransformer();
        }

        public IPositionTransformer TurnLeft()
        {
            return new EastHeadingPositionTransformer();
        }

        public Coordinate CoordinateForward(Coordinate origin)
        {
            return new Coordinate(origin.X, origin.Y-1);
        }

    }
}