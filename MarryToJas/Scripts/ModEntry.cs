using System;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using System.Linq;

namespace MarryToJas.Scripts
{
    public class ModEntry : Mod, IAssetEditor, IAssetLoader
    {
        public static ModEntry Instance { get; private set; } = null;

        private List<ModScript> Scripts = new List<ModScript>();

        public override void Entry(IModHelper helper)
        {
            Instance = this;
            Type scriptType = typeof(ModScript);
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes().Where(type=>type != scriptType && type.IsSubclassOf(scriptType)))
            {
                if (!type.IsAbstract)
                {
                    ModScript script = Activator.CreateInstance(type) as ModScript;
                    if (script is null) continue;

                    Scripts.Add(script);
                }
            }

            this.Monitor.Log($"Mod Entry! Scripts Number: {Scripts.Count}", LogLevel.Info);

            foreach(ModScript script in Scripts)
            {
                script.Entry();
            }
        }

        public bool CanEdit<T>(IAssetInfo asset)
        {
            foreach (ModScript script in Scripts)
            {
                if (script is IAssetEditor)
                {
                    bool res = (script as IAssetEditor).CanEdit<T>(asset);
                    if (res) return true;
                }
            }
            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            foreach (ModScript script in Scripts)
            {
                if (script is IAssetEditor)
                {
                    IAssetEditor editor = script as IAssetEditor;
                    if (editor.CanEdit<T>(asset))
                    {
                        editor.Edit<T>(asset);
                    }
                }
            }
        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            foreach (ModScript script in Scripts)
            {
                if (script is IAssetLoader)
                {
                    bool res = (script as IAssetLoader).CanLoad<T>(asset);
                    if (res) return true;
                }
            }
            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {
            foreach (ModScript script in Scripts)
            {
                if (script is IAssetLoader)
                {
                    IAssetLoader editor = script as IAssetLoader;
                    if (editor.CanLoad<T>(asset))
                    {
                        return editor.Load<T>(asset);
                    }
                }
            }
            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}
