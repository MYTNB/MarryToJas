using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace MarryToJas.Scripts
{
    class NPCDialogEditor : ModScript, IAssetEditor, IAssetLoader
    {
        public bool CanEdit<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Dialog))
                return true;
            else if (asset.AssetNameEquals(Const.Jas_Schedule_Dialog))
                return true;
            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Dialog))
            {
                IDictionary<string, string> data = asset.AsDictionary<string, string>().Data;
                foreach(var item in Contents.Dialogues.Jas)
                {
                    data[item.Key] = item.Value;
                }
            }
            else if (asset.AssetNameEquals(Const.Jas_Schedule_Dialog))
            {

            }
        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Marriage_Dialog))
                return true;
            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Marriage_Dialog))
            {
                return (T)(object)Contents.MarriageDialogues.Jas;
            }
            throw new NotImplementedException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}
