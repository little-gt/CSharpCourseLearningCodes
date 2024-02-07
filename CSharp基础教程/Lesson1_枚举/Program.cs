using System;

namespace Lesson1_枚举
{

	#region 知识点 1 | 基本概念

	/* 1. 枚举是什么？*/
	// 枚举是一个比较特别的存在
	// 它是一个被命名的整形常量的集合
	// 一般用它表示 状态 类型 等等

	/* 2. 申明枚举 和 申明枚举变量 */
	// 注意：[申明枚举]和[申明枚举变量]创建一个自定义的枚举类型
	// 申明枚举      | 相当于是 创建一个自定义的枚举类型
	// 申明枚举变量  | 使用申明的自定义枚举类型 创建一个枚举变量

	/* 3. 申明枚举语法 */
	// 枚举名 以E或者E_开头 作为我们的命名规范

	//enum E_自定义枚举名
	//{
	//    // 枚举中包裹的 整型变量 第一个默认是0 下面的会一次累加
	//    自定义枚举项名字,  // 0
	//    自定义枚举项名字1, // 1
	//	  自定义枚举项名字2, // 2
	//} 

	//enum E_自定义枚举名
	//{
	//    // 枚举中包裹的 整型变量 第一个默认是0 下面的会一次累加
	//    自定义枚举项名字  = 5,  // 5
	//    自定义枚举项名字1,      // 6
	//	  自定义枚举项名字2 = 10, // 10
	//    自定义枚举项名字3,      // 11
	//} 
	#endregion

	#region 知识点 2 | 在哪里申明枚举
	// 1. 枚举应该写在 namespace 语句块中（常用）
	// 2. 枚举可以写在 class 语句块中；struct 语句块中
	// 注意：枚举不可以在 函数语句块中 申明！！！

	enum E_MonsterType
	{
		Normal, // 不赋值默认是 0
		Boos,   // 自动累加值到 1
	}
	#endregion

	enum E_PlayerType
	{
		Main,  // 默认初始化为 0
		Other, // 默认自增到值 1
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== lesson1 枚举 ======");

			#region 知识点 3 | 枚举的使用
			// 申明枚举变量
			// 自定义的枚举类型 变量名 = 默认值（自定义的枚举类型.枚举项）;
			E_PlayerType playerType = E_PlayerType.Main;

			// 使用方法 1 |
			if (playerType == E_PlayerType.Main)
			{
				Console.WriteLine("☆ 主玩家的逻辑 ☆");
			}
			else if (playerType == E_PlayerType.Other)
			{
				Console.WriteLine("☆ 其他玩家逻辑 ☆");
			}

			// 使用方法 2 |
			// 由此可见：枚举和switch天生一对
			E_MonsterType monsterType = E_MonsterType.Boos;
			switch (monsterType)
			{
				case E_MonsterType.Normal:
					Console.WriteLine("☆ 普通怪物逻辑 ☆");
					break;
				case E_MonsterType.Boos:
					Console.WriteLine("☆ BOSS逻辑 ☆");
					break;
				default:
					break;
			}
			#endregion

			#region 知识点 4 | 枚举的类型转换
			/* 1. 枚举和int互转 */
			// 枚举 ——> int  [括号强转]
			int i = (int)monsterType;
			Console.WriteLine(i);
			// int ——> 枚举  [直接赋值 和 括号强转]
			monsterType = 0;
			monsterType = (E_MonsterType)1;

			/* 2.枚举和string相互转换 */
			// 枚举 ——> string
			string str = playerType.ToString();
			Console.WriteLine(str);
			// string ——> 枚举
			// Parse后   第一个参数:你要转为的是哪个枚举类型 , 第二个参数:用于转换的对应枚举项的字符串
			// 转换完毕后 是一个通用的类型 需要使用括号强转成需要的目标枚举类型
			// 注意："Other"中的字符必须要存在于枚举中 否则报错
			playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");
			Console.WriteLine(playerType);
			#endregion

			#region 知识点 5 | 枚举的作用
			// 在游戏开发中 对象有很多时候 会有许多的状态
			// 比如玩家有一个动作状态 需要使用一个变量或者标识 来表示当前玩家除于的是哪种状态
			// 综合考虑 可能会使用 int 来表示他的状态
			// 1——>行走 2——>待机 3——>跑步 4——>跳远 ... ...

			// 使用枚举点出枚举项 就可以清晰的分清楚状态的含义
			#endregion
		}
	}
}
