using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AGSmod.Items
{
	public class BTSB : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("bow that shoots bullets");
			Tooltip.SetDefault("I fucking said i would bitch");
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 900;
			item.value = 0;
			item.rare = 3;
			item.autoReuse = true;
			item.noMelee = true;
			item.shoot = 14;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Pigronata, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}