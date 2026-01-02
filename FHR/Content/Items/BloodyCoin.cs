using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using FHR.Content.Items.Placemble;

namespace FHR.Content.Items
{
    public class BloodyCoin : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 16;

            Item.rare = ItemRarityID.Gray;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(0, 0, 0, 0); Item.sellPrice(1, 0, 0, 0);
        }

        public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.Red.ToVector3() * 1f * Main.essScale);
		}

		public override Color? GetAlpha(Color lightColor) {
			return new Color(255, 255, 255, 50);
		}

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BloodyBar>(), 1)
                .AddIngredient(ModContent.ItemType<BloodyNugget>(), 4)
                .AddTile(TileID.Anvils)
                .Register();
        }
    } 
}