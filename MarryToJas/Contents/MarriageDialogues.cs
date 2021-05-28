using System;
using System.Collections.Generic;
namespace MarryToJas.Contents
{
    public static class MarriageDialogues
    {
        public static readonly Dictionary<string, string> Jas = new Dictionary<string, string>
        {
            // 季节-日期 对话
            ["spring_1"] = "漫长的冬天终于过去了！我又可以去森林里玩啦！#$1" +
            "#$b但是@，我刚刚出门看了一眼，我们的农场已经变成一团糟了……#$2" +
            "#$b这就拜托你喽亲爱的！#$1" +
            "#$b但是，但是我一定会好好吃饭，争取长大后帮上忙的！" +
            "#$e就算这么说了也得去帮忙？嘤嘤嘤。",
            ["spring_14"] = "时间过得真快呀@，春天都过去了一半儿啦！我都有好好喝牛奶哦！你看我长高了吗？#$l",
            ["spring_28"] = "呜呜呜，明天就看不见农场里的草莓了，我会想他们的。$2",
            ["summer_1"] = "天气开始变热了呢，已经开始想吃牛奶冰淇淋了！$1#$e可是现在就吃的话，我会不会肚子疼呀，你说呢#@？",

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
}
