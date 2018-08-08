namespace RobotExercise
{
    using System;
    using System.Collections.Generic;
    using Location;

    public class RobotCommandParser
    {
        private readonly Robot robot;
        private const string Place = "place";

        public RobotCommandParser()
        {
            robot= new Robot();
        }

        public string[] Process(string[] args)
        {
            List<string> responses= new List<string>();
            foreach (string arg in args)
            {
                var command = arg.ToLower();
                if (command.StartsWith(Place))
                {
                    PlaceParameters place = ParsePlaceParameters(command);
                    if (place!= null)
                        robot.Place(place.X, place.Y, place.Heading);
                    continue;
                }

                if (command == "report" && robot.IsPlaced)
                {
                    responses.Add(robot.Position.ToString());
                    continue;
                }
                switch (command)
                {
                    case "move":
                        robot.Move();
                        continue;
                    case "left":
                        robot.TurnLeft();
                        continue;
                    case "right":
                        robot.TurnRight();
                        continue;
                    default:
                        continue;
                }
            }
            return responses.ToArray();
        }

        private PlaceParameters ParsePlaceParameters(string command)
        {
            string withoutPlaceWord = command.Remove(0, Place.Length);
            string[] parameters = withoutPlaceWord.Split(',');
            if (parameters.Length < 3)
                return null;
            int x,y;
            if (!int.TryParse(parameters[0],out x))
                return null;
            if (!int.TryParse(parameters[1], out y))
                return null;
            PlaceParameters placeParameters = new PlaceParameters(x, y, parameters[2]);
            if (placeParameters.Heading== CardinalPoint.Undefined)
                throw  new ArgumentException("Cannot move to nowhere");
            return placeParameters;
        }

        class PlaceParameters
        {
            public int X { get; }
            public int Y { get; }
            public CardinalPoint Heading { get; }

            public PlaceParameters(int x, int y, string  heading)
            {
                X = x;
                Y = y;
                Heading = heading.AsCardinalPoint();
            }
        }
    }
}
