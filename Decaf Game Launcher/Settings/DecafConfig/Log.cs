using Newtonsoft.Json;
using System.Collections.Generic;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    [JsonObject(Title = "log")]
    public class Log
    {
        [JsonProperty(PropertyName = "async")]
        public bool Async { get; set; } = false;
        [JsonProperty(PropertyName = "to_file")]
        public bool ToFile { get; set; } = false;
        [JsonProperty(PropertyName = "to_stdout")]
        public bool ToStdOut { get; set; } = false;
        [JsonProperty(PropertyName = "kernel_trace")]
        public bool KernelTrace { get; set; } = false;
        [JsonProperty(PropertyName = "kernel_trace_filters")]
        public List<string> KernelTraceFilters { get; set; } = new List<string>();
        [JsonProperty(PropertyName = "branch_trace")]
        public bool BranchTrace { get; set; } = false;
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; } = "debug";
    }
}
