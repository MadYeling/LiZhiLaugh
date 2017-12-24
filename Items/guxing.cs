using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LiZhiLaugh.Items

{

    public class guxing : ModItem

    {
        public override void SetStaticDefaults()

		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("孤星剑");
            Tooltip.SetDefault("“这可能是荔枝用的剑....吗？”\n拥有溢出值一半的伤害和较高的攻击速度\n不宜配合增加伤害的物品使用\n-呔，大胆Boss，吔我一记孤星剑！-");
		}

        public override void SetDefaults()

        {
            item.height = 40;
            item.width = 40;
            item.useTime = 6;           //武器使用间隔时长
            item.useAnimation = 6;      //武器挥舞速度
            item.useStyle = 1;          //使用方式,1是挥动，5是枪那样的，3是橫持
            item.rare = 5;              //物品品质
            item.autoReuse = true;      //是否连发
            item.damage = 1027483647;         //武器伤害
            item.value = 1000000;       //售价，单位铜币
            item.melee = true;          //武器类型
            item.maxStack = 1;          //最大堆叠
            item.shoot = 132;           //武器特效
            item.shootSpeed = 14f;      //特效速度
            item.UseSound = SoundID.Item1;          //武器声音
            item.knockBack = 6;         //击退威力
 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1); //需要：泥土块1个
            recipe.SetResult(this); //合成物品
            recipe.AddRecipe(); //添加合成
        }

    }

}