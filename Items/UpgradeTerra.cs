using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items
{
	public class UpgradeTerra : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Terra Storage Upgrade";
			item.toolTip = "Upgrades Storage Unit to 640 capacity";
			item.toolTip2 = "Right-click a Luminite Storage Unit to use";
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.rare = 11;
			item.value = Item.sellPrice(0, 10, 0, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RadiantJewel");
			recipe.AddIngredient(ItemID.Diamond);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

			Mod otherMod = ModLoader.GetMod("Bluemagic");
			if (otherMod != null)
			{
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(otherMod, "InfinityCrystal");
				recipe.AddIngredient(ItemID.Diamond);
				recipe.AddTile(otherMod, "PuriumAnvil");
				recipe.SetResult(this);
				recipe.AddRecipe();
			}

			otherMod = ModLoader.GetMod("CalamityMod");
			if (otherMod != null)
			{
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(otherMod, "CosmiliteBar", 20);
				recipe.AddIngredient(ItemID.Diamond);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}