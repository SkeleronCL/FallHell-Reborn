using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;

namespace FHR.Content.Items
{
    public class BloodyNugget : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;

            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(1,1,1,1);
        }
    } 
}