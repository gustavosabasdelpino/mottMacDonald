namespace Robot.Console
{
    using RobotExercise;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var results = new RobotCommandParser().Process(args);
            foreach (string result in results)
                Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
