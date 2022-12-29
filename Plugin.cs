using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeysersPerformanceFix
{
    [BepInPlugin("subnautica.repkins.geysersperfomancefix", "Geysers Performance Fix", "1.0.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            MainPatcher.Patch();
        }
    }
}
