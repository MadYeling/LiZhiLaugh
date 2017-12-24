using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LiZhiLaugh.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class CuckoosWing : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("顾鹃之翼");
			Tooltip.SetDefault("从顾鹃身上扒下来的翅膀(?)\n拥有500飞行时间");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000000;
			item.rare = 7;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 500;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.35f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 15f;
			acceleration *= 2.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CuckoosFeather", 50);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}