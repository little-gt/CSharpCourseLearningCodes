using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_封装_静态成员
{
	#region 知识点 1 | 静态成员基本概念
	// 静态关键字 static
	// 用 static 修饰的 成员变量、方法、属性等，被称之为静态成员

	// 静态成员的特点是：可以直接用类名点出使用
	#endregion

	#region 知识点 2 | 早已出现的静态成员
	// Consle.XXX
	// 的命令中均为静态成员方法
	#endregion

	#region 知识点 3 | 自定义静态成员
	//class TEST
	//{

	//	// 静态成员变量
	//	static public float PI = 3.141592678f;
	//	// 成员变量
	//	public int testInt = 233;

	//	// 静态成员方法
	//	public static float CalcCircle(float r)
	//	{
	//		// πr²
	//		return PI * r * r;
	//	}
	//	// 成员方法
	//	public void TestFunction(string context)
	//	{
	//		Console.WriteLine(context);
	//	}
	//}
	#endregion

	#region 知识点 5 | 为什么静态成员可以直接使用，而不需要实例化一个对象
	// 注意 |
	// 程序中是不可以无中生有的，
	// 我们要使用的对象、变量或函数(方法)都是要在内存中分配空间的
	// 之所以要实例化出对象，目的就是去分配内存空间，在程序中产生一个抽象的对象

	// 静态成员的特点 |
	// 程序开始运行时，就会自动为静态成员分配内存空间，所以我们可以直接使用静态成员
	// 静态成员和程序是绑定的，只要使用了静态成员，程序就会在内存中创建一个静态成员的内存空间，直到程序结束时才会消失
	// 所以静态成员会有一个自己唯一的内存空间，这使得静态成员拥有了"唯一性"
	// 在任何地方使用，都是使用的静态成员自己的内存空间内的东西，改变也是改变他自己的内存空间内的内容
	#endregion

	#region 知识点 6 | 静态函数中不能使用非静态成员
	// 成员变量只能将对象实例化以后才可以使用，所以静态成员不能使用成员变量
	// 不能直接使用，非静态成员，否则会报错
	#endregion

	#region 知识点 7 | 非静态函数是可以使用静态成员
	class TEST
	{

		// 静态成员变量
		static public float PI = 3.141592678f;
		// 成员变量
		public int testInt = 233;

		// 静态成员方法
		public static float CalcCircle(float r)
		{
			// πr²
			return PI * r * r;
		}
		// 成员方法
		public void TestFunction(string context)
		{
			// 非静态成员是可以调用静态成员的
			Console.WriteLine(context + TEST.CalcCircle(0f));
		}
	}
	#endregion

	#region 知识点 8 | 静态成员对我们的作用
	// 静态变量 |
	// 1. 常用唯一变量的申明
	// 2. 方便在其他地方调用

	// 静态方法 |
	// 常用的唯一方法的申明，比如：相同规则的数学计算相关函数

	// 使用注意 |
	// 静态是全局，是唯一的。但是如果静态过多，会导致内存占用过大，使得动态空间过小，导致程序卡顿甚至无法运行
	#endregion

	#region 知识点 9 | 常量和静态变量
	// const(常量) |
	// 可以理解为特殊的static(静态)，但是常量只能用于变量的初始化

	// 相同点 |
	// 常量和静态，都可以直接点出来使用

	// 不同点 |
	// 1. const必须初始化才能使用，而且不能修改。但是static没有这个规则；
	// 2. const只能用于修饰变量。但是static可以修饰变量、函数、类等等；
	// 3. const一定是写在访问修饰符(private、public、protected)后面的。但是static没有这个要求；
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 4 | 静态成员变量的使用
			// 无需 new 出一个对象，即可使用静态成员方法
			Console.WriteLine(TEST.PI);
			Console.WriteLine(TEST.CalcCircle(2f));

			// 需要 new 出一个对象，才能使用非静态的方法
			TEST T1 = new TEST();
			T1.testInt = 666;
			T1.TestFunction("555");
			#endregion
		}

		// 总结 |
		// 概念：用static修饰的成员变量、成员方法、成员属性等，就称之为静态成员
		// 特点：直接使用类名即可点出使用(全局性)
		// 生命周期：和程序同生共死
		//         程序运行后就会一直存储在内存中，直到程序结束运行以后才会释放，因此静态成员具有唯一性
		// 注意：1. 静态函数不能直接使用非静态的成员
		//      2. 非静态函数可以直接使用静态成员

	}
}
