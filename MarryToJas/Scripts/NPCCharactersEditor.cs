using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;


namespace MarryToJas.Scripts
{
    class NPCCharactersEditor : ModScript, IAssetLoader
    {
        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_chara))
                return true;
            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals(Const.Jas_chara))
            {
                return this.Helper.Content.Load<T>("assets/Characters/Jas.png", ContentSource.ModFolder);
            }
            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}
