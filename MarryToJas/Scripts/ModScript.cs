using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace MarryToJas.Scripts
{
    abstract class ModScript
    {
        public IModHelper Helper => ModEntry.Instance.Helper;

        public IMonitor Monitor => ModEntry.Instance.Monitor;

        public IManifest ModManifest => ModEntry.Instance.ModManifest;

        public virtual void Entry()
        {
            this.Monitor.Log($"{GetType().Name} Entry", LogLevel.Debug);
        }
    }
}
