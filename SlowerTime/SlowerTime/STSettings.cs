using Oculus.Newtonsoft.Json;
using System;
using System.IO;

namespace SlowerTime
{
    
    class STSettings
    {
        public float DayNightCycleMultiplier = 1.0f;



        private static readonly string configPath = Environment.CurrentDirectory + @"\QMods\SlowerTime\config.json";
        private static readonly STSettings instance = new STSettings();


        static STSettings()
        {
        }


        private STSettings()
        {
        }


        public static STSettings Instance
        {
            get
            {
                return instance;
            }
        }


        public static void Load()
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, JsonConvert.SerializeObject(Instance, Formatting.Indented));
                return;
            }

            var json = File.ReadAllText(configPath);
            var userSettings = JsonConvert.DeserializeObject<STSettings>(json);

            var fields = typeof(STSettings).GetFields();

            foreach (var field in fields)
            {
                var userValue = field.GetValue(userSettings);
                field.SetValue(Instance, userValue);
            }
        }
    }
}
