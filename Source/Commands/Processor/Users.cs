using System;

namespace Yandex
{
    class Users
    {
        public static void Definition()
        {
            for (; ; )
            {
                string input = Console.ReadLine()?.Trim();
                Process(input);
            }
        }

        public static void Process(string command)
        {
            string[] parts = command.Split(' ');
            string commandName = parts[0].ToLower();

            SupportUsers.Cleaning();

            switch (commandName)
            {
                // Modules
                case "l":
                case "lcm":
                case "left":
                    Change.Int(parts, "avg", ref Variables.leftAvg, 0, 25);
                    Change.Bool(parts, "game", ref Variables.leftGame);
                    break;

                case "cfg":
                case "config":
                    Change.Configs(parts, ref Variables.configName);
                    break;
            }
        }
    }
}
