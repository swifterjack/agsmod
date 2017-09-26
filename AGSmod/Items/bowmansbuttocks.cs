using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AGSmod.Items
{
	public class bowmansbuttocks : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowman's Buttocks");
			Tooltip.SetDefault("You're really saving a LOT of arrows.");
		}
		public override void SetDefaults()
		{
			item.damage = 720;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 450850;
			item.rare = 10;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/buttocks");
			item.autoReuse = true;
			item.noMelee = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 00.35f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DiscountCard, 1);
			recipe.AddIngredient(ItemID.LunarOre, 72);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
