using MarryToJas.Contents.Game;
using System;
using System.Collections.Generic;

namespace MarryToJas.Contents
{
    public static class Events
    {
        const int EventIDHandler = 8709;

        public static readonly Dictionary<string, string> AnimalShopEvent = new Dictionary<string, string>
        {
            [$"{GenerateEventKey(GameLocation.AnimalShop, false, 0, null)}"] = "",
        };

        static string GenerateEventKey(
            GameLocation location, // 地点
            bool bFestival, // 是否为节日
            uint bUnfindFestival, // 从今天起指定的天数内没有节日
            List<Weekday> undayOfWeeks, // 今天不是指定的日期之一
            float Random = 1.0f, // 触发概率
            GameNpc? specialNpc = null, // 需要特定NPC可见
            GameWeather? weather = null, // 指定当前天气
            GameSeason? exceptSeason = null // 非当前季节可触发
            )
        {
            return null;
        }
    }
}
