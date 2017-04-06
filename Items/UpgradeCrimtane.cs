using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items
{
	public class UpgradeCrimtane : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crimtane Storage Upgrade";
			item.toolTip = "Upgrades Storage Unit to 80 capacity";
			item.toolTip2 = "Right-click a Storage Unit to use";
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.rare = 1;
			item.value = Item.sellPrice(0, 0, 32, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddIngredient(ItemID.Amethyst);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}