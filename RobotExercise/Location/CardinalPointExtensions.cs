namespace RobotExercise.Location
{
    using PositionTransformers;

    public static class CardinalPointExtensions
    {
        public static CardinalPoint AsCardinalPoint(this string cardinalPoint)
        {
            switch (cardinalPoint)
            {
                case "north":
                    return CardinalPoint.North;
                case "south":
                    return  CardinalPoint.South;
                case "east":
                    return  CardinalPoint.East;
                case "west":
                    return CardinalPoint.West;
                default:
                    return CardinalPoint.Undefined;
            }
        }

        public static IPositionTransformer AsPositionTransformer(this CardinalPoint cardinalPoint)
        {
            switch (cardinalPoint)
            {
                case CardinalPoint.South:
                    return new SouthHeadingPositionTransformer();
                case CardinalPoint.North:
                    return new NorthHeadingPositionTransformer();
                case CardinalPoint.East:
                    return new EastHeadingPositionTransformer();
                case CardinalPoint.West:
                    return new WestHeadingPositionTransformer();
                default:
                    return new NullPositionTransformer();
            }
        }
    }
}