using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_条件分支语句switch
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点1 | 作用
			// 让顺序代码产生 分支
			#endregion

			#region 知识点2 | 基本语法
			// 注意：
			// 常量只可以写一个值 不能写 一个范围 或者 条件运算符 逻辑运算符 等等

			//switch ( 变量 )
			//{
			//	case 常量:
			//		满足条件时执行的代码块
			//		break;
			//	case 常量:
			//		满足条件时执行的代码块
			//		break;
			//	case 常量:
			//		满足条件时执行的代码块
			//		break;
			//	default:
			//		当所有条件都不满足时 执行的代码块
			//		break;
			//}

			int a = 3;
			switch (a)
			{
				case 1:
					Console.WriteLine("a 是等于 1 的");
					break;
				case 2:
					Console.WriteLine("a 是等于 2 的");
					break;
				case 3:
					Console.WriteLine("a 是等于 3 的");
					break;
				default:
					Console.WriteLine("什么条件都不满足，执行default1中的代码块");
					break;
			}
			#endregion

			#region 知识点3 | default可以省略
			string str = "123";
			switch (str)
			{
				case "123":
					Console.WriteLine("123");
					break;
				case "234":
					Console.WriteLine("234");
					break;
			}
			#endregion

			#region 知识点4 | 可自定义常量
			const char stoneChar = 'B';
			char valueChar = 'A';
			switch (valueChar)
			{
				case stoneChar:
					Console.WriteLine("valueChar 和 stoneChar 的值是相同的");
					break;
				default:
					Console.WriteLine("valueChar 和 stoneChar 的值不相同的");
					break;
			}
			#endregion

			#region 知识点5 | 贯穿
			// 作用：
			// 满足某些条件时 做的事情是一样的 就可以使用贯穿
			int AA = 1;
			switch (AA)
			{
				// 不写case后面配对的break
				// 满足 1 2 3 4中懂得任意一个条件 就会执行
				case 1:
				case 2:
				case 3:
				case 4:
					Console.WriteLine(AA + "是个数字");
					break;
				default:
					break;
			}
			#endregion
		}
	}
}
