namespace RobotExercise.PositionTransformers
{
    using Location;

    public class NullPositionTransformer : IPositionTransformer
    {
        public CardinalPoint Heading => CardinalPoint.Undefined;

        public IPositionTransformer TurnRight()
        {
            return this;
        }

        public IPositionTransformer TurnLeft()
        {
            return this;
        }

        public Coordinate CoordinateForward(Coordinate origin)
        {
            return origin;
        }

    }
}