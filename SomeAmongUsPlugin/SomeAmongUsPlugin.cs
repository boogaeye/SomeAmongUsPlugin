using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using UnityEngine;

namespace SomeAmongUsPlugin
{
    [BepInPlugin("pl.BoogaEye.BruhmongUs", "BruhmongUs", "0.0.1")]
    [BepInProcess("Among Us.exe")]
    public class BruhmongUs : BasePlugin
    {
        public ConfigEntry<int> playerMax { get; set; }
        public ConfigEntry<int> imposterMax { get; set; }
        public ConfigEntry<int> killCooldown { get; set; }
        public ConfigEntry<float> walkSpeed { get; set; }
        public ConfigEntry<bool> allowInfection { get; set; }
        public ConfigEntry<bool> individualImposters { get; set; } //all imposters will have white names and can kill each other if enabled
        public ConfigEntry<bool> anyColorAllowed { get; set; } //allows players you be any color in among us
        public ConfigEntry<bool> allowReporting { get; set; } //if false the report button will be inactive
        public ConfigEntry<bool> allowVenting { get; set; } //this will also disable sab.
        public override void Load()
        {
            playerMax = Config.Bind("Custom Room", "Max Players", 10);
            imposterMax = Config.Bind("Custom Room", "Max Imposters", 2);
            killCooldown = Config.Bind("Custom Room", "Kill Cooldown", 10);
            walkSpeed = Config.Bind("Custom Room", "Walking Speed", 1.5f);
            allowInfection = Config.Bind("Custom Gamemode", "Infection", false);
            individualImposters = Config.Bind("Imposter Settings", "Individual Imposters", false);
            anyColorAllowed = Config.Bind("Custom Room", "Allow All Colors for players", true);
            allowReporting = Config.Bind("Player Settings", "Reporting Allowed", true);
            allowVenting = Config.Bind("Imposter Settings", "Allow Venting/Sabotage", true);
        }
    }
}
