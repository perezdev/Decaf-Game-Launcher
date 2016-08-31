using Newtonsoft.Json;
using System.Collections.Generic;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "input")]
    public class Input
    {
        [JsonProperty(PropertyName = "devices")]
        public List<Device> Devices { get; set; } = new List<Device>();
        public Vpad0 Vpad0 { get; set; } = new Vpad0();
    }
}
