namespace RobotExercise.PositionTransformers
{
    using Location;

    public  interface IPositionTransformer
    {
        CardinalPoint Heading { get; }

        IPositionTransformer TurnRight();

        IPositionTransformer TurnLeft();

        Coordinate CoordinateForward(Coordinate origin);

    }
}
