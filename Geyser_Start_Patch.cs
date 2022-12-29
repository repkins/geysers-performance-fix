using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GeysersPerformanceFix
{
    [HarmonyPatch(typeof(Geyser))]
    [HarmonyPatch("Start")]
    class Geyser_Start_Patch
    {
        static void Postfix(Geyser __instance, ParticleSystem ___warningSmokeEmitter, ParticleSystem ___eruptionEmitter)
        {
            CleanUnusedParticleSystemObjects(__instance, ___warningSmokeEmitter, ___eruptionEmitter);
        }

        static private void CleanUnusedParticleSystemObjects(Geyser geyser, ParticleSystem smokeEmitter, ParticleSystem eruptEmitter)
        {
            Logger.Info(string.Format("Currently {0} child transforms", geyser.transform.childCount));

            int count = 0;
            foreach (Transform childTransform in geyser.transform)
            {
                ParticleSystem particleSystemComponent = childTransform.GetComponent<ParticleSystem>();
                if (particleSystemComponent)
                {
                    if (particleSystemComponent != smokeEmitter && particleSystemComponent != eruptEmitter)
                    {
                        if (particleSystemComponent.gameObject)
                        {
                            UnityEngine.Object.Destroy(particleSystemComponent.gameObject);
                            count++;
                        }
                    }
                }
            }

            if (count > 0)
            {
                Logger.Warning(string.Format("{0} redundant particle system objects destroyed at geyser {1}", count, geyser.transform.position));
            }
        }
    }
}
