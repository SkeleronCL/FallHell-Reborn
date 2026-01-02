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
using System.Runtime.CompilerServices;

namespace FHR.Content.Items
{
    public class PinkDiamond : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;

            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(1);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Diamond, 1)
                .AddIngredient(ItemID.Ruby, 2)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}