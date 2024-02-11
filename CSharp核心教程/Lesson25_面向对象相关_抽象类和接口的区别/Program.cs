using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25_面向对象相关_抽象类和接口的区别
{
	#region 知识回顾
	// 抽象类和抽象方法 |
	abstract class 抽象类
	{
		// 注意，抽象方法前必须有 public 修饰
		// 即：public abstract 必须一起出现
		public abstract void 抽象方法();
	}
	// 被 abstract 修饰的类和方法
	// 抽象类不被实例化
	// 抽象方法只能在抽象类中申明，是一个纯虚方法，必须在子类中实现

	// 接口 |
	interface 接口
	{
		void 接口中的方法();

		string 接口中的属性 
		{
			get;
			set;
		}

		event Action 接口中的事件;
	}
	// interface 自定义类型
	// 接口是行为的抽象，
	// 接口不包含成员变量，
	// 接口仅包含方法、属性、索引器、事件，
	// 其中的成员都不能被实现，建议不写访问修饰符，默认 public 即可
	#endregion

	#region 知识点 1 | 相同点
	// 1. 都可以被继承
	// 2. 都不能直接实例化
	// 3. 都可以包含方法申明
	// 4. 子类必须实现未实现的方法
	// 5. 都遵循里氏替换原则
	#endregion

	#region 知识点 2 | 不同点
	// 1. 抽象类中可以有构造函数，接口中不能有构造函数；
	// 2. 抽象类只可以被单一继承，接口可以被继承多个；
	// 3. 抽象类中可以有成员变量，接口中不能有成员变量；
	// 4. 抽象类中可以申明成员方法、虚方法、抽象方法、静态方法，接口中只能申明没有实现的抽象方法；
	// 5. 抽象类中的抽象方法可以使用访问修饰符，接口中不建议写访问修饰符默认即可
	#endregion

	#region 知识点 3 | 如何选择抽象类和接口
	// 表示对象的用抽象类，表示行为扩展的用接口，
	// 不同对象拥有的共同行为，我们往往可以使用接口来实现
	// 举个例子:
	// 动物是一类对象，我们自然会选择抽象类；
	// 飞翔是一个行为，我们自然会使用接口。
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("■ Lesson 25 | 抽象类和接口的区别");
		}
	}
}
