using System;

namespace Zork.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Common.Game game = Common.Game.LoadFromFile(gameFilename, output, input);

            //Console.WriteLine("Welcome to Zork");
            
            while(game.IsRunning)
            {
                output.Write(">");
                input.ProcessInput();
            }

            Console.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
