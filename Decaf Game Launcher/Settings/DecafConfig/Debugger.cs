using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "debugger")]
    public class Debugger
    {
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; } = true;
        [JsonProperty(PropertyName = "break_on_entry")]
        public bool BreakOnEntry { get; set; } = false;
    }
}
