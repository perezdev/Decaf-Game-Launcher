using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Decaf_Game_Launcher.Settings
{
    public class LauncherSettings
    {
        private string SettingsFile { get; set; } = $@"{Environment.CurrentDirectory}\settings.xml";

        public bool FindDecafExecutableAutomatically { get; set; } = true;
        public string DecafExecutablePath { get; set; }

        public LauncherSettings GetSettings()
        {
            LauncherSettings settings = new LauncherSettings();

            if (File.Exists(SettingsFile))
            {
                using (StreamReader reader = new StreamReader(SettingsFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LauncherSettings), new Type[] { typeof(string) });

                    settings = (LauncherSettings)serializer.Deserialize(reader);
                }
            }

            return settings;
        }
        public void Save()
        {
            using (var stream = File.Create(SettingsFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LauncherSettings), new Type[] { typeof(string) });
                serializer.Serialize(stream, this);
            }
        }
    }
}
