using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;

namespace FHR.Content.Projectiles
{
	public class BoneWarriorP : ModProjectile
	{
        public override void SetDefaults()
        {
            Projectile.width = 64;
			Projectile.height = 64;
			Projectile.scale = 1.5f;

			Projectile.DamageType = DamageClass.Melee;
			Projectile.friendly = true;
			Projectile.hostile = false;

			AIType = ProjectileID.Excalibur;
			
			Projectile.penetrate = 10;
			Projectile.tileCollide = false;
			Projectile.ignoreWater = true;
			Projectile.ownerHitCheck = true;
			Projectile.ownerHitCheckDistance = 300f;
			Projectile.usesOwnerMeleeHitCD = true;
			Projectile.stopsDealingDamageAfterPenetrateHits = true;
        }
	}
}