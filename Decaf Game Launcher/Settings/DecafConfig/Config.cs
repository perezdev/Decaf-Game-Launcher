using System;
using System.IO;
using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    public class Config
    {
        private string ConfigFileFullName { get { return $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\decaf\config.json"; } }
        public bool DoesConfigFileExist { get { return File.Exists(ConfigFileFullName); } }

        public Debugger Debugger { get; set; } = new Debugger();
        public Gpu Gpu { get; set; } = new Gpu();
        public Gx2 Gx2 { get; set; } = new Gx2();
        public Input Input { get; set; } = new Input();
        public Jit Jit { get; set; } = new Jit();
        public Log Log { get; set; } = new Log();
        public Sound Sound { get; set; } = new Sound();
        public System System { get; set; } = new System();

        public Config GetDecafConfig()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigFileFullName));
        }
        public void Save()
        {
            using (StreamWriter file = new StreamWriter(ConfigFileFullName))
            {
                file.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
            }
        }
    }
}
