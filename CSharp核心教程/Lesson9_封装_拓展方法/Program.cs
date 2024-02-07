using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_封装_拓展方法
{
	#region 知识点 1 | 拓展方法的基本概念
	// 概念 |
	// 为现有 【非静态】 变量类型 添加 新方法

	// 作用 |
	// 1. 提升程序拓展性
	// 2. 不需要再在对象中重新写方法
	// 3. 不需要继承来添加方法
	// 4. 为别人封装的类型写额外的方法

	// 特点 |
	// 1. 一定是写在静态类当中
	// 2. 一定是静态函数
	// 3. 第一个参数为拓展目标
	// 4. 第一个参数用this修饰
	#endregion

	#region 知识点 2 | 基本语法
	// 访问修饰符 static 返回值 函数名(this 扩展名 参数名, 参数类型 参数名, 参数类型 参数名，)
	#endregion

	#region 知识点 3 | 实践案例
	static class Tools
	{
		// 为int扩展了一个成员方法
		// 成员方法 是需要 实例化对象 以后才可以使用的
		// value 代表 使用该方法的 实例化对象
		public static void SpeakValue(this int value)
		{
			// 扩展方法的逻辑代码
			Console.WriteLine("INT VALUE: "+ value);
		}
		public static void SpeakString(this string str1, string str2, string str3)
		{
			// 拓展方法的逻辑代码
			Console.WriteLine("调用者：" + str1 + "\n 参数：" + str2 + str3);
		}
		public static void Fun3(this Test t)
		{
			// 拓展方法的逻辑代码
			Console.WriteLine("为Test拓展的方法");
		}
	}
	#endregion

	#region 知识点 5 | 为自定义的类型拓展方法
	class Test
	{
		public int i = 233;
		public void Fun1()
		{
			Console.WriteLine("TEST FUN1");
		}
		public void Fun2()
		{
			Console.WriteLine("TEST FUN2");
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Lesson9 封装_拓展方法");
			int i = 233;
			i.SpeakValue();
		}
	}

	#region 总结
	// 概念 |
	// 为现有的【非静态】变量类型添加方法
	
	// 作用 |
	// 1. 提升程序的拓展性
	// 2. 不需要再在对象中重新写方法
	// 3. 不需要继承来添加方法
	// 4. 为别人封装的类型写额外的方法

	// 特点 |
	// 1. 拓展方法是静态类中的静态方法
	// 2. 第一个参数代表拓展的目标
	// 3. 第一个参数的前面一定要加上 this
	
	// 注意 |
	// 1. 可以有返回值和n个参数
	// 2. 具体根据需求而定
	#endregion
}
