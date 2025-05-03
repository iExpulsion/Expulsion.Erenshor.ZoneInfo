using System;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace Expulsion.Erenshor.ZoneInfo.Patches
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.ShowZoneName))]
    public class GameManager_ShowZoneName
    {
        public static void Postfix(GameManager __instance, string _name)
        {
            var sceneName = SceneManager.GetActiveScene().name;

            __instance.ZoneName.text += sceneName switch
            {
                // Open World Zones
                "Azure" => $"\n{StyleString("Level 1 - 35")}",
                "Stowaway" => $"\n{StyleString("Level 1 - 6")}",
                "Hidden" => $"\n{StyleString("Level 4 - 8")}",
                "Brake" => $"\n{StyleString("Level 3 - 10")}",
                "Vitheo" => $"\n{StyleString("Level 4 - 10")}",
                "FernallaField" => $"\n{StyleString("Level 6 - 18")}",
                "Duskenlight" => $"\n{StyleString("Level 7 - 19")}",
                "Rottenfoot" => $"\n{StyleString("Level 12 - 20")}",
                "SaltedStrand" => $"\n{StyleString("Level 14 - 21")}",
                "Braxonian" => $"\n{StyleString("Level 16 - 25")}",
                "Loomingwood" => $"\n{StyleString("Level 18 - 26")}",
                "Silkengrass" => $"\n{StyleString("Level 10 - 30")}",
                "Windwashed" => $"\n{StyleString("Level 15 - 30")}",
                "Malaroth" => $"\n{StyleString("Level 20 - 30")}",
                "Soluna" => $"\n{StyleString("Level 25 - 33")}",
                "Blight" => $"\n{StyleString("Level 26 - 33")}",
                "Ripper" => $"\n{StyleString("Level 28 - 33")}",
                "Azynthi" => $"\n{StyleString("Level 30 - 35")}",
                "AzynthiClear" => $"\n{StyleString("Level 30 - 35")}",

                // Dungeons
                "Tutorial" => $"\n{StyleString("Level 3 - 7")}",
                "Bonepits" => $"\n{StyleString("Level 4 - 9")}",
                "Krakengard" => $"\n{StyleString("Level 8 - 13")}",
                "Underspine" => $"\n{StyleString("Level 10 - 16")}",
                "Undercity" => $"\n{StyleString("Level 13 - 20")}",
                "DuskenPortal" => $"\n{StyleString("Level 14 - 15")}",
                "FernallaPortal" => $"\n{StyleString("Level 21 - 24")}",
                "RipperPortal" => $"\n{StyleString("Level 28 - 35")}",
                "Elderstone" => $"\n{StyleString("Level 16 - 21")}",
                "Rockshade" => $"\n{StyleString("Level 22 - 26")}",
                "Abyssal" => $"\n{StyleString("Level 24 - 33")}",
                "Braxonia" => $"\n{StyleString("Level 28 - 33")}",
                "PrielPlateau" => $"\n{StyleString("Level 28 - 35")}",
                "VitheosEnd" => $"\n{StyleString("Level 22 - 35")}",
                "Jaws" => $"\n{StyleString("Level 30 - 35")}",

                // Events
                "ShiveringStep" => $"\n{StyleString("Level 6 - 12")}",
                "ShiveringTomb" => $"\n{StyleString("Level 6 - 12")}",
                _ => $"\n<size=25%>Unknown Zone of Name: [{sceneName} | {_name}], Please Report</size>"
            };
        }

        private static string StyleString(string text)
        {
            var playerLevel = GameData.PlayerStats.Level;

            var zoneLevelMinMax = text.Replace("Level ", "").Split('-');

            if (zoneLevelMinMax.Length != 2 ||
                !int.TryParse(zoneLevelMinMax[0].Trim(), out var minLevel) ||
                !int.TryParse(zoneLevelMinMax[1].Trim(), out var maxLevel))
            {
                return $"<size=50%>{text}</size>";
            }

            var colorHex = playerLevel switch
            {
                _ when playerLevel < minLevel - 5 => "#f44336",
                _ when playerLevel < minLevel => "#ff9800",
                _ when playerLevel <= maxLevel => "#ffeb3b",
                _ when playerLevel <= maxLevel + 5 => "#4caf50",
                _ => "#808080"
            };

            return $"<size=50%><color={colorHex}>{text}</color></size>";
        }
    }
}