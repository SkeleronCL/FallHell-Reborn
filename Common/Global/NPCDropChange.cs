using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;
using FHR.Common.DropCondition.BloodMoonDrop;

namespace FHR.Common.Global
{
    public class ExampleNPCLoot : GlobalNPC
    {
        public override void ModifyGlobalLoot(GlobalLoot globalLoot) {
			
			globalLoot.Add(ItemDropRule.ByCondition(new BloodMoonDropCondition(), ModContent.ItemType<BloodSoul>(), 5, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new BloodMoonDropCondition(), ModContent.ItemType<BloodyNugget>(), 3, 1, 1));
		}
    }
}
