using Terraria;
using Terraria.ModLoader;

namespace LiZhiLaugh.Items
{
	public class CuckoosFeather : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("顾鹃之羽");
			Tooltip.SetDefault("顾鹃的羽毛");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 1;
		}

	}
	
}