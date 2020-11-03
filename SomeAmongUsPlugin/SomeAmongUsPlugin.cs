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
        public ConfigEntry<bool> unknownImposters { get; set; } //all imposters will have white names and can kill each other if enabled
        public override void Load()
        {
            playerMax = Config.Bind("Custom Room", "Max Players", 10);
            imposterMax = Config.Bind("Custom Room", "Max Imposters", 2);
            killCooldown = Config.Bind("Custom Room", "Kill Cooldown", 10);
            walkSpeed = Config.Bind("Custom Room", "Walking Speed", 1.5f);
            allowInfection = Config.Bind("Custom Gamemode", "Infection", false);
            unknownImposters = Config.Bind("Imposter Settings", "Unknown Imposters", false);
        }
    }
}
