using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "sound")]
    public class Sound
    {
        [JsonProperty(PropertyName = "dump_sounds")]
        public bool DumpSounds { get; set; } = false;
    }
}
