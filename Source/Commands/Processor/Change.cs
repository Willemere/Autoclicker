using System;

namespace Yandex
{
    class Change
    {
        public static void Int(string[] args, string valueArgument, ref int valueVariable, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            try
            {
                if (args.Length > 2)
                {
                    string argumentValue = args[1];
                    int valueCommand = Convert.ToInt32(args[2]);
                    if (argumentValue == valueArgument && valueCommand > minValue && valueCommand <= maxValue)
                        valueVariable = valueCommand;
                    else
                        return;
                }
            }
            catch { }
        }

        public static void Bool(string[] args, string valueArgument, ref bool valueVariable)
        {
            try
            {
                if (args.Length > 2)
                {
                    string argumentValue = args[1];
                    bool valueCommand = Convert.ToBoolean(args[2].ToLower().ToString());
                    if (argumentValue == valueArgument)
                        valueVariable = valueCommand;
                    else
                        return;
                }
            }
            catch { }
        }

        public static void Configs(string[] args, ref string nameConfig)
        {
            try
            {
                if (args.Length > 2)
                {
                    string argumentValue = args[1];
                    string valueCommand = Convert.ToString(args[2].ToLower());
                    switch (argumentValue.ToLower())
                    {
                        case "save":
                            nameConfig = valueCommand;
                            YandexConfig.Save();
                            break;

                        case "load":
                            nameConfig = valueCommand;
                            YandexConfig.Load();
                            break;

                        default:
                           return;
                    }
                }
            }
            catch { }
        }
    }
}
