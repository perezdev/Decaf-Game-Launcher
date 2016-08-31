using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    public class KeyboardDevice : Device
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = string.Empty;
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty(PropertyName = "button_up")]
        public int ButtonUp { get; set; } = 0;
        [JsonProperty(PropertyName = "button_down")]
        public int ButtonDown { get; set; } = 0;
        [JsonProperty(PropertyName = "button_left")]
        public int ButtonLeft { get; set; } = 0;
        [JsonProperty(PropertyName = "button_right")]
        public int ButtonRight { get; set; } = 0;
        [JsonProperty(PropertyName = "button_a")]
        public int ButtonA { get; set; } = 0;
        [JsonProperty(PropertyName = "button_b")]
        public int ButtonB { get; set; } = 0;
        [JsonProperty(PropertyName = "button_x")]
        public int ButtonX { get; set; } = 0;
        [JsonProperty(PropertyName = "button_y")]
        public int ButtonY { get; set; } = 0;
        [JsonProperty(PropertyName = "button_trigger_r")]
        public int ButtonTriggerR { get; set; } = 0;
        [JsonProperty(PropertyName = "button_trigger_l")]
        public int ButtonTriggerL { get; set; } = 0;
        [JsonProperty(PropertyName = "button_trigger_zr")]
        public int ButtonTriggerZR { get; set; } = 0;
        [JsonProperty(PropertyName = "button_trigger_zl")]
        public int ButtonTriggerZL { get; set; } = 0;
        [JsonProperty(PropertyName = "button_stick_l")]
        public int ButtonStickL { get; set; } = 0;
        [JsonProperty(PropertyName = "button_stick_r")]
        public int ButtonStickR { get; set; } = 0;
        [JsonProperty(PropertyName = "button_plus")]
        public int ButtonPlus { get; set; } = 0;
        [JsonProperty(PropertyName = "button_minus")]
        public int ButtonMinus { get; set; } = 0;
        [JsonProperty(PropertyName = "button_home")]
        public int ButtonHome { get; set; } = 0;
        [JsonProperty(PropertyName = "button_sync")]
        public int ButtonSync { get; set; } = 0;
        [JsonProperty(PropertyName = "left_stick_up")]
        public int LeftStickUp { get; set; } = 0;
        [JsonProperty(PropertyName = "left_stick_down")]
        public int LeftStickDown { get; set; } = 0;
        [JsonProperty(PropertyName = "left_stick_left")]
        public int LeftStickLeft { get; set; } = 0;
        [JsonProperty(PropertyName = "left_stick_right")]
        public int LeftStickRight { get; set; } = 0;
        [JsonProperty(PropertyName = "right_stick_up")]
        public int RightStickUp { get; set; } = 0;
        [JsonProperty(PropertyName = "right_stick_down")]
        public int RightStickDown { get; set; } = 0;
        [JsonProperty(PropertyName = "right_stick_left")]
        public int RightStickLeft { get; set; } = 0;
        [JsonProperty(PropertyName = "right_stick_right")]
        public int RightStickRight { get; set; } = 0;
    }
}
