namespace RobotExercise
{
    using Location;

    public class Table
    {

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Table()
        {
            Initialize(5, 5);
        }

        public Table(int width, int height)
        {
            Initialize(width, height);
        }

        public bool IsInBoundaries(int x, int y)
        {
            return x>= 0 && y>= 0 && x < Width && y < Height;
        }

        public bool IsInBoundaries(Coordinate coordinate)
        {
            return IsInBoundaries(coordinate.X, coordinate.Y);
        }

        private void Initialize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
