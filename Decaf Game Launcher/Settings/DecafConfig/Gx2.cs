using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "gx2")]
    public class Gx2
    {
        [JsonProperty(PropertyName = "dump_textures")]
        public bool DumpTextures { get; set; } = false;
        [JsonProperty(PropertyName = "dump_shaders")]
        public bool DumpShaders { get; set; } = false;
    }
}
