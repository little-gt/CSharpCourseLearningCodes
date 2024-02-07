using System;

namespace Lesson9_变长参数和参数默认值
{
	class Program
	{
		#region 知识点 1 | 函数语法复习
		/* 基本语法
		 *   1     2     3                    4
		 * static void 函数名(参数类型 参数1, 参数类型 参数2, ... ...)
		 * {
		 *         5
		 *       return 返回值;
		 * }
		 * 
		 *  1. 静态关键词(可选)
		 *  2. 返回值(如果没有返回值，则为void；如果有返回值，需和申明函数时返回的返回值类型相同)
		 *  3. 函数名(一般使用帕斯卡命名法)
		 *  4. 参数(参数可以是0~n个 且前面可以加上ref或out 使得函数内外的参数同步变化)
		 *  5. 返回(如果不是void，必须返回一个和申明返回类型一致的返回量，且一旦执行，接下来的代码会自动截断)
		 */
		#endregion

		#region 知识点 2 | 变长参数关键词
		/* 举例 | 函数要计算n个整数的和
		 * static int Sum(int a, int b, int c, ... ...)
		 * {
		 *      ... ...
		 * }
		 */

		// ★ 变长参数关键字 params
		static int Sum(params int[] arr)
		{
			int resultSum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				resultSum += arr[i];
			}
			return resultSum;
		}
		static string Eat(string name, params string[] foods)
		{
			string resultEat = name + "吃了";
			for (int i = 0; i < foods.Length; i++)
			{
				resultEat += foods[i] + ",";
			}
			return resultEat;
		}
		/*  params int[] arr
		 *  意味着可以传入n个参数 而且n可以为0 传入的参数会保存在arr数组中
		 *  注意：
		 *  1. params关键词后面必须为数组
		 *  2. 数组的类型可以是任意的类型
		 *  3. ☆ 函数参数可以有别的参数 和 params关键词修饰的参数
		 *  4. ☆ 函数中的params关键词只能出现一次 并且只能出现在最后一组参数 之前可以有n的参数
		 */
		#endregion

		#region 知识点 3 | 参数默认值(可选参数)
		// □ 有参数默认值的参数 一般称之为"可选参数"
		//   在使用函数时，可以不传入参数而使用默认值
		static void Speak1(string contexts = "啊?")
		{
			Console.WriteLine(contexts);
		}
		static void Speak2(string speaker, string expression = "不知道", string context = "啊?")
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine(speaker + "用" + expression + "的语气说：");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(context);
			Console.ForegroundColor = ConsoleColor.White;
		}
		/* 注意：
		 * 1. 支持多可选参数 每个参数都可以有默认值
		 * 2. 如果混用 可选参数必须写在必须参数之后
		 */
		#endregion

		static void Main(string[] args)
		{
			// 变长参数例子1 | 累加n个整数
			Console.WriteLine("====== -/ 1 /- ======");
			Console.WriteLine(Sum(0, 2, 6, 8, 9, 8, 7, 0, 5));
			Console.WriteLine(Eat("猫猫", "猫罐头", "小鱼干", "牛奶"));
		}
	}
}
