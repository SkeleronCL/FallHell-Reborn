using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;
using Humanizer;

namespace FHR.Content.NPCs;

public class BloodSlime : ModNPC
{
    public override void SetStaticDefaults()
    {
        Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.SandSlime];

        // NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
        // {
        //     // Influences how the NPC looks in the Bestiary
        //     Velocity = 1f // Draws the NPC in the bestiary as if its walking +1 tiles in the x direction
        // };
        // NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
    }

    public override void SetDefaults()
    {
        NPC.width = 38;
        NPC.height = 30;
        NPC.damage = 10;
        NPC.defense = 6;
        NPC.lifeMax = 40;
        NPC.HitSound = SoundID.NPCHit1;
        NPC.DeathSound = SoundID.NPCDeath1;
        NPC.value = 1f;
        NPC.knockBackResist = 2.3f;
        NPC.aiStyle = NPCAIStyleID.Slime;

        AIType = NPCID.IceSlime;
        AnimationType = NPCID.SandSlime;
    }

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (Main.bloodMoon)
        {
            return 1f;
        }
        else
        {
            return 0f;
        }
    }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
        bestiaryEntry.Info.AddRange([

           BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Events.BloodMoon 
        ]);
    }

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodyGel>(), 1, 10, 30));
    }
 }