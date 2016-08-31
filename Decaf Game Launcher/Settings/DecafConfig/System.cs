using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "system")]
    public class System
    {
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; } = "2";
        [JsonProperty(PropertyName = "system_path")]
        public string SystemPath { get; set; } = @"/undefined_system_path";
    }
}
