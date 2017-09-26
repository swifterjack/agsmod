using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AGSmod.Items
{
	public class RFBS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Really Fucking Big Floating Sword");
			Tooltip.SetDefault("big");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 1;
			item.knockBack = 666;
			item.value = 420;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Pearlwood, 1);
			recipe.AddTile(TileID.Pigronata);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
