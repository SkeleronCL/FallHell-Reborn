using Terraria;
using Terraria.ID;
using Terraria.ObjectData;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;

namespace FHR.Content.Tiles
{
    public class BloodyBarT : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileShine[Type] = 1100;
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            VanillaFallbackOnModDeletion = TileID.MetalBars;

            AddMapEntry(new Color(247, 16, 16), Language.GetText("MapObject.MetalBar"));
        }

        public override bool TileFrame(int i, int j, ref bool resetFrame, ref bool noBreak) {
			
			if (!WorldGen.SolidTileAllowBottomSlope(i, j + 1)) {
				WorldGen.KillTile(i, j);
			}
			return true;
		}
    }
}