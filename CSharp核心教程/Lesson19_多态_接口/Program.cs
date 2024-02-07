using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_多态_接口
{

	#region 知识点 1 | 接口的概念
	// 接口是行为的抽象规范
	// 它也是一种自定义类型
	// 关键字：interface

	// 接口申明的规范 |
	// 1. 不包含成员变量
	// 2. 只包含方法、属性、索引器、事件
	// 3. 成员不能被实现
	// 4. 成员可以不用写访问修饰符，不能是私有的
	// 5. 接口不能继承类，但是可以继承另一个接口

	// 接口的使用规范 |
	// 1. 类可以继承多个接口
	// 2. 类继承接口以后，必须实现接口中所有成员

	// 特点 ：
	// 1. 它和类的申明类似
	// 2. 接口是用来继承的
	// 3. 接口不能被实例化，但是可以作为容器储存对象
	#endregion

	#region 知识点 2 | 接口的申明
	// 接口关键字：interface

	// 语法 |
	//interface 接口名
	//{
	//      // 接口代码库
	//}

	// 注意 |
	// 接口是抽象行为的"基类";
	// 接口命名规范，遵循帕斯卡命名法
	// 与数组是类似的，一般来说，在前面加上 I 进行区分

	interface IFly
	{
		// 方法
		void Fly();

		// 属性
		string Str
		{
			get;
			set;
		}

		// 索引器
		int this[int index]
		{
			get;
			set;
		}

		// 事件
		event Action dosomething;
	}
	#endregion

	#region 知识点 3 | 接口的使用
	// 接口是用来继承的

	class Animal
	{

	}

	class Human : Animal, IFly
	{
		public int this[int index] 
		{ 
			get => throw new NotImplementedException(); 
			set => throw new NotImplementedException(); 
		}

		public string Str 
		{
			get 
			{
				return "2";
			}
			set 
			{
				if (value == null)
				{
					Str = "NULL";
				}
				Str = value;
			}
		}

		public event Action dosomething;

		// 注意：
		// 实现接口的函数，可以再加上 virtual 以后，再在子类里面重写
		public virtual void Fly()
		{
			throw new NotImplementedException();
		}
	}

	// 1. 类可以继承 1 个类，可以继承 n 个接口
	// 2. 继承了接口以后，必须实现其中的内容，并且必须是 public 的
	// 3. 实现的接口函数，可以加上 virtual 再在子类重写
	// 4. 接口也遵循里氏替换原则
	#endregion

	#region 知识点 4 | 接口可以继承接口
	// 接口继承接口时 不需要实现具体的方法
	// 待类继承接口后 类自己去实现所有内容

	interface IWalk
	{
		void Walk();
	}
	interface IMove : IFly, IWalk
	{

	}

	class Test : IMove
	{
		public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string Str { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public event Action dosomething;

		public void Fly()
		{
			throw new NotImplementedException();
		}

		public void Walk()
		{
			throw new NotImplementedException();
		}
	}
	#endregion

	#region 知识点 5 | 显示实现接口
	// 使用条件 |
	// 当一个类继承两个接口，但是接口中存在着同名方法时
	// 注意事项 |
	// 显示实现接口时，不能写访问修饰符

	interface IAttack
	{
		void Attack();
	}
	interface ISuperAttack
	{
		void Attack();
	}

	class Player : IAttack, ISuperAttack
	{
		public void Attack()
		{

		}

		// 显示接口的代码实现
		// 返回类型 接口名.行为名()
		// {
		//         // 实现方法的代码
		// }

		void IAttack.Attack()
		{

		}

		void ISuperAttack.Attack()
		{

		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 注意：
			// 接口也遵循里氏替换原则
			IFly flyPerson = new Human();

			// 提示：
			// 接口继承接口以后，再由类继承，
			// 那么那个类，可以看做这些接口的子类
			IMove move = new Test();
			IWalk walk = new Test();

			// 注意：
			// 通过显示接口以后，需要先转换才能使用
			// 也就是下面的情况
			Player player = new Player();
			player.Attack();
			(player as IAttack).Attack();
			(player as ISuperAttack).Attack();
		}
	}

	#region 总结 |
	// 继承类 |
	// 继承类是  【对象】间的继承，包括行为特征等等
	
	// 继承接口 |
	// 继承接口是【行为】间的继承，继承接口的行为规范，按照规范去实现内容
	// 由于接口也遵循里氏替换原则，因此接口也可以作为接口容器装载对象
	// 那么就可以实现，装载各种毫无关系，但是却又拥有相同行为的对象

	// 注意事项 |
	// 1. 接口值可以包含：
	//    成员方法、属性、索引器、事件，并且都不实现，
	//    访问修饰符一般都是 public 只有少数情况下才是 protected
	// 2. 类，可以继承多个接口，但是只能继承一个类
	// 3. 接口可以继承接口，相当于在进行行为的合并，待子类继承时再去实现具体的行为
	// 4. 接口可以被显示实现，主要用于实现不同接口中同名函数的不同表现
	// 5. 类在实现接口方法时，可以加上 virtual 关键字，之后在子类中进行重写
	#endregion
}
