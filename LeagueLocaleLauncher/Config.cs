using System.Collections.Generic;
using System.Globalization;
using System.IO;
using YamlDotNet.Serialization;

namespace LeagueLocaleLauncher
{
    public class Config
    {
        public static Config Loaded;

        private const string ConfigFile = "config.yaml";

        public string ToolCulture = CultureInfo.CurrentCulture.ToString();
        public Region Region = Region.NA;
        public Language Language = Language.ENGLISH_UNITED_STATES;
        public string LeagueClientSettingsPath = @"C:\Riot Games\League of Legends\Config\LeagueClientSettings.yaml";
        public string LeagueClientPath = @"C:\Riot Games\League of Legends\LeagueClient.exe";

        public HashSet<string> LeagueProcessNames = new HashSet<string> { };

        public void Save()
        {
            using (TextWriter writer = File.CreateText(ConfigFile))
            {
                var serializer = new Serializer();
                serializer.Serialize(writer, this);
            }
        }

        public static void Load()
        {
            try
            {
                using (TextReader reader = File.OpenText(ConfigFile))
                {
                    Deserializer deserializer = new Deserializer();
                    var config = deserializer.Deserialize<Config>(reader);
                    Loaded = config;
                }
            }
            catch
            {
                Loaded = new Config();
            }

            Loaded.LeagueProcessNames.Add("RiotClientCrashHandler");
            Loaded.LeagueProcessNames.Add("RiotClientServices");
            Loaded.LeagueProcessNames.Add("RiotClientUx");
            Loaded.Save();
        }
    }
}
