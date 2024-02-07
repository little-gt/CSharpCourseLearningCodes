using System;

namespace Lesson11_递归函数
{
	class Program
	{
		#region 知识点 1 | 基本概念
		/* □ 递归函数 定义
		 *   自己调用自己的函数即递归函数
		 * □ 正确递归 条件
		 *   1. 必须有结束调用的条件
		 *   2. 用于条件判断的这个条件 必须改变 可以达到停止的目的
		 */
		#endregion

		#region 知识点 2 | 实例
		// 习题 | 用递归函数打印出 0 ~ 10
		static void LoopPrint(int a)
		{
			// 步骤一：打印传入的内容
			Console.WriteLine(a);
			// 步骤二：计算出下一次要打印的值
			a += 1;
			// 步骤三：判断是否要打印这一次值
			if (a <= 10)
			{
				LoopPrint(a);
			}
		}
		#endregion
		static void Main(string[] args)
		{
			LoopPrint(0);
		}
	}
}
