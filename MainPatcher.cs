using Harmony;
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
            var harmony = HarmonyInstance.Create("subnautica.repkins.geysersperformancefix");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Logger.Info("Successfully patched");
        }
    }
}
