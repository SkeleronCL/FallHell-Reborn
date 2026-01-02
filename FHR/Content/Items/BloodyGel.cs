using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace FHR.Content.Items
{
    public class BloodyGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(12, 8));
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 14;

            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice ();
        }
    }
}