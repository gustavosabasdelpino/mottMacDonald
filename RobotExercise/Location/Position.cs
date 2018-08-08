namespace RobotExercise.Location
{
    public class Position
    {
        public Coordinate Coordinate { get; }
        public CardinalPoint Heading { get; }

        public Position(Coordinate coordinate, CardinalPoint heading)
        {
            Coordinate = coordinate;
            Heading = heading;
        }

        public Position(int x, int y, CardinalPoint heading)
        {
            Coordinate = new Coordinate(x,y);
            Heading = heading;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Position positionObj))
                return false;
            return positionObj.Coordinate.Equals(Coordinate) && Heading.Equals(positionObj.Heading);
        }

        public override string ToString()
        {
            return $"{Coordinate},{Heading}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
