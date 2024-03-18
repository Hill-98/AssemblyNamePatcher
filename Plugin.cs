using BepInEx;
using HarmonyLib;
using System;

namespace AssemblyNamePatcher
{
    [BepInPlugin("2aecaf59-9969-4ea5-b41c-b1ee114568fb", "AssemblyNamePatcher", "1.0.0")]
    public class Plugin: BaseUnityPlugin
    {
        private void Awake()
        {
            try
            {
                Harmony.CreateAndPatchAll(typeof(AssemblyNamePatcher));
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }
    }
}
