using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson17
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("======== 习题 1 ========");
			#region 习题1 | 工资是多少？
			Console.WriteLine("□ 请输入您对 王老师 上课的整体评价：");
			Console.WriteLine("□ 提示：请在“兴奋”、“充实”、“好吧”、“理解”或“枯燥乏味”中选择一个形容词。");
			string userComment = Console.ReadLine();

			switch (userComment)
			{
				case "兴奋":
					Console.WriteLine("○ 评级为：A");
					Console.WriteLine("○ 绩效工资为：" + (4000 + 500) + "元（4000元基本工资 与 500元奖金）");
					break;
				case "充实":
					Console.WriteLine("○ 评级为：B");
					Console.WriteLine("○ 绩效工资为：" + 4000 + "元（4000元基本工资）");
					break;
				case "好吧":
					Console.WriteLine("○ 评级为：C");
					Console.WriteLine("○ 绩效工资为：" + (4000 - 300) + "元（4000元基本工资 与 300元罚金）");
					break;
				case "理解":
					Console.WriteLine("○ 评级为：D");
					Console.WriteLine("○ 绩效工资为：" + (4000 - 500) + "元（4000元基本工资 与 500元罚金）");
					break;
				case "枯燥乏味":
					Console.WriteLine("○ 评级为：E");
					Console.WriteLine("○ 绩效工资为：" + (4000 - 800) + "元（4000元基本工资 与 800元罚金）");
					break;
				default:
					Console.WriteLine("○ 评级为：？");
					Console.WriteLine("○ 绩效工资为：" + 4000 + "元（4000元基本工资）");
					break;
			}
			#endregion
			Console.WriteLine();

			Console.WriteLine("======== 习题 2 ========");
			#region 习题2 | 买咖啡
			const int priceMiddle = 5;
			const int priceBig = 7;
			const int priceSuperBig = 11;
			int userChoose;
			int userWallet = 10;

			Console.WriteLine("□ 欢迎购买唐唐咖啡店的金典咖啡，请输入商品序号：");
			Console.WriteLine("□ 菜单：" + "\n" + "- 1 ——> 中杯 ¥" + priceMiddle + "\n" + "- 2 ——> 大杯 ¥" + priceBig + "\n" + "- 3 ——> 超大杯 ¥" + priceSuperBig);
			Console.WriteLine("□ 顾客：糖糖 | 余额：" + userWallet);
			try
			{
				userChoose = Convert.ToInt32(Console.ReadLine());
				if (userChoose < 1 || userChoose > 3)
				{
					userChoose = 2;
					Console.WriteLine("△ 您的选择的商品已下架或者不存在，已为您自动选择您最常购买的产品！");
				}
			}
			catch
			{
				userChoose = 2;
				Console.WriteLine("△ 您的选择的商品已下架或者不存在，已为您自动选择您最常购买的产品！");
			}
			switch (userChoose)
			{
				case 1:
					if ( ( userWallet - priceMiddle ) >= 0 )
					{
						userWallet = userWallet - priceMiddle;
						Console.WriteLine("☆ 您的账单：\n" + "- 购买 中杯 金典咖啡 现制 | 合计：¥" + priceMiddle + " 数量：1\n" + "- 服务 高级咖啡师现制服务 | 合计：会员免费 数量：1\n" + "- 余额：" + userWallet);
						Console.WriteLine("☆ 感谢购买 中杯 金典咖啡，请耐心等待咖啡师为您制作！");
					}
					else
					{
						Console.WriteLine("× 非常抱歉 您的余额不足 无法下单，建议您先充值以后再下单，或者到服务台直接下单！");
					}
					break;
				case 2:
					if ((userWallet - priceBig) >= 0)
					{
						userWallet = userWallet - priceBig;
						Console.WriteLine("☆ 您的账单：\n" + "- 购买 大杯 金典咖啡 现制 | 合计：¥" + priceBig + " 数量：1\n" + "- 服务 高级咖啡师现制服务 | 合计：会员免费 数量：1\n" + "- 余额：" + userWallet);
						Console.WriteLine("☆ 感谢购买 大杯 金典咖啡，请耐心等待咖啡师为您制作！");
					}
					else
					{
						Console.WriteLine("× 非常抱歉 您的余额不足 无法下单，建议您先充值以后再下单，或者到服务台直接下单！");
					}
					break;
				case 3:
					if ((userWallet - priceSuperBig) >= 0)
					{
						userWallet = userWallet - priceSuperBig;
						Console.WriteLine("☆ 您的账单：\n" + "- 购买 超大杯 金典咖啡 现 | 合计：¥" + priceSuperBig + " 数量：1\n" + "- 服务 高级咖啡师现制服务 | 合计：会员免费 数量：1\n"+ "- 余额：" + userWallet);
						Console.WriteLine("☆ 感谢购买 超大杯 金典咖啡，请耐心等待咖啡师为您制作！");
					}
					else
					{
						Console.WriteLine("× 非常抱歉 您的余额不足 无法下单，建议您先充值以后再下单，或者到服务台直接下单！");
					}
					break;
				default:
					Console.WriteLine("× 非常抱歉 出现未知错误 无法下单，建议您直接到服务台下单！");
					break;
			}
			#endregion
			Console.WriteLine();

			Console.WriteLine("======== 习题 3 ========");
			#region 习题4 | 等第运算
			const uint scoreA = 95;
			const uint scoreB = 85;
			const uint scoreC = 75;
			const uint scoreD = 65;
			const uint scoreE = 30;
			uint stuScore;
			string stuLevel;
			uint stuStandardScore;

			Console.WriteLine("□ 欢迎使用 等第和标准分 换算工具，请输入您的实际得分：");
			try
			{
				stuScore = Convert.ToUInt32(Console.ReadLine());
				if (stuScore > 100)
				{
					stuScore = 0;
					Console.WriteLine("× 输入的分数超过最高分，自动丢弃");
				}
			}
			catch
			{
				stuScore = 0;
				Console.WriteLine("× 输入的分数不合法，自动丢弃");
			}

			if ( stuScore >= 90 )
			{
				stuLevel = "A";
				stuStandardScore = scoreA;
			}
			else if (stuScore < 90 && stuScore >= 80)
			{
				stuLevel = "B";
				stuStandardScore = scoreB;
			}
			else if (stuScore < 80 && stuScore >= 70)
			{
				stuLevel = "C";
				stuStandardScore = scoreC;
			}
			else if (stuScore < 70 && stuScore >= 60)
			{
				stuLevel = "D";
				stuStandardScore = scoreD;
			}
			else
			{
				stuLevel = "E";
				stuStandardScore = scoreE;
			}

			switch (stuStandardScore)
			{
				case scoreA:
					Console.WriteLine("☆ 等第：" + stuLevel + "，标准分：" + scoreA);
					break;
				case scoreB:
					Console.WriteLine("☆ 等第：" + stuLevel + "，标准分：" + scoreB);
					break;
				case scoreC:
					Console.WriteLine("□ 等第：" + stuLevel + "，标准分：" + scoreC);
					break;
				case scoreD:
					Console.WriteLine("□ 等第：" + stuLevel + "，标准分：" + scoreD);
					break;
				case scoreE:
					Console.WriteLine("△ 等第：" + stuLevel + "，标准分：" + scoreE);
					break;
				default:
					break;
			}
			#endregion
			Console.WriteLine();

			Console.WriteLine("======== 习题 4 ========");
			#region 习题4 | 转换
			int cacheNumber;

			Console.WriteLine("请输入一个(0~9)的数字：");
			try
			{
				cacheNumber = Convert.ToInt32(Console.ReadLine());
				if (cacheNumber < 0 || cacheNumber > 9)
				{
					cacheNumber = 2;
					Console.WriteLine("× 输入的字符非法，已自动填充");
				}
			}
			catch
			{
				cacheNumber = 2;
				Console.WriteLine("× 输入的字符非法，已自动填充");
			}

			switch (cacheNumber)
			{
				case 0:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "〇");
					break;
				case 1:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "壹");
					break;
				case 2:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "贰");
					break;
				case 3:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "叁");
					break;
				case 4:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "肆");
					break;
				case 5:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "伍");
					break;
				case 6:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "陆");
					break;
				case 7:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "柒");
					break;
				case 8:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "捌");
					break;
				case 9:
					Console.WriteLine("☆ 数字 " + cacheNumber + " 的繁体是 " + "玖");
					break;
				default:
					break;
			}
			#endregion
		}
	}
}
