using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_作业
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("常量练习题");
			#region 练习题1 | 常量有什么特点？
			// 1.常量必须初始化
			// 2.常量不可以修改
			// 3.常量的申明 就是在申明变量时 在最前面加上 const
			//   eg： const int 1 = 10;
			// 4.之后讲解了 静态关键字 static 会再看常量的特点
			#endregion

			#region 练习题2  | 请简述你觉得在游戏开发中常量会用来干什么？
			//常量是用来申明一些游戏当中不会变化的变量的
			// 1. 一些数学定律或者公理当中的参数 这些量参与计算且不变
			// 2. 游戏当中的对话可以用常量定义在要用的时候调用 而且这样可以方便的多语言支持
			// 3. 游戏当中的一些不变的值 比如等级上限等等
			#endregion
		}
	}
}
