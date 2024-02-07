using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_多态_抽象类和抽象方法
{
	#region 知识点 1 | 抽象类
	// 概念 |
	// 被抽象关键字 abstract 修饰的类

	// 特点 |
	// 1. 不能被实例化的类
	// 2. 可以包含抽象方法
	// 3. 继承抽象类必须重写其抽象方法

	public abstract class Thing
	{
		// 抽象类中，封装的所有知识点都可以写在其中，
		// 而且还可以在抽象类中，写抽象函数
		public string name;
	}

	class Water : Thing
	{

	}
	#endregion

	#region 知识点 2 | 抽象函数
	// 抽象函数 又叫做 纯虚方法

	// 概念 |
	// 用 abstract 关键字修饰的方法

	// 特点 |
	// 1. 只能在程序类中申明
	// 2. 没有方法体
	// 3. 不能是私有的
	// 4. 继承后必须实现，一定要用 override 重写

	public abstract class Fruits
	{
		public string name;

		// 抽象方法，是一定不能有函数体的
		public abstract void Bad();

		// 虚方法，可以选择是否写具体逻辑
		public virtual void Test()
		{

		} 

	}

	class Apple : Fruits
	{
		// 抽象方法在子类中，是必须要实现
		public override void Bad()
		{
		    // 此为提示你，此方法内没有写任何内容，
			// 重写时，删除即可
			throw new NotImplementedException();
		}

		// 虚方法在子类中是可以选择是否实现
		//public override void Test()
		//{
		//	base.Test();
		//}
	}

	class SuperApple : Apple
	{
		// 抽象方法 和 虚拟方法
		// 都可以被子类无限制地去重写
		public override void Bad()
		{
			base.Bad();
		}
		public override void Test()
		{
			base.Test();
		}
	}

	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 特点：抽象类不可以被实例化
			// Thing t = new Thing();
			// 但是，抽象类遵循里氏替换原则，可以父类装载子类
			Thing water = new Water();
		}
	}

	#region 总结
	// 抽象类 |
	// 被 abstract 修饰的类，不能被实例化的类
	// 可以包含抽象方法
	
	// 抽象方法 |
	// 没有具体方法体的纯虚方法，继承以后必须重写

	// 注意 —— 如何选择普通类还是抽象类？
	// 1. ①不希望被实例化的对象，②相对比较抽象的类，可以使用抽象类
	// 2. 父类中的行为不太需要被实现的，只希望子类去定义如何具体实现规则的，可以选择抽象类，然后使用其中的抽象方法来定义规则的

	// 作用 |
	// 整体框架设计的时候会使用
	#endregion

}
