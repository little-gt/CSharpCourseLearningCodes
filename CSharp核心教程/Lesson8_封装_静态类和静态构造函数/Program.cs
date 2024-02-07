using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_封装_静态类和静态构造函数
{
	#region 知识点 1 | 静态类
	// 概念 |
	// 用 static关键词 修饰的类，被称之为静态类
	
	// 特点 |
	// 只能包含静态成员
	// 不能被实例化

	// 作用 |
	// 1. 将常用的静态成员写在静态类中，方便使用
	// 2. 静态类不能被实例化，更能体现工具类的唯一性
	// 比如：Console就是一个静态类

	static class Tools
	{

	}
	#endregion

	#region 知识点 2 | 静态构造函数
	// 概念 |
	// 在构造函数前加上 static 修饰

	// 特点 |
	// 1. 静态类和普通类都可以有
	// 2. 不能使用访问修饰符
	// 3. 不能有参数
	// 4. 只会在整个类被第一次使用时，自动调用一次

	// 作用 |
	// 在静态构造函数中 初始化静态变量

	// 使用 |
	// 1. 静态类中的静态构造函数
	static class StaticClass
	{
		public static int testInt1 = 100;
		public static int testInt2 = 250;

		static StaticClass()
		{
			Console.WriteLine("STR TEST STATIC");
		}
	}
	// 2. 普通类中的静态构造函数
	class NormalClass
	{
		public int testInt1 = 666;

		static NormalClass()
		{
			Console.WriteLine("NOR STR STATIC");
		}
	}
	#endregion

	// 总结 |

	// 静态类，就是用 static 修饰的类
	// 它只能包含静态成员，并且不允许实例化

	// 静态构造函数
	// 静态类和普通类都可以有静态构造函数
	// 没有分修饰符或者传入参数
	// 只会在整个类被第一次调用前，自动执行一次

	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
