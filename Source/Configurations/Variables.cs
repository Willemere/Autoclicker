using System;

namespace Yandex
{
    public class Variables
    {
        public static int gwlStyle = -16;
        public static uint whThickframe = 0x00040000;
        public const int mfBycommand = 0x00000000;
        public const int scClose = 0xF060;
        public const int scMaximize = 0xF030;
        public const int scSize = 0xF000;
        public const int swHide = 0;
        public const int swShow = 5;

        public static string configPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}" + @"\YandexDelivery";
        public static string configName = "default"; 

        public static string titleApp = "yandex@" + System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public static string langEng = "eng";

        public static int leftAvg = 12;
        public static bool leftGame = false;
    }

    public class IVariables
    {
        public string Language { get; set; }

        public int LeftCPS { get; set; }

        public bool LeftOnlyInGame { get; set; }
    }
}
