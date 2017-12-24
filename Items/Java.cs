using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LiZhiLaugh.Items
{
	public class Java : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("爪哇咖啡");
			Tooltip.SetDefault("某只芋头可能很喜欢喝?\n饮用后增加拾心范围和生命回复，增加100%移动速度");
		}

		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
			item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
			item.maxStack = 30;
			item.consumable = true;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = 5;
			item.buffType = mod.BuffType<Buffs.JavaBuff>();
			item.buffTime = 10000;
			return;
		}

	}
}