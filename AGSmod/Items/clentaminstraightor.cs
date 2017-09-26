using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace AGSmod.Items
{
	public class clentaminstraightor : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Vile Dustgun");
			Tooltip.SetDefault("Banishes the Hallow slowly, but for free, and without touching the evil.");
		}

		public override void SetDefaults()
		{
			item.useTime = 11; //gotta go fast
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item24;
			item.autoReuse = true;
			item.shoot = 11; //poff
			item.shootSpeed = 150f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Clentaminator, 1);
            recipe.AddIngredient(ItemID.VilePowder, 15);
            recipe.AddIngredient(ItemID.PurpleSolution, 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
			recipe.AddTile(TileID.MythrilAnvil); //this is how it works right? mythril for hardmode even though all anvils is just anvils. even so fuck orichalcum
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 5 + Main.rand.Next(2); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(45);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		
	}
}        