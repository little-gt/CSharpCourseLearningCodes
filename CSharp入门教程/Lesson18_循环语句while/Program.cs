using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_循环语句while
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点1 | 作用
			// 让顺序执行的代码可以不停地循环执行某一段代码块的内容
			// 循环语句 让 代码可以重复被执行
			#endregion

			#region 知识点2 | 语法相关
			// 基本语法：
			//while ( bool类型的值 ) // 当bool类型的值为 true 时会执行 while内的代码块
			//{
			//	// 当条件满足时 被重复执行的代码
			//	// ...... ......
			//	// ...... ......
			//	// ...... ......
			//	// ...... ......
			//	// 当代码执行完毕后 会返回到while循环的开头
			//	// 再次进行条件判断 如果满足条件会继续循环；如果不满足条件会退出while语句
			//}

			// 死循环：
			// 不停地执行循环中的代码逻辑 无法退出 直到程序卡死或者退出
			// 进入 unity以后 基本不会使用死循环 因为会导致内存问题 或者 使得程序卡死
			//while (true) // 没有退出的条件 会一直执行
			//{
			//	Console.WriteLine("....................");
			//}
			// 当内存被充满以后 会导致程序卡死 崩溃 

			// 嵌套使用注意
			// 在while循环中 每次进入循环 前一次在循环内申明的变量都会丢失
			int totalAdd = 0;
			while (totalAdd < 10)
			{
				++totalAdd;

				int tempAdd = 0 ; // tempAdd只在 一次循环内有效 循环结束以后 立即抛弃
					while (tempAdd < 10)
				{
					tempAdd++;
					Console.WriteLine(tempAdd);
				}
			}
			Console.WriteLine(totalAdd);
			#endregion

			#region 知识点4 | 流程控制关键词
			// 作用：控制循环逻辑的关键词

			/*  break
			 *  跳出循环
			 */
			int valueKey;
			while (true)
			{
				try
				{
					Console.WriteLine("□ 请输入数字秘钥（233）：");
					valueKey = Convert.ToInt32(Console.ReadLine());
					if (valueKey == 233)
					{
						break;
					}
					else
					{
						Console.WriteLine("× 数字秘钥不正确，请重新输入！");
					}
				}
				catch
				{
					Console.WriteLine("× 请输入一个数字秘钥，请重新输入！");
				}
			}
			Console.WriteLine("√ 数字秘钥正确，已退出循环！");

			/*  continue
			 *  回到循环开始 继续执行
			 */
			int tempIndex = 0;
			while(tempIndex < 100)
			{
				++tempIndex;
				if (tempIndex % 2 == 0)
				{
					continue;
				}
				Console.WriteLine(tempIndex);
			}
			#endregion
		}
	}
}
