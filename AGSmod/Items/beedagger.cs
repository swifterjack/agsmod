using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AGSmod.Items
{
	public class beedagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moon-Stinger");
			Tooltip.SetDefault("You know what? Fuck you. Fuck shortswords. Just experience pain. Not enemies, you.");
		}
		public override void SetDefaults()
		{
			item.damage = 666;
			item.melee = true;
			item.width = 6;
			item.height = 3;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 666;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 20);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddTile(TileID.Pigronata);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
