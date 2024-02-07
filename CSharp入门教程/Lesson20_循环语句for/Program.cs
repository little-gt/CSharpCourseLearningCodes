using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_循环语句for
{
	class Program
	{
		static void Main(string[] args)
		{
			int length;

			#region 知识点 1 | 基本语法
			// for ( /*初始表达式*/ ; /*条件表达式*/ ; /*增量表达式*/  )
			// {
			// 	     // 循环代码逻辑;
			// }
			// 第一个空（初始表达式）： 一般声明一个临时变量，用来计数
			// 第二个空（条件表达式）： 表明进入循环的条件 一个bool类型的结果（bool变量 条件运算符 逻辑运算符）
			// 第三个空（增量表达式）： 用第一个空中的变量 进行 自增减运算

			// 第一次进入循环时 才会调用 第一个空中的代码
			// 每次进入循环之前 都会判断 第二个空中的条件 满足才会进入循环体
			length = 10;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine(i);
				// 执行完循环语句块中的代码 就会执行 第三空中的代码
			}

			length = 0;
			for (int i = 10; i >= length; i--)
			{
				Console.WriteLine(i);
			}

			// 每个空位可以按照规则进行书写
			// 第一个空位就是申明变量所以可以连续申明
			// 第二个空位就是进入条件只要是boo1结果的表达式都可以
			// 第三个空位 就是执行一次循环逻辑过后要做的事情做啥都行
			for ( int x = 0 , y = 0 ; x <= 15 && y <= 7 ; x++ , y = x - 8 )
			{
				Console.WriteLine("x:" + x + " y:" + y);
			}
			#endregion

			#region 知识点 2 | 支持嵌套
			length = 15;
			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 14:
						Console.WriteLine("i is 14!");
						break;
					default:
						break;
				}
				for (int x = 0; x < 5; x++)
				{
					Console.WriteLine(x);
				}
			}
			#endregion
		}
	}
}
