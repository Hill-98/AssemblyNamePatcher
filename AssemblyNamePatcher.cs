using HarmonyLib;
using System.Reflection;

namespace AssemblyNamePatcher
{
    class AssemblyNamePatcher
    {
        [HarmonyPatch(typeof(AssemblyName), "Create")]
        [HarmonyPrefix]
        static void CreatePrefix(ref bool fillCodebase)
        {
            fillCodebase = false;
        }
    }
}
