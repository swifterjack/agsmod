using Terraria.ID;
using Terraria.ModLoader;
using AGSmod.Items;

namespace AGSmod.Items
{
	public class slashfiction : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slash Fiction");
			Tooltip.SetDefault("Jagged for your pleasure.");
		}
		public override void SetDefaults()
		{
			item.damage = 27;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 14;
			item.value = 6969;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = 54;
            item.shootSpeed = 16f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("roxygen"));
			recipe.AddIngredient(ItemID.HellstoneBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
