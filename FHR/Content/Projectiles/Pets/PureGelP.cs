using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Pets;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;
using FHR.Content.Projectiles;
using FHR.Content.Buffs;

namespace FHR.Content.Projectiles.Pets
{
    public class PureGelP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Type] = 5;
            Main.projPet[Type] = true;

            
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.KingSlimePet);

            AIType = ProjectileID.KingSlimePet;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];

            player.petFlagKingSlimePet = false;

            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            
            if (!player.dead && player.HasBuff(ModContent.BuffType<BloodyGelBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}