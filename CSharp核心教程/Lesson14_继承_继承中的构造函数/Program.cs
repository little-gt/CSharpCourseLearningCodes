using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_继承_继承中的构造函数
{
	#region 知识回顾

	// 构造函数 |
	// 1. 实例化对象时调用的函数；
	// 2. 主要用来初始化成员变量；
	// 3. 每个类都会有一个默认的无参构造函数。

	// 语法 |
	// 访问修饰符 类名()
	// {
	//       // 函数功能代码
	// }
	// 特点 |
	// 1. 不写返回值；
	// 2. 函数名和类名相同；
	// 3. 访问修饰符根据需求确定，一般是public；
	// 4. 构造函数可以重载；
	// 5. 可以用this语法重用代码。
	// 注意 |
	// 1. 有参构造函数会自动覆盖掉默认的无参构造函数；
	// 2. 如果想要保留无参构造函数，需要自己重载。

	class classTest
	{
		public int valueTest1;
		public int valueTest2;
		public string valueTest;

		/// <summary>
		/// 无参数构造函数
		/// </summary>
		public classTest()
		{
			valueTest = "";
			valueTest1 = 0;
			valueTest2 = 0;
		}

		/// <summary>
		/// string构造函数
		/// </summary>
		/// <param name="inputStr">valueTest (string)</param>
		public classTest(string inputStr)
		{
			this.valueTest = inputStr;
			valueTest1 = 0;
			valueTest2 = 0;
		}

		/// <summary>
		/// 完全参数构造函数
		/// </summary>
		/// <param name="inputStr">valueTest (string)</param>
		/// <param name="inputTest1">valueTest1 (int)</param>
		/// <param name="inputTest2">valueTest2 (int)</param>
		public classTest(string inputStr, int inputTest1, int inputTest2) : this(inputStr)
		{
			this.valueTest1 = inputTest1;
			this.valueTest2 = inputTest2;
		}
	}
	#endregion

	#region 知识点 1 | 基本概念 - 继承中的构造函数
	// 特点 |
	// 当申明一个子类对象时：先执行父类的构造函数，再执行子类的构造函数。

	// 注意 |
	// 1. 父类的无参构造函数，是很重要的；
	// 2. 子类可以通过base关键字代表父类，调用父类构造函数。
	#endregion

	#region 知识点 2 | 执行顺序 - 继承中构造函数的执行顺序 
	// 顺序 |
	// 父类的父类的构造 -> ...父类构造 -> ... ... -> 子类构造
	class GameObject
	{
		public GameObject()
		{
			Console.WriteLine("GameObject的构造函数");
		}
	}
	class Player : GameObject
	{
		public Player()
		{
			Console.WriteLine("Player的构造函数");
		}
	}
	class Worker : Player
	{
		public Worker()
		{
			Console.WriteLine("Work的构造函数");
		}
	}
	#endregion

	#region 知识点 3 | 无参构造 - 父类的无参构造函数的重要性
	class Father
	{
		// 注意 |
		// 父类当中，必须要有无参数构造，否则其子类都会报错
		// 因为子类在初始化时，会默认调用父类的无参构造，所以如果父类没有无参构造会报错，无法运行
		public Father()
		{
			Console.WriteLine("Father的构造函数");
		}
		public Father(int i)
		{
			Console.WriteLine("Father的构造函数");
		}
	}
	class Son : Father
	{

	}
	#endregion

	#region 知识点 4 | 调用父类 - 通过base调用指定的父类构造
	public class Dish
	{
		string dishName;
		public Dish()
		{
			Console.WriteLine("Dish的无参构造函数");
		}
		public Dish(string dishName)
		{
			this.dishName = dishName;
			Console.WriteLine("Dish的有参构造函数");
			Console.WriteLine(this.dishName);
		}
	}
	public class ChineseDish : Dish
	{
		// 与 this 类似，使用 base 就可以调用父类当中的有参构造函数
		public ChineseDish(string dishName) : base(dishName)
		{
			Console.WriteLine("ChineseDish的构造函数");
			Console.WriteLine(dishName);
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("■ Lesson 14 继承中的构造函数");
			Worker worker = new Worker();
			ChineseDish chineseDish = new ChineseDish("蘑菇");
		}
	}
	#region 总结
	// 继承中的构造函数

	// 特点 |
	// 执行顺序：先执行父类的构造函数，再执行子类的构造函数。
	// 记忆口诀：从老祖宗开始依次迭代一代一代地向下执行构造。

	// 注意 |
	// 父类中的无参构造函数是十分重要的，
	// 如果被覆盖了，子类就不能再默认调用无参构造函数，出现错误。
	// 解决方法 |
	// 1. 始终申明一个无参构造函数；
	// 2. 通过 base 关键字，调用指定父类的构造
	
	// 小心 |
	// 一定要区分 this 和 base 的区别!
	#endregion
}
