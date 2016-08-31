using Decaf_Game_Launcher.Settings.DecafConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Decaf_Game_Launcher.Settings
{
    public class LauncherSettings
    {
        private string SettingsFile { get; set; } = $@"{Environment.CurrentDirectory}\settings.xml";

        public bool DoubleClickToStartGame { get; set; } = true;
        public bool FindDecafExecutableAutomatically { get; set; } = true;
        public string DecafExecutablePath { get; set; }
        public List<GameRootDirectory> GameDirectories { get; set; } = new List<GameRootDirectory>();
        public GameView GameView { get; set; } = GameView.Default;
        [XmlIgnore]
        public Config Config { get; set; } = new Config();

        public LauncherSettings GetSettings()
        {
            LauncherSettings settings = new LauncherSettings();

            if (File.Exists(SettingsFile))
            {
                using (StreamReader reader = new StreamReader(SettingsFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LauncherSettings), new Type[] 
                                                                                            {
                                                                                                typeof(GameView),
                                                                                                typeof(GameRootDirectory)
                                                                                            });
                    settings = (LauncherSettings)serializer.Deserialize(reader);
                }
            }
            if (Config.DoesConfigFileExist)
            {
                settings.Config = Config.GetDecafConfig();
            }

            return settings;
        }
        public void Save()
        {
            using (var stream = File.Create(SettingsFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LauncherSettings), new Type[]
                                                                                            {
                                                                                                typeof(GameView),
                                                                                                typeof(GameRootDirectory)
                                                                                            });
                serializer.Serialize(stream, this);
            }

            this.Config.Save();
        }
    }
}
