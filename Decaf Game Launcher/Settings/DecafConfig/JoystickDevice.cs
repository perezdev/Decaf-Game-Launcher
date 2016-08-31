using Newtonsoft.Json;

namespace Decaf_Game_Launcher.Settings.DecafConfig
{
    public class JoystickDevice : Device
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

        [JsonProperty(PropertyName = "left_stick_x")]
        public int LeftStickX { get; set; } = 0;
        [JsonProperty(PropertyName = "left_stick_x_invert")]
        public bool LeftStickXInvert { get; set; } = false;
        [JsonProperty(PropertyName = "left_stick_y")]
        public int LeftStickY { get; set; } = 0;
        [JsonProperty(PropertyName = "left_stick_y_invert")]
        public bool LeftStickYInvert { get; set; } = false;
        [JsonProperty(PropertyName = "right_stick_x")]
        public int RightStickX { get; set; } = 0;
        [JsonProperty(PropertyName = "right_stick_x_invert")]
        public bool RightStickXInvert { get; set; } = false;
        [JsonProperty(PropertyName = "right_stick_y")]
        public int RightStickY { get; set; } = 0;
        [JsonProperty(PropertyName = "right_stick_y_invert")]
        public bool RightStickYInvert { get; set; } = false;
    }
}
