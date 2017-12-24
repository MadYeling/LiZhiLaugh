using Terraria;
using Terraria.ModLoader;

namespace LiZhiLaugh.Buffs
{
    public class JavaBuff : ModBuff
    {
        public override void SetDefaults()
		{
			DisplayName.SetDefault("爪哇咖啡");
			Description.SetDefault("“我好亢奋！！”某只芋头如是说道.");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			canBeCleared = false;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed *= 1;
			player.lifeRegen += 6;
			player.lifeMagnet = true;
		}

    }
}