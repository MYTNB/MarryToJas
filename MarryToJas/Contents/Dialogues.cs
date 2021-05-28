using System;
using System.Collections.Generic;

namespace MarryToJas.Contents
{
    public static class Dialogues
    {
        public static readonly Dictionary<string, string> Jas = new Dictionary<string, string>
        {
            // 介绍
            ["Introduction"] = "……$u#$b#你好……$u",
            // 花舞节拒绝邀请
            ["danceRejection"] = "... 抱歉, 我不太愿意...$u",
            /* 被抛弃后(触发修罗场) */
            ["dumped_Girls"] = "", //TODO
            ["secondChance_Girls"] = "", //TODO
            // 分手
            ["breakUp"] = "", //TODO
            // 离婚
            ["divorced"] = "…求求你，快走开。$s",

            // 参考 https://stardewvalleywiki.com/Modding:Dialogue#Character-specific_dialogue
        };
    }
}
