using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GeysersPerformanceFix
{
    public class MainPatcher
    {
        public static void Patch()
        {
            var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "subnautica.repkins.geysersperformancefix");
            Logger.Info("Successfully patched");
        }
    }
}
