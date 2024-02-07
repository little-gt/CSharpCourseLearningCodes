using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_封装_构造函数和析构函数
{
	#region 知识点 1 | 构造函数
	// 基本概念 |
	// 在实例化对象时，会自动调用的，用于初始化的函数
	// 如果不写，默认存在一个无参数的构造函数
	// 如果写了，默认的构造函数会自动失效

	// 构造函数的写法 |
	// 1. 没有返回值
	// 2. 函数名和类名必须相同
	// 3. 没有特殊需求时，一般是public的
	// 4. 构造函数可以被重载
	// 5. this代表当前调用该函数的对象自己(即类本身的变量)

	// 注意 |
	// 如果不自己实现无参数的构造函数而实现了有参数的构造函数
	// 会自动失去默认的无参数构造函数
	class Person
	{
		// 类      中可以自己申明无参数的构造函数
		// 结构体  中不允许自己申明无参数的构造函数
		
		/// <summary>
		/// 默认初始化，所有内容均为未设置
		/// </summary>
		public Person()
		{
			name = null;
			age = -1;
			weight = -1;
			height = -1;
		}
		/// <summary>
		/// 简单初始化，只给名字和年龄进行设置
		/// </summary>
		/// <param name="name">名字</param>
		/// <param name="age">年龄(岁)</param>
		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
			weight = -1;
			height = -1;
		}
		/// <summary>
		///	完整初始化，要求完成所有参数的赋值
		/// </summary>
		/// <param name="name">名字</param>
		/// <param name="age">年龄</param>
		/// <param name="weight">体重(kg)</param>
		/// <param name="height">身高(cm)</param>
		public Person(string name, int age, int weight, int height)
		{
			this.name = name;
			this.age = age;
			this.weight = weight;
			this.height = height;
		}

		public string name;
		public int age;
		public int height;
		public int weight;
 
	}
	#endregion

	#region 知识点 2 | 构造函数的特殊写法
	class SpecialPerson
	{
		// 可以使用 this 重复使用构造函数代码
		// 访问修饰符 构造函数名(参数列表):this(参数1, 参数2, 参数3, ...)

		/// <summary>
		/// 无参数初始化
		/// </summary>
		public SpecialPerson()
		{
			name = "未命名";
			age = -1;
			level = -1;
		}
		/// <summary>
		/// 特殊初始化举例，将level和age赋值为默认
		/// </summary>
		/// <param name="name">姓名</param>
		public SpecialPerson(string name):this()
		{
			this.name = name;
		}
		/// <summary>
		/// 特殊初始化举例，减少代码量
		/// </summary>
		/// <param name="name"></param>
		/// <param name="age"></param>
		/// <param name="level"></param>
		public SpecialPerson(string name, int age, int level):this(name)
		{
			this.age = age;
			this.level = level;
		}


		string name;
		int age;
		int level;
	}
	#endregion

	#region 知识点 3 | 析构函数
	// 基本概念 |
	// 当引用类型的堆内存被回收时，会调用该函数
	// 对于需要手动管理内存的语言(如C,C++)，需要在析构函数中做一些内存回收处理
	// 但是C#中纯在自动的垃圾回收机制(GC机制)
	// 所以我们几乎不怎么使用析构函数，除非你需要：在某一个对象被垃圾回收时，做一些特殊的处理
	// 特别注意 | 
	// 在Unity开发中，因为因机制等原因，几乎不会使用，但是必须了解

	// 基本语法 |
	// 在 类 中写下以下代码进行处理
	// ~类名()
	// {
	//      处理机制
	// }

	class NCProcess
	{
		// 当引用类型的堆内存被回收时，才会自动调用析构函数
		~NCProcess()
		{
			// 在C#中，析构函数一般是自动调用的
			// 所以不需要开发人员手动显式定义
			// 如果需要定义一个析构函数，在一个类里面只能有一个
		}
		// 一般来说，对象的生命周期，从【结构函数】开始，到【析构函数】结束
	}
	#endregion

	#region 知识点 4 | 垃圾回收机制
	// 垃圾回收，英文简写为GC(Garbage Collector) |

	// ------ ------ ------ ------ ------ //

	// 垃圾回收的过程本质上是在遍历堆(Heap)上动态分配的所有对象
	// 通过识别他们是否被引用，来确定哪些对象是垃圾，哪些对象仍需要被使用
	// 所谓垃圾，就是没有被任何变量、任何对象引用的内容
	// 垃圾就需要被回收释放，以减轻内存的消耗，提高效率

	// ------ ------ ------ ------ ------ //

	// 垃圾回收有许多的算法，比如：
	// 引用计数 (Reference Counting )
	// 标记清除 (Mark Sweep         )
	// 标记整理 (Mark Compact       )
	// 复制集合 (Copy Collection    )

	// ------ ------ ------ ------ ------ //

	// C#中内置的GC机制，要注意：
	// 1. GC 只负责 堆(Heap)内存 的垃圾回收
	// 2. 引用类型都是在 堆(Heap)内存 中的，所以它的分配和释放都通过垃圾回收机制进行管理
	// 3. 栈(Stack)内存 的内存管理由 系统自动管理，无需进行操作
	// 4. 值类型在 栈(Stack)内存 中分配内存，他们有自己独立的生命周期，无需对他们进行管理，会由系统自动进行分配和释放

	// ------ ------ ------ ------ ------ //

	// C#中内存回收机制的大致原理：
	// 0代内存 ——> 1代内存 ——> 2代内存

	// 代的概念 |
	// 代是垃圾回收机制中使用的一种算法( 分代算法 )
	// 新分配的对象都会被存储在 0代内存 中
	// 每次分配都可能会进行垃圾回收以释放内存( 0代内存满时 )

	// 处理过程 |
	// 在一次内存回收过程开始时，垃圾回收器会认为堆(Heap)内存中的数据全是垃圾，之后会进行以下两步：
	// 1. 标记对象 从根(静态字段、方法参数)开始检查引用对象，标记后为可达对象，未标记为不可达对象
	//    不可达对象就会被认为是垃圾，会被清理释放
	// 2. 搬迁对象压缩堆(挂起执行托管代码线程)释放未标记的对象，搬迁可达对象，修改引用地址

	// ------ ------ ------ ------ ------ //

	// 大对象总被认为是 2代内存 ，目的是减少性能损耗，提高运行效率
	// 不会对大对象进行搬迁压缩 85000字节(83kb) 以上的对象被认为是大对象
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 手动触发垃圾回收的方法
			// 一般情况下不会主动调用，一般都是在加载界面等地方进行调用
			GC.Collect();
		}

		// 总结 |

		// 1. 构造函数
		// 实例化对象时，调用的函数。主要是用来初始化成员变量的。
        // > 基本语法：
		// 函数名和类名相同，访问修饰符根据需求而定，一般为public
		// class Demo{
		//       public Demo(){
		//              ... ...
		//       }
		// }
		// > 特别注意：
		// 可以重载构造函数，可以使用this复用重复的代码
		// 在函数中，利用this区分同名参数变量
		// 有参构造函数会默认顶掉默认的无参数构造函数

		// 2. 析构函数
		// 当对象被垃圾回收时，调用的函数。主要是
	}
}
