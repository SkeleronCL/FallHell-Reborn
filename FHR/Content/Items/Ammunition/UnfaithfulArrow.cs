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
using FHR.Content.Projectiles;

namespace FHR.Content.Items.Ammunition
{
    public class UnfaithfulArrow : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 32;

            Item.rare = ItemRarityID.Blue;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice (1);
            Item.consumable = true;

            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 3f;
            Item.ammo = AmmoID.Arrow;

            Item.shoot = ModContent.ProjectileType<UnfaithfulArrowP>();
            Item.shootSpeed = 3.4f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 5)
                .AddIngredient(ItemID.Vertebrae)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}