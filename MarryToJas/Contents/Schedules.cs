using MarryToJas.Contents.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarryToJas.Contents
{
    public static class Schedules
    {
        public static readonly Dictionary<string, string> Jas = new Dictionary<string, string>
        {
            /* 婚后行动 */
            ["marriage_<season>_<day of month>"] = "",
            ["marriage_<day of week>"] = "",

            /* 正常时间行动 */
            ["<season>_<day of month>"] = "",
            ["<day of month>_<hearts>"] = "",
            ["<day of month>"] = "",
            // 雨天50%概率选择
            ["rain2"] = "", 
            ["rain"] = "",
            ["<season>_<day of week>_<hearts>"] = "",
            ["<season>_<day of week>"] = "",
            ["<day of week>"] = "",
            ["<season>"] = "",
        };

        enum GameCharaFaceDirection
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3,
            Default = Down,
        }

        enum GameCharaAnimation
        {
            /* Jas */
            Jas_Read,
            jas_jumprope,
            jas_sleep,
        }

        static string Create(
            uint hour, // 小时 (24 hour format)
            uint min10, // 分钟 (10的倍数)
            GameLocation location, // 地图位置
            uint tileX, // 地图地块坐标X
            uint tileY, // 地图地块坐标Y
            GameCharaFaceDirection faceDirection, // 朝向
            GameCharaAnimation charaAnimation, // 角色动画
            string dialogFilepath, // 对话文件(like "A\\b\\C")
            string dialogKey // 对话项
            )
        {
            if (hour > 24) return null;
            if (min10 > 6) return null;
            if (hour == 6 && min10 == 0) min10 += 1;
            return $"{hour}{min10}0 {location.ToString()} {tileX} {tileY} {faceDirection} {charaAnimation.ToString().ToLower()} " +
                $"\"{dialogFilepath}: {dialogKey}\"";
        }

    }
}
