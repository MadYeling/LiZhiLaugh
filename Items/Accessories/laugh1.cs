using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LiZhiLaugh.Items.Accessories
{
    public class laugh1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("邪魅一笑的饰品");
            Tooltip.SetDefault("这是荔枝的邪魅一笑，威力巨大(?)\n荔枝：啊哈哈\n增加150%移动速度和70%近战速度\n增加50%伤害和暴击几率");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.rare = 10;
            item.accessory = true;
            item.value = Item.sellPrice(99, 0, 0, 0);

        }

        public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 1.5f;
            player.meleeSpeed += .7f;
			player.magicDamage += .5f;
			player.meleeDamage += .5f;
			player.rangedDamage += .5f;
			player.minionDamage += .5f;
			player.thrownDamage += .5f;
            player.magicCrit += 50;
			player.meleeCrit += 50;
			player.thrownCrit += 50;
			player.rangedCrit += 50;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}