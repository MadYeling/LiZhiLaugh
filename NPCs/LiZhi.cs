using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LiZhiLaugh.NPCs
{
	[AutoloadHead]
	public class LiZhiLaugh : ModNPC
	{
		public override string Texture
		{
			get
			{
				return "LiZhiLaugh/NPCs/LiZhi";
			}
		}

		public override string[] AltTextures
		{
			get
			{
				return new string[] { "LiZhiLaugh/NPCs/LiZhi_Alt_1" };
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "孤星长空";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("孤星长空");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 2048035509;
			npc.defense = 15;
			npc.lifeMax = 2500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 1 : 5;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Sparkle"));
			}
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(2))
			{
				case 0:
					return "荔枝";
				default:
					return "黎执";
			}
		}

		public override string GetChat()
		{
			int Guide = NPC.FindFirstNPC(NPCID.Guide);
			if (Guide >= 0 && Main.rand.Next(26) == 0)
			{
				return "向导" + Main.npc[Guide].GivenName + "只是个没用的东西罢了, 有问题还不如来mod群问问我, 或者下载一个合成表模组";
			}
			switch (Main.rand.Next(25))
			{
				case 0:
					return "鬼知道这套逻辑对不对，因为你不知道鬼知不知道";
				case 1:
					return "我宁可当滑稽也不想穿女装";
				case 2:
					return "大家好我是黎执，你们有钱吗";
				case 3:
					return "我光着身子，哈哈哈哈哈哈哈哈哈哈哈哈哈哈";
				case 4:
					return "我在邪魅一笑";
				case 5:
					return "我是不是装了一个完美的逼";
				case 6:
					return "在mod组四大群最正经的可能就是我了";
				case 7:
					return "现在世风日下道德沦丧，我毫无办法";
				case 8:
					return "说得跟985、211能比上老子的大学一样，垃圾";
				case 9:
					return "我一天30次，他俩月3次，我真厉害";
				case 10:
					return "枯燥无味平常，即是生活";
				case 11:
					return "突然感觉自己好帅";
				case 12:
					return "你叶个毛的凌";
				case 13:
					return "我就跟你说你很皮";
				case 14:
					return "我脑子最近有问题吧...";
				case 15:
					return "讨论哲学的来一波";
				case 16:
					return "玩淫棍干什么";
				case 17:
					return "现代人的世界太可怕了，我回古代吟诗作赋去吧";
				case 18:
					return "我现在怒火焚天";
				case 19:
					return "我有一句(河蟹)不知当不当讲";
				case 20:
					return "突然的就吓我一跳";
				case 21:
					return "这tm是什么神鬼玩意啊卧槽";
				case 22:
					return "哇，我居然如此料事如神";
				case 23:
					return "辛亏我没傻";
				default:
					return "一个寒古封元掌摁死你";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("laugh1"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("CuckoosFeather"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Java"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType(""));
			nextSlot++;
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType<Items.Accessories.laugh1>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20480;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("SparklingBall");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}