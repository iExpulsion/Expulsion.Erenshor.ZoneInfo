using BepInEx;
using HarmonyLib;

namespace Expulsion.Erenshor.ZoneInfo
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "Expulsion.Erenshor.ZoneInfo";
        public const string PluginName = "ZoneInfo";
        public const string PluginVersion = "1.0.3";

        private Harmony? _harmonyInstance;

        private void Awake()
        {
            _harmonyInstance = new Harmony(PluginGuid);
            _harmonyInstance.PatchAll();

            Logger.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private void OnDestroy()
        {
            _harmonyInstance?.UnpatchSelf();
        }
    }
}