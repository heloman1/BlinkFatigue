using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BlinkFatigue
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }

        [Description("The rate at which the cooldown of the blink speed is applied. Explained further in the GitHub page.")]
        public float DecreaseRate { get; set; } = 0.75f;

        [Description("⚠ Making people blink too fast may cause epileptic seizures. Change this config at your own risk. ⚠")]
        public float MinBlinkTime { get; set; } = 1.5f;

        [Description("The minimum time between blinks. Explained further in the GitHub page.")]
        public float MinTime { get; set; } = 2.5f;

        [Description("The maximum time between blinks. Explained further in the GitHub page.")]
        public float MaxTime { get; set; } = 3.5f;

        [Description("The minimum time to add to the rework value. Explained further in the GitHub page.")]
        public float AddMin { get; set; } = 0.35f;

        [Description("The minimum time to add to the rework value. Explained further in the GitHub page.")]
        public float AddMax { get; set; } = 0.45f;
    }
}