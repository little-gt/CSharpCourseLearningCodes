using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_继承_密封类
{
	#region 知识点 1 | 基本概念
	// 密封类 |
	// 密封类是使用 sealed 密封关键字修饰的类
	// sealed 作用：让类无法再被继承
	#endregion

	#region 知识点 2 | 实例
	class Father
	{

	}
	sealed class Son : Father
	{

	}
	#endregion

	#region 知识点 3 | 作用
	// 在面向对象程序的设计中，密封类的主要作用就是不允许最底层的子类被继承
	// 可以保证程序的规范性、安全性
	// 目前可能用处不大，但是在之后使用或者编写复杂系统或者程序框架时，便可以慢慢体会到密封的作用
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
		}
	}

	#region 总结 |
	// 关键字：sealed
	// 作用：让类无法再被继承
	// 意义：加强面向对象程序设计的规范性、结构性和安全性
	#endregion
}
