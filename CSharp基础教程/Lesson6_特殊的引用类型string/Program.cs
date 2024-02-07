using System;

namespace Lesson6_特殊的引用类型string
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 1 | 复习值和引用类型
			// ☆ 值类型 ——> 他变我不变 ——> 储存在栈内存中
			// 无符号整形 有符号整形 浮点数 char bool 结构体

			// ☆ 引用类型 ——> 他变我也变 ——> 储存在堆内存中
			// 数组(一维、二维、交错) string 类
			#endregion

			#region 知识点 2 | string 他变我不变
			// 因为string是引用类型 按理说 应该是他变我也变
			string str1 = "233";
			string str2 = str1;
			// 但是 string非常特殊 string具备值类型的特征 他变我不变
			str2 = "555";
			Console.WriteLine(str1);
			Console.WriteLine(str2);
			// string 虽然方便 但是频繁的改变string的值 会产生内存垃圾
			// string 有优化替代方案 会在c#核心中讲解

			#endregion
		}
	}
}
