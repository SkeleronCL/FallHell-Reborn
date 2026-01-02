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
    public class UnfaithfulArrowP : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 14;
			Projectile.height = 32;

			Projectile.DamageType = DamageClass.Ranged;
			Projectile.timeLeft = 1200;

			Projectile.arrow = true;
			Projectile.friendly = true;
        }

        public override void AI()
        {
			if (Projectile.ai[0] >= 15f) {
				Projectile.ai[0] = 15f;
				Projectile.velocity.Y += 0.1f;
			}

			Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

			if (Projectile.velocity.Y > 16f) {
				Projectile.velocity.Y = 16f;
			}

            if (Main.rand.NextBool(10)) {
				Dust dust = Dust.NewDustDirect(Projectile.position + Projectile.velocity * Main.rand.Next(6, 10) * 0.15f, Projectile.width, Projectile.height, DustID.Crimstone, 0f, 0f, 35, Color.Red, 0.9f);
				dust.position.X -= 4f;
				dust.noGravity = true;
				dust.velocity.X *= 0.5f;
				dust.velocity.Y = -Main.rand.Next(3, 8) * 0.1f;
			}
        }

            public override void OnKill(int timeLeft) {
			SoundEngine.PlaySound(SoundID.Dig, Projectile.position);    
			for (int i = 0; i < 10; i++)
			{
				Dust dust = Dust.NewDustDirect(Projectile.position + Projectile.velocity * Main.rand.Next(6, 10) * 0.15f, Projectile.width, Projectile.height, DustID.Crimstone, 0f, 0f, 35, Color.Red, 0.9f);
				dust.noGravity = true;
				dust.velocity *= 1.5f;
				dust.scale *= 0.9f;
			}
		}
    }


}