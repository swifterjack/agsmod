/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AGSmod;

namespace AGSmod.Items
{
	public class fodle : ModItem 
	{
		public new void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fodle");
			Tooltip.SetDefault("Summons a Fodle to shill Ghoulie's Dungeon for you.");
		}

		public new void SetDefaults()
		{
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("fodle");
			item.buffType = mod.BuffType("fodle");
		}

		public new void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DesertGhoulBanner, 1);
            recipe.AddIngredient(ItemID.MusicBoxDungeon, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public new void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}*/