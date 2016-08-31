using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "vpad0")]
    public class Vpad0
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = string.Empty;
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = string.Empty;
    }
}
