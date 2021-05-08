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
            else if (asset.AssetNameEquals(Const.Jas_Dialog_Schedule))
                return true;
            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Dialog))
            {
                IDictionary<string, string> data = asset.AsDictionary<string, string>().Data;
                foreach(var item in Dialogs)
                {
                    data[item.Key] = item.Value;
                }
            }
            else if (asset.AssetNameEquals(Const.Jas_Dialog_Schedule))
            {

            }
        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Dialog_Marriage))
                return true;
            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_Dialog_Marriage))
            {
                return (T)(object)new Dictionary<string, string>
                {
                    // 季节-日期 对话
                    ["<season>_<day>"] = "",
                    // 露台 对话
                    ["patio_Jas"] = "",
                    // 天气-随机(0-5) 日常对话
                    ["<weather>_Day_<random>"] = "",
                    // 雨夜-随机(0-5) 对话
                    ["Rainy_Night_<random>"] = "",
                    // 非雨夜-随机(0-4) 日常对话
                    ["Indoor_Night_<random>"] = "",
                    // 参考 https://stardewvalleywiki.com/Modding:Dialogue#Marriage_dialogue
                };
            }
            throw new NotImplementedException($"Unexpected asset '{asset.AssetName}'.");
        }

        private readonly Dictionary<string, string> Dialogs = new Dictionary<string, string> {
            { "Introduction", "……$u#$b#你好……$u"},
            { "danceRejection", "... 抱歉, 我不太愿意...$u" },
            { "dumped_Girls", "" }, //TODO
            { "secondChance_Girls", "" }, //TODO
            { "breakUp", "" }, //TODO
            { "divorced", "…求求你，快走开。$s" },
            /* 度假胜地相关 */
            { "Resort", "" },
            // 通常好感动对话
            { "", "" },
            // 参考 https://stardewvalleywiki.com/Modding:Dialogue#Character-specific_dialogue
        };
    }
}
