using System;

namespace Lesson7_函数
{
	class Program
	{
		#region 知识点 1 | 基本概念
		// 函数(方法)
		// 本质上是一块具有名称的代码块
		// 可以使用函数(方法)的名称来执行该代码块
		// 函数(方法)是封装代码进行重复使用的一种机制

		// 函数(方法)的主要作用：
		// 1. 封装代码
		// 2. 提升代码复用率(减少重复的代码量)
		// 3. 抽象行为
		#endregion

		#region 知识点 2 | 函数应该申明在哪里
		// 1. class语句块中
		// 2. struct语句块中
		#endregion

		#region 知识点 3 | 基本语法
		// 模块 |     1       2       3                     4  
		// 代码 |   static 返回类型 函数名(参数类型 参数名1, 参数类型 参数名2, ... ...)
		//       {
		//             函数的代码逻辑;
		//             函数的代码逻辑;
		//             函数的代码逻辑;
		//             函数的代码逻辑;
		//             函数的代码逻辑;
		//             ... ...
		//             return 返回值; // 如果有返回类型才返回
		//       }

		// 1. static 不是必须的 在没有学习类和结构体之前 必须使用

		// 2-1. 关于返回类型 引出一个新的关键字 (特殊的，void表示没有返回值)
		// 2-2. 返回类型 可以写任意的变量类型 14种变量类型 + 复杂数据类型(数组、枚举、结构体、类class)

		// 3. 函数名 一般使用帕斯卡命名法(每个单词首字母均大写TransferAttack)

		// 4-1. 参数不是必须的，可以有0~n个参数 参数类型也可以是任意类型的 14种变量类型 + 复杂数据类型(数组、枚举、结构体、类class)
		//      多个参数需要使用,逗号隔开
		// 4-2. 参数名 一般使用驼峰命名法(第一个单词首字母小写，其余单词首字母大写valueInt)

		// 5. 当返回值不为void时 必须通过新的关键词 用return返回对应的类型的内容
		//    特别地，即使是void也可以按需求返回一些值
		#endregion

		#region 知识点 4 | 实际应用
		/* 1. 无参数无返回值 */
		// 1    2      3
		static void SayHello()
		{
			Console.WriteLine("Hello World!");
			// return; // 在返回值是void(无返回值)时 可以省略不写
		}

		/* 2. 有参数无返回值 */
		// 1    2      3             4
		static void SayYourName(string name)
		{
			Console.WriteLine("Your name is {0}", name);
		}

		/* 3. 无参数有返回值 */
		static string WhatYourName()
		{
			// 有返回值的函数，必须返回对应类型的函数
			return "233";
		}

		/* 3. 有参数有返回值 */
		// 1    2    3         4
		static int SumTwo(int a, int b)
		{
			int c = a + b;
			return c;
		}

		/* 4. 有参数有多个返回值 */
		static int[] ReplaceTwo(int a, int b)
		{
			int c = a;
			a = b;
			b = c;
			return new int[] { a, b };
		}
		#endregion

		static void Main(string[] args)
		{
			Console.WriteLine("233");
			//使用函数时，直接写 函数名(参数) 即可
			SayHello();

			// 参数 可以是 常量、变量、函数 都可以
			// 参数一定是传入一个 可以得到对应类型的表达式
			const string valueStr1 = "233";
			string valueStr2 = Console.ReadLine();
			SayYourName(valueStr1);
			SayYourName(valueStr2);
			SayYourName(Console.ReadLine());

			string valueStr3 = WhatYourName();

			string valueStr4 = SumTwo(2, 3).ToString();
		}
	}
}
