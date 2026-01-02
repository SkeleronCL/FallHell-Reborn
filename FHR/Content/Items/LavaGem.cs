using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;

namespace FHR.Content.Items
{
    public class LavaGem : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;

            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(1);
        }

        public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.OrangeRed.ToVector3() * 0.40f);
		}
    }
}