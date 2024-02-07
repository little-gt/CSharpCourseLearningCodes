//第一种注释 两杠注释
//第二种注释 星号注释
//第三种注释 三杠注释

using System;

/// <summary>
/// 命名空间 —— 工具包
/// </summary>
namespace Lesson1_第一个应用程序
{
	//命名空间 代码块
	//知识点：面向对象的编程

	/// <summary>
	/// 类 —— 工具
	/// </summary>
	class Program
	{
		//类代码块 知识点：面向对象的编程

		/// <summary>
		/// 函数 —— 工具可以做的事
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//函数代码块 我们目前学习基础知识时
			//所有的代码 都写在这里

			//控制台 输出并且自动换行
			Console.WriteLine("请输入信息，按回车结束：");

			//控制台 输入内容并且按回车结束
			Console.ReadLine();

			//控制台 输出但是不自动换行
			Console.Write("你已经输入，");
			Console.Write("欢迎！" + '\n'); // \n是转义符号，意思是换行，且用''

			//控制台 输出并且自动换行
			Console.WriteLine("按任意键继续...");

			//控制台 读取按下的任意键
			Console.ReadKey();

			//控制台 输出并且自动换行
			Console.WriteLine("是你按下的按键，已确认继续！");
		}
	}
}
