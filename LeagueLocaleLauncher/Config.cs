using System.IO;
using YamlDotNet.Serialization;

namespace LeagueLocaleLauncher
{
    public class Config
    {
        public static Config Loaded;

        private const string ConfigFile = "config.yaml";

        public Region Region = Region.NA;
        public Language Language = Language.ENGLISH_UNITED_STATES;
        public string LeagueClientSettingsPath = @"C:\Riot Games\League of Legends\Config\LeagueClientSettings.yaml";
        public string LeagueClientPath = @"C:\Riot Games\League of Legends\LeagueClient.exe";

        public void Save()
        {
            using (TextWriter writer = File.CreateText(ConfigFile))
            {
                var serializer = new Serializer();
                serializer.Serialize(writer, this);
            }
        }

        public static Config Load()
        {
            try
            {
                using (TextReader reader = File.OpenText(ConfigFile))
                {
                    Deserializer deserializer = new Deserializer();
                    var config = deserializer.Deserialize<Config>(reader);
                    Loaded = config;
                    return config;
                }
            }
            catch
            {
                Loaded = new Config();
                Loaded.Save();
                return Loaded;
            }
        }
    }
}
