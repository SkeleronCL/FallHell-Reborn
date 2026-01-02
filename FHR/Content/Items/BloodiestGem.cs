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
    public class BloodiestGem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 8));
        }
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 24;
            
            Item.rare = ItemRarityID.Green;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(1);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BloodyBone>())
                .AddIngredient(ModContent.ItemType<BloodSoul>(), 15)
                .AddIngredient(ModContent.ItemType<LavaGem>())
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}