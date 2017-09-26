using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace AGSmod.Items
{
	public class lotsofbees : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Instant Bees");
			Tooltip.SetDefault("It's just bees. So many bees.");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
			item.thrown = true;
			item.width = 6;
			item.height = 3;
			item.useTime = 0;
			item.shootSpeed = 1;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 3;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 181;
			item.noMelee = true;
			item.noUseGraphic = true;
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HiveWand, 1);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddTile(TileID.Pigronata);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2; // 3, 4, or 5 shots
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