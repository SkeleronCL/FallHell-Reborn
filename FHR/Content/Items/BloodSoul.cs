using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace FHR.Content.Items
{
    public class BloodSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 4));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;

            ItemID.Sets.ItemIconPulse[Item.type] = true;
            ItemID.Sets.ItemNoGravity[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 28;

            Item.rare = ItemRarityID.Blue;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(0, 0, 8, 60);
        }
        
        public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.Red.ToVector3() * 0.55f * Main.essScale);
		}

		public override Color? GetAlpha(Color lightColor) {
			return new Color(255, 255, 255, 34);
		}
    }
}