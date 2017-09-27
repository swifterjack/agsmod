using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AGSmod.Items
{
	public class Fodle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fodle");
			Tooltip.SetDefault("Happy Birthday!");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.CursedSapling);
			item.shoot = mod.ProjectileType("fodlepet");
			item.buffType = mod.BuffType("fodlepet");
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DesertGhoulBanner, 1);
            recipe.AddIngredient(ItemID.MusicBoxDungeon, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}