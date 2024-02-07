using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_面向对象相关_object万物之父中的方法
{
	class Test
	{

	}

	class Group1
	{
		public int i = 1;
		public Group2 t = new Group2();

		public Group1 Clone()
		{
			return MemberwiseClone() as Group1;
		}

	}
	class Group2
	{
		public int i = 2;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Lesson 22 - object万物之父中的方法");

			#region 知识回顾
			// 万物之父 object

			// 所有类型的基类 ( 所有类型都是 object 的子类 )
			// 是一个引用类型
			// 可以利用里氏替换原则装载一切对象
			// 存在装箱和拆箱
			#endregion

			#region 知识点 1 | object中的静态方法
			// 静态方法 Equals          |
			// 作用：判断两个对象是否相等，最终的判断权，交给左侧对象的Equals方法，
			// 注意：不管值类型引用类型如何，都会安装左侧对象Equals方法的规则来进行比较
			Console.WriteLine(Object.Equals(1, 1));
			Test t1 = new Test();
			Test t2 = new Test();
			Console.WriteLine(Object.Equals(t1, t2));
			t1 = t2;
			Console.WriteLine(Object.Equals(t1, t2));

			// 静态方法 ReferenceEquals |
			// 作用：比较两个对象是否是相同的引用，主要是用来比较引用类型的对象
			// 注意：值类型对象的 ReferenceEquals 返回值始终是 false
			Console.WriteLine(Object.ReferenceEquals(1, 1));
			Console.WriteLine(Object.ReferenceEquals(t1, t2));
			#endregion

			#region 知识点 2 | object中的成员方法
			// 普通方法 GetType         |
			// 该方法在反射相关知识点中是非常重要的方法，之后我们会具体的讲到这里返回的Type类型
			// 该方法的主要作用就是获取对象运行时的类型 Type
			// 通过 Type 结合反射相关知识点，可以做到很多关于对象的操作
			Test t = new Test();
			Type type = t.GetType();

			// 普通方法 MemberwiseClone |
			// 该方法用于获取对象的浅拷贝对象 ( 会返回一个新的对象 )
			// 但是新对象中的引用变量会和老对象中的一致
			Group1 p1 = new Group1();
			Group1 p2 = p1.Clone();
			Console.WriteLine("Group1 p1 克隆对象以后：");
			Console.WriteLine("p1.i = " + p1.i);
			Console.WriteLine("p1.t.i = " + p1.t.i);
			Console.WriteLine("p2.i = " + p2.i);
			Console.WriteLine("p2.t.i = " + p2.t.i);

			p2.i = 666;
			p2.t.i = 233;
			Console.WriteLine("执行 p2.i = 666");
			Console.WriteLine("执行 p2.t.i = 233");
			Console.WriteLine("p1.i = " + p1.i);
			Console.WriteLine("p1.t.i = " + p1.t.i);
			Console.WriteLine("p2.i = " + p2.i);
			Console.WriteLine("p2.t.i = " + p2.t.i);
			#endregion

			#region 知识点 3 | object中的虚拟方法
			// 虚方法 Equals      |
			// 默认实现还是比较两者是否为同一个引用，即相当于 ReferenceEquals
			// 但是微软在所有值类型的基类System.ValueType中重写了该方法，用于比较值相等
			// 当然，我们也可以重写该方法，定义自己比较相等的规则 ( 但是一般不这么做 )

			// 虚方法 GetHashCode |
			// 该方法是获取对象的哈希码
			// 哈希码 一种通过算法算出的，表示对象唯一的编码，但是不同对象的哈希码有可能一样，具体值是由具体的哈希算法决定的
			// 我们可以通过重写该函数，来自己定义对象的哈希码算法，正常情况下，使用极少，基本不用

			// 虚方法 ToString    |
			// 该方法用于返回当前对象代表的字符串，我们可以通过重写它定义我们自己的对象转字符串的规则，
			// 该方法非常常用，当我们调用打印方法时，默认就是使用对象的 ToString 方法后的内容打印出来
			#endregion
		}
	}

	#region 总结
	// 虚方法   ToString        | 自定义字符串转换规则
	// 成员方法 GetType          | 反射相关
	// 成员方法 MemberwiseClone  | 浅拷贝
	// 虚方法   Equals          | 自定义判断相等的规则
	#endregion
}
