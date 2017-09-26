using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace AGSmod.Items
{
	public class stargooper : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Stargooper");
			Tooltip.SetDefault("Converts gel into fallen stars!"); //lol
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 6; //gotta go fast
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0.0720f;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 12; //stars motherfuckers!! we done it bitches
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Gel; //change to bullets if this doesnt work
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 72); //made fairer to get
            recipe.AddIngredient(ItemID.Gel, 99);
            recipe.AddIngredient(ItemID.FlintlockPistol, 1);
			recipe.AddTile(TileID.MythrilAnvil); //this is how it works right? mythril for hardmode even though all anvils is just anvils. even so fuck orichalcum
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
	}
}        