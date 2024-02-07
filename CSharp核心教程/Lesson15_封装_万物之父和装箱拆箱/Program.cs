using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_封装_万物之父和装箱拆箱
{
	#region 知识回顾 | 里氏替换原则
	// 概念 |
	// 用父类容器装载子类对象

	// 作用 |
	// 方便进行对象存储和管理

	// 使用 |
	// is 和 as 关键字
	// 1. is 用于判断
	// 2. as 用于转换
	#endregion

	#region 知识点 1 | 万物之父
	// 万物之父 object
	
	// 关键字：object
	// 概念 |
	// object 是所有类型的基类，object 是一个类(引用类型)
	// 作用 |
	// 1. 可以利用里氏替换原则，用 object 容器装载所有对象；
	// 2. 可以用来表示不确定的类型，用作函数参数类型。

	public class FATHER
	{

	}
	public class SON : FATHER
	{
		public void Speak(string strContext)
		{
			Console.WriteLine("SAYS: " + strContext);
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 2 | 万物之父的使用
			FATHER father = new FATHER();
			FATHER son = new SON();
			if(son is SON)
			{
				(son as SON).Speak("WAAA");
			}

			// 引用类型 |
			// object 可以装载所有的类
			object o = new SON();
			o = father;
			o = son;
			// 使用时，用 is as 来判断和转换即可
			if (o is SON)
			{
				(o as SON).Speak("GET ME FIVE!");
			}

			// 值类型 |
			// object 可以用来装载值类型
			object oo = 233f;
			// 作为值类型的 object 只能使用强转，
			// 转换以后，才可以使用
			float fla = (float)oo;

			// 特殊的String类型和数组 |
			object str = "guluoo";
			// 注意，此时需要使用 as 进行转换，才能使用
			string str2 = str as string;
			object arr = new int[10];
			// 注意，此时需要使用 as 进行转换，才能使用
			int[] arr2 = arr as int[];
			#endregion

			#region 知识点 3 | 装箱拆箱
			// 发生的条件 |
			// 用 object 储存值类型 (装箱)
			// 再把 object 转换为特殊的值类型 (拆箱)

			// 装箱 |
			// 把值类型用引用类型储存，
			// 栈内存会迁移到堆内存中。

			// 拆箱 |
			// 把引用类型储存的值类型取出来，
			// 即把堆内存迁移到栈内存中。

			// 好处：不确定类型时，可以方便参数的储存和传递；
			// 坏处：存在内存迁移，会增加性能消耗。

			// 装箱：
			object v = 3;
			// 拆箱：
			int valueInt = (int)v;

			TestFun(1, 2, 3, 4f, "5", new SON(), 7.0);
			#endregion
		}

		static void TestFun(params object[] array)
		{
			// 这样就可以把不同的类型传入数组当中!
		}
	}
	#region 总结 |
	// POINT 1 |
	// 万物之父：object
	// 基于里氏替换原则的可以用object容器装载一切类型的变量
	// 它是所有类型的基类

	// POINT 2 |
	// 装箱拆箱：
	// 用 object 存值类型 (装箱)
	// 把 object 里面存储的值转换出来 (拆箱)
	// 好处：不确定类型时，可以方便参数的储存和传递；
	// 坏处：存在内存迁移，会增加性能消耗。

	// 注意：object 对性能消耗较大，尽可能少用！
	#endregion
}
