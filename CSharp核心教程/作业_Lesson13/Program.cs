using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson13
{
	#region 习题 1 | is 和 as 的区别是什么
	// 基本概念 |
	// is   ：判断一个对象是否是指定类对象
	// 返回值：bool 是指定类=>真；不是指定类=>假
	// as   ：将一个对象转换为指定的类对象
	// 返回值：成功转换=>返回指定类型的对象；转换失败=>返回null

	// 基本语法 |
	// 类对象 is 类名     该语句块会有一个bool返回值 true和false
	// 类对象 as 类名     该语句块会有一个对象返回值 对象和null

	class FatherClass
	{
		public int exampleIntFather;
	}
	class SonClass : FatherClass
	{
		public int exampleIntSon;
	}
	#endregion

	#region 习题 2 | Monster类
	// 写一个Monster类，它派生出Boss和Goblin两个类，Boss有技能；
	// 小怪有攻击；随机生成10个怪，装载到数组中，遍历这个数组，调用他们的攻击方法，如果是boss就释放技能。
	class Monster
	{
		int pointAttack;
		int pointDefense;
		int pointHP;
		string monsterName;
		
		/// <summary>
		/// 功能 | 随机攻击数攻击
		/// </summary>
		/// <returns>怪物发出的攻击值数</returns>
		public int functionRadomAttack()
		{
			Random random = new Random();
			if (random.Next(0, 100) >= 95)
			{
				return random.Next(Convert.ToInt32(1.5 * pointAttack), Convert.ToInt32(2.3 * pointAttack));
			}
			else
			{
				return random.Next(Convert.ToInt32(0.75 * pointAttack), Convert.ToInt32(1.1 * pointAttack));
			}
		}
		/// <summary>
		/// 功能 | 随机防御数防御
		/// </summary>
		/// <param name="firepower">对方的攻击值</param>
		/// <returns>怪物受到的真实伤害</returns>
		public int functionRadomInjure(int firepower)
		{
			int pointRealInjure;
			int pointRealDefense;
			Random random = new Random();
			if (random.Next(0, 100) >= 90)
			{
				pointRealDefense = random.Next(Convert.ToInt32(1.5 * pointDefense), Convert.ToInt32(2.3 * pointDefense));
			}
			else
			{
				pointRealDefense = random.Next(Convert.ToInt32(0.75 * pointDefense), Convert.ToInt32(1.1 * pointDefense));
			}
			pointRealInjure = firepower - pointRealDefense;
			if (pointRealInjure <= 0)
			{
				pointHP = pointHP - 1;
				return 1;
			}
			else
			{
				pointHP = pointHP - pointRealInjure;
				return pointRealInjure;
			}
		}
	}

	class Goblin : Monster
	{

	}

	class Boss : Monster
	{
		string skillName;
		int skillCode;
	}

	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 习题 1 | MAIN CODE
			FatherClass commonSon = new SonClass();
			commonSon.exampleIntFather = 233;
			if (commonSon is SonClass)
			{
				SonClass son = commonSon as SonClass;
				son.exampleIntSon = 233;
				if (commonSon.exampleIntFather == son.exampleIntSon)
				{
					Console.WriteLine("□");
				}
			}
			// 习题 2 | MAIN CODE
		}
	}
}
