using HarmonyLib;

namespace Expulsion.Erenshor.ZoneInfo.Patches
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.ShowZoneName))]
    public class GameManager_ShowZoneName
    {
        public static void Postfix(GameManager __instance, string _name)
        {
            __instance.ZoneName.text = _name switch
            {
                // Open World Zones
                "Port Azure" => "Port Azure\n<size=75%>Level 1 - 35</size>",
                "Stowaway's Step" => "Stowaway's Step\n<size=75%>Level 1 - 6</size>",
                "Hidden Hills" => "Hidden Hills\n<size=75%>Level 4 - 8</size>",
                "Faerie's Brake" => "Faerie's Brake\n<size=75%>Level 3 - 10</size>",
                "Vitheo's Watch" => "Vitheo's Watch\n<size=75%>Level 4 - 10</size>",
                "Fernalla's Revival Plains" => "Fernalla's Revival Plains\n<size=75%>Level 6 - 18</size>",
                "Duskenlight Coast" => "Duskenlight Coast\n<size=75%>Level 7 - 19</size>",
                "Rottenfoot" => "Rottenfoot\n<size=75%>Level 12 - 20</size>",
                "Blacksalt Strand" => "Blacksalt Strand\n<size=75%>Level 14 - 21</size>",
                "Braxonian Desert" => "Braxonian Desert\n<size=75%>Level 16 - 25</size>",
                "Loomingwood" => "Loomingwood\n<size=75%>Level 18 - 26</size>",
                "Silkengrass Meadowlands" => "Silkengrass Meadowlands\n<size=75%>Level 10 - 30</size>",
                "Windwashed Pass" => "Windwashed Pass\n<size=75%>Level 15 - 30</size>",
                "Malaroth's Nesting Grounds" => "Malaroth's Nesting Grounds\n<size=75%>Level 20 - 30</size>",
                "Soluna's Landing" => "Soluna's Landing\n<size=75%>Level 25 - 33</size>",
                "The Blight" => "The Blight\n<size=75%>Level 26 - 33</size>",
                "Ripper's Keep" => "Ripper's Keep\n<size=75%>Level 28 - 33</size>",
                "Azynthi's Garden" => "Azynthi's Garden\n<size=75%>Level 30 - 35</size>",
                
                // Dungeons
                "Island Tomb" => "Island Tomb\n<size=75%>Level 3 - 7</size>",
                "The Bone Pits" => "The Bone Pits\n<size=75%>Level 4 - 9</size>",
                "Old Krakengard" => "Old Krakengard\n<size=75%>Level 8 - 13</size>",
                "Underspine Hollow" => "Underspine Hollow\n<size=75%>Level 10 - 16</size>",
                "Lost Cellar" => "Lost Cellar\n<size=75%>Level 13 - 20</size>",
                "Mysterious Portal - Duskenlight Coast" => "Mysterious Portal - Duskenlight Coast\n<size=75%>Level 14 - 15</size>",
                "Mysterious Portal - Fernalla's Ritual Plains" => "Mysterious Portal - Fernalla's Ritual Plains\n<size=75%>Level 21 - 24</size>",
                "Mysterious Portal - Ripper's Keep" => "Mysterious Portal - Ripper's Keep\n<size=75%>Level 28 - 35</size>",
                "Elderstone Mines" => "Elderstone Mines\n<size=75%>Level 16 - 21</size>",
                "Rockshade Hold" => "Rockshade Hold\n<size=75%>Level 22 - 26</size>",
                "Abyssal Lake" => "Abyssal Lake\n<size=75%>Level 24 - 33</size>",
                "Fallen Braxonia" => "Fallen Braxonia\n<size=75%>Level 28 - 33</size>",
                "Prielian Cascade" => "Prielian Cascade\n<size=75%>Level 28 - 35</size>",
                "Vitheo's Rest" => "Vitheo's Rest\n<size=75%>Level 22 - 35</size>",
                "Jaws of Sivakaya" => "Jaws of Sivakaya\n<size=75%>Level 30 - 35</size>",

                _ => __instance.ZoneName.text + "\n<size=25%>Unknown Zone, Please Report</size>"
            };
        }
    }
}