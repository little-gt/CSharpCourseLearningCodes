using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_循环语句do_while
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 1 | 基本语法
			// while    循环时：先判断 再执行 | 条件不满足时，可以不执行语句块
			// do while 循环时：先执行 再判断 | 必须要执行一次语句块中的代码块 
			// do
			// {
			//do while 循环语句块
			// } while (bool类型的值);
			// 注意 do while 语句，存在一个重要的分号
			#endregion

			#region 知识点 2 | 实际使用
			// 先执行 后判断
			//do
			//{
			//	Console.WriteLine("do while");
			//} while (false);

			// 实例
			//int a = 0;
			//do
			//{
			//	a++;
			//	Console.WriteLine("do while");
			//} while (a < 2);
			#endregion

			#region 知识点 3 | continue的不同之处
			do
			{
				Console.WriteLine("111");
				continue; // 会直接使得代码回到 while
			} while (false);
			#endregion
		}
	}
}
