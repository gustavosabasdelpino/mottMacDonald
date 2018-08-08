namespace RobotExercise
{
    using System;
    using Location;
    using PositionTransformers;

    public class Robot
    {

        private IPositionTransformer positionTransformer;

        public Table Table { get; }

        public Position Position { get; private set; }

        public bool IsPlaced => !(positionTransformer is NullPositionTransformer);

        public Robot()
        {
            Table = new Table();
            Position = new NullPosition();
            positionTransformer = new NullPositionTransformer();
        }


        public void Place(int x, int y, CardinalPoint heading)
        {
            if (!Table.IsInBoundaries(x, y))
                throw new ArgumentException("Position is outside the table");
            positionTransformer = heading.AsPositionTransformer();
            UpdatePosition(new Coordinate(x, y));
        }


        public void Move()
        {
            Coordinate nextCoordinate = positionTransformer.CoordinateForward(Position.Coordinate);
            if (!Table.IsInBoundaries(nextCoordinate))
                return;
            UpdatePosition(nextCoordinate);
        }

        public void TurnRight()
        {
            positionTransformer = positionTransformer.TurnRight();
            UpdatePosition(Position.Coordinate);
        }

        public void TurnLeft()
        {
            positionTransformer = positionTransformer.TurnLeft();
            UpdatePosition(Position.Coordinate);
        }

        private void UpdatePosition(Coordinate coordinate)
        {
            Position = new Position(coordinate, positionTransformer.Heading);
        }
    }
}
