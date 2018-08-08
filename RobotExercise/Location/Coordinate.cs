namespace RobotExercise.Location
{
    public class Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coordinate coordinateobj))
                return false;
            return X == coordinateobj.X && Y == coordinateobj.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = 23;
            hashCode = hashCode * 31 + X;
            hashCode = hashCode * 31 + Y;
            return hashCode;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}