namespace RobotExercise.PositionTransformers
{
    using Location;

    public class WestHeadingPositionTransformer : IPositionTransformer
    {
        public CardinalPoint Heading => CardinalPoint.West;
        public IPositionTransformer TurnRight()
        {
            return new  NorthHeadingPositionTransformer();
        }

        public IPositionTransformer TurnLeft()
        {
            return new SouthHeadingPositionTransformer();
        }

        public Coordinate CoordinateForward(Coordinate origin)
        {
            return  new Coordinate(origin.X-1, origin.Y);
        }

    }
}