using System;
using System.IO;
using System.Text.Json;

namespace Yandex
{
    class YandexConfig
    {
        public static void Load()
        {
            var json = File.ReadAllText(Variables.configPath + @"\" + Variables.configName + ".json");
            IVariables loaded = JsonSerializer.Deserialize<IVariables>(json);

            //Variables.langEng = loaded.Language;
            //Language.Translate(Variables.langEng);
            Variables.leftAvg = loaded.LeftCPS;
            ConfigSupport.Int(ref Variables.leftAvg, 0, 25, 12);
            Variables.leftGame = loaded.LeftOnlyInGame;
            ConfigSupport.Bool(ref Variables.leftGame);
        }

        public static void Save()
        {
            var save = new IVariables
            {
                //Language = Variables.langEng,
                LeftCPS = Variables.leftAvg,
                LeftOnlyInGame = Variables.leftGame
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize<IVariables>(save, options);

            ConfigSupport.Folder();
            File.WriteAllText(Variables.configPath + @"\" + Variables.configName + ".json", json);
        }
    }
}
