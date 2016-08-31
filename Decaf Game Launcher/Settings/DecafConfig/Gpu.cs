using Newtonsoft.Json;
using System.Collections.Generic;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "gpu")]
    public class Gpu
    {
        [JsonProperty(PropertyName = "debug")]
        public bool Debug { get; set; } = false;
        [JsonProperty(PropertyName = "force_sync")]
        public bool ForceSync { get; set; } = false;
        [JsonProperty(PropertyName = "debug_filters")]
        public List<string> DebugFilters { get; set; } = new List<string>();
    }
}
