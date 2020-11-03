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
        public override void Load()
        {

        }
    }
}
