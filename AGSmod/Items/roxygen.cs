using Terraria.ID;
using Terraria.ModLoader;

namespace AGSmod.Items
{
	public class roxygen : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Roxygen Cutlass");
			Tooltip.SetDefault("Inherently superior to Johnvris swords.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 69;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddIngredient(ItemID.BlackLens, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
