using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;


namespace MarryToJas.Scripts
{
    class NPCSchedulesEditor : ModScript, IAssetEditor
    {
        public bool CanEdit<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Characters/schedules/Jas"))
                return true;
            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            if (asset.AssetNameEquals("Characters/schedules/Jas"))
            {
                IDictionary<string, string> data = asset.AsDictionary<string, string>().Data;
                if (data != null)
                {
                    // 结婚周一: 9:00am 前往AnimalShop 位置(15, 17) 朝向3(左)
                    data["marriage_Mon"] = "900 AnimalShop 15 17 3 jas_read \"我今天会去看望玛尼.她的小鸡长得很好！\"/1800 BusStop -1 23 3";

                }
                else
                {
                    this.Monitor.Log($"Edit NPCSchedules Failed: {asset.AssetName}");
                }
            }
        }
    }
}
