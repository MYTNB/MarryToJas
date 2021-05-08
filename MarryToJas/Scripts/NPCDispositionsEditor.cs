using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace MarryToJas.Scripts
{
    // 设置Npc可以结婚
    class NPCDispositionsEditor : ModScript, IAssetEditor
    {
        public bool CanEdit<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Data/NPCDispositions"))
                return true;
            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            if (asset.AssetNameEquals("Data/NPCDispositions"))
            {
                IDictionary<string, string> data = asset.AsDictionary<string, string>().Data;
                if (data != null && data.TryGetValue("Jas", out string info))
                {
                    string[] fields = info.Split('/');
                    fields[5] = "datable";
                    data["Jas"] = string.Join("/", fields);
                }
                else
                {
                    this.Monitor.Log($"Edit NPCDispositions Failed: {asset.AssetName}");
                }
            }
        }
    }
}
