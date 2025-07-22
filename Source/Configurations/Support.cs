using System.IO;

namespace Yandex
{
    class ConfigSupport
    {
        public static void Folder()
        {
            try
            {
                Directory.CreateDirectory(Variables.configPath);

                if (Directory.Exists(Variables.configPath))
                    return;
            }
            catch { }
        }

        public static void Int(ref int value, int minValue, int maxValue, int defaultValue)
        {
            if (value > minValue & value < maxValue)
                value = defaultValue;
        }

        public static void Bool(ref bool value)
        {
            if (value == true)
                value = true;
            else if (value == false)
                value = false;
            else
                value = false;
        }
    }
}
