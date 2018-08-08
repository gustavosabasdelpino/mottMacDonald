namespace RobotExercise.PositionTransformers
{
    using Location;

    public class NorthHeadingPositionTransformer : IPositionTransformer
    {
        public CardinalPoint Heading => CardinalPoint.North;

        public IPositionTransformer TurnRight()
        {
            return new EastHeadingPositionTransformer();
        }

        public IPositionTransformer TurnLeft()
        {
            return new WestHeadingPositionTransformer();
        }

        public Coordinate CoordinateForward(Coordinate origin)
        {
            return new Coordinate(origin.X, origin.Y+1);
        }

      
    }
}