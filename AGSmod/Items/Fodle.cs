using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AGSmod.Items
{
        public class Fodle : ModItem
        {
            public override void SetStaticDefaults()
            {   
                DisplayName.SetDefault("Fodle");
                Tooltip.SetDefault("Happy birthday!");
            }
            
            public override void SetDefaults()
            {
                item.useStyle = 4;
                item.useTime = 16;
                item.expert = true;
                item.rare = 3;
                item.stack = 1;
                item.useAnimation = 16;
                item.autoReuse = true;
                item.makeNPC = 	398;
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

        }
}