using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_继承_里氏替换原则
{
	#region 知识点 1 | 基本概念
	// 里氏替换原则是面向对象七大原则中最重要的原则

	// 概念 |
	// 任何父类出现的地方，子类都可以替代
	// 重点 |
	// 语法表现为：父类容器装载子类对象，因为子类对象包含了父类的所有内容
	// 作用 |
	// 方便进行对象存储和管理
	#endregion

	#region 知识点 2 | 基本实现
	class GameObject
	{

	}

	class Player : GameObject
	{
		public void PlayerAttack()
		{
			Console.WriteLine("玩家攻击！");
		}
	}

	class Monster : GameObject
	{
		public void MonsterAttack()
		{
			Console.WriteLine("怪兽攻击！");
		}
	}

	class BOSS : GameObject
	{
		public void BOSSAttack()
		{
			Console.WriteLine("BOSS攻击！");
		}
	}
	#endregion
	class Program
	{
		static void Main(string[] args)
		{
			// 里氏替换原则：用父类容器装载子类对象
			GameObject player = new Player();
			GameObject monster = new Monster();
			GameObject boss = new BOSS();

			GameObject[] objects = new GameObject[] { new Player(), new Monster(), new BOSS() };
			#region 知识点 3 | is 和 as
			// 基本概念 | 
			// is   ：判断一个对象是否是指定类对象
			// 返回值：bool 是指定类=>真；不是指定类=>假
			if (player is Player)
			{

			}
			if (player is Monster)
			{

			}
			// as   ：将一个对象转换为指定的类对象
			// 返回值：成功转换=>返回指定类型的对象；转换失败=>返回null
			Player p1 = monster as Player;
			Player p2 = player as Player;

			// 基本语法 |
			// 类对象 is 类名     该语句块会有一个bool返回值 true和false
			// 类对象 as 类名     该语句块会有一个对象返回值 对象和null
			if (player is Player)
			{
				// Player p = player as Player;
				// p.PlayerAttack()；
				(player as Player).PlayerAttack();
			}
			for (int i = 0; i < objects.Length; i++)
			{
				if (objects[i] is Player)
				{

				}
				if (objects[i] is Monster)
				{

				}
				if(objects[i] is BOSS)
				{

				}
			}
			#endregion
		}
	}
	#region 总结 |
	// 概念 ：父类容器装载子类对象
	// 作用 ：方便进行对象的存储和管理
	// 使用 |
	// is 用于判断
	// as 用于转换
	// 注意 ：不可以使用子类容器装载父类对象
	#endregion
}
