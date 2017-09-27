using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AGSmod.Projectiles.Pets
{
	public class fodlepet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("fodlepet");
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CursedSapling);
			aiType = ProjectileID.CursedSapling;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			//player.cursedsapling = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			AGSplayer modPlayer = player.GetModPlayer<AGSplayer>(mod);
			if (player.dead)
			{
				modPlayer.fodlepet = false;
			}
			if (modPlayer.fodlepet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}