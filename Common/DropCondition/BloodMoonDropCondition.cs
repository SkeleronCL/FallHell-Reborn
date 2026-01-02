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

namespace FHR.Common.DropCondition.BloodMoonDrop
{
	public class BloodMoonDropCondition : IItemDropRuleCondition
	{
		private static LocalizedText Description;

		public BloodMoonDropCondition() {
			Description ??= Language.GetOrRegister("Mods.FHR.DropCondition.BloodMoonDrop");
		}

		public bool CanDrop(DropAttemptInfo info) {
			NPC npc = info.npc;
			return Main.bloodMoon
				&& !NPCID.Sets.CannotDropSouls[npc.type]
				&& !npc.boss
				&& !npc.friendly
				&& npc.lifeMax > 1
				&& npc.value >= 1f;
				// && info.player.InZonePurity;
		}

		public bool CanShowItemDropInUI() {
			return true;
		}

		public string GetConditionDescription() {
			return Description.Value;
		}
	}
}