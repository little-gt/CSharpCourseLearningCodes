using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_常量
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("第五课 常量");

			#region 知识点1 | 常量的申明
			// 关键字 const
			// 固定写法 | const 变量类型 变量名 = 初始值;
			// 常量是不可修改的  一般是游戏中不易修改的东西
			// 比如 BOSS的攻击数值 某个奖励的数值 固定的数学数值 等等
			#endregion

			#region 知识点2 | 常量的特点
			// 1.必须要初始化
			// 2.不可以被修改
			const int attackBoos_Skill1 = 15;
			const string textBoos_Skill1 = "旋风斩";
			int yourLifePoint = 10;

			Console.WriteLine();
			Console.WriteLine("■■■■■■■■■■■■■■■■■■■■");
			Console.WriteLine("■ 请切换输入法为英文模式以防止误操作 ■");
		    Console.WriteLine("■■■■■■■■■■■■■■■■■■■■");
			Console.WriteLine();

			Console.WriteLine("===== 按下 y 吃掉生命果实，按下 其他按钮 不吃生命果实 =====");
			if ("Y" == Console.ReadKey().Key.ToString())
			{
				Console.WriteLine('\n' + "★ 恭喜！你吃掉了 生命果实 | 生命 +65");
				yourLifePoint = yourLifePoint + 100;
			}
			else
			{
				Console.WriteLine('\n' + "☆ 啊，你没有吃掉 生命果实 | 生命 +0");
			}
			Console.WriteLine("■ 你现在的生命值：" + yourLifePoint);

			Console.WriteLine("===== 发现前方有 Lv1 的BOOS | 按下 任意键 开始战斗！！ =====");
			if (null != Console.ReadKey())
			{
				Console.WriteLine('\n' + "▲ 不好！你受到攻击 " + textBoos_Skill1 + " | 生命 -" + attackBoos_Skill1);
				yourLifePoint = yourLifePoint - attackBoos_Skill1;
			}
			if (yourLifePoint >= 0)
			{
				Console.WriteLine("■ 你现在的生命值：" + yourLifePoint);
			}
			else
			{
				yourLifePoint = 0;
				Console.WriteLine("■ 你现在的生命值：" + yourLifePoint);
				Console.WriteLine("☆ 啊，你失败了。");
				Environment.Exit(0);
			}

			Console.WriteLine("===== 轮到你反击了！ | 可以使用 次元斩 按下 y 即可释放 =====");
			if ("Y" == Console.ReadKey().Key.ToString())
			{
				Console.WriteLine('\n' + "★ 恭喜！你胜利了！");
			}
			#endregion
		}
	}
}
