using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson9
{
	#region 拓展方法
	static class Tools
	{
		/// <summary>
		/// 求平方 | 不会修改该变量的值，返回该变量的平方值
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public static int RequestSquare(this int i)
		{
			return i * i;
		}

		public static void Death(this Player pl)
		{
			Console.WriteLine("W");
		}
	}
	#endregion

	#region 自定义类 | 玩家
	/// <summary>
	/// 玩家类 | 包含姓名，血量，攻击力，防御力等特征；攻击，移动，受伤等方法。
	/// </summary>
	class Player
	{
		/// <summary>
		/// 玩家姓名
		/// </summary>
		public string name;
		/// <summary>
		/// 玩家血量
		/// </summary>
		public int hp;
		/// <summary>
		/// 玩家攻击力
		/// </summary>
		public int firepower;
		/// <summary>
		/// 玩家防御力
		/// </summary>
		public int defepower;

		public int Attack()
		{
			Random random = new Random();
			int valueAttackPoint = random.Next(firepower, firepower + 35);
			Console.WriteLine("玩家" + name + "，造成了" + valueAttackPoint + "点伤害");
			return valueAttackPoint;
		}

		public void Move(int deutaX, int deutaY)
		{

		}

		public int Injured(int fire)
		{
			Random random = new Random();
			int tureInjure = fire - random.Next(defepower, defepower + 35);
			if (tureInjure <= 0)
			{
				tureInjure = 0;
			}
			hp -= tureInjure;
			Console.WriteLine("玩家" + name + "，受到" + tureInjure + "点伤害，血量为" + hp + "点");
			return tureInjure;
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 1. 为整形拓展一个求平方的方法
			int valueInt = 233;
			Console.WriteLine("square value:" + valueInt.RequestSquare());
			Console.WriteLine("origin value:" + valueInt);

		}
	}
}
