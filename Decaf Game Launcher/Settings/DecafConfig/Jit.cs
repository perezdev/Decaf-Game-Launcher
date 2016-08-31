using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "jit")]
    public class Jit
    {
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; } = true;
        [JsonProperty(PropertyName = "verify")]
        public bool Verify { get; set; }
    }
}
