using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_多态_密封方法
{
	#region 知识回顾
	// 密封类 |
	// 用 sealed 修饰的类，被称之为密封类
	// 让类无法再被继承
	#endregion

	#region 知识点 1 | 密封方法基本概念
	// 用密封关键字 sealed 修饰的重写函数
	// 作用：让虚方法或者抽象方法之后不能再被重写
	// 特点：和 override 一起出现
	#endregion

	#region 知识点 2 | 实例
	abstract class Animal
	{
		public string name;
		public abstract void Eat();
		public virtual void Speak()
		{
			Console.WriteLine("叫");
		}
	}
	class Person : Animal
	{
		public override void Eat()
		{
			throw new NotImplementedException();
		}

		public sealed override void Speak()
		{
			base.Speak();
		}
	}
	class Child : Person
	{
		public override void Eat()
		{
			base.Eat();
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
		}
	}

	// 总结 |
	// 密封方法可以让虚拟方法和抽象方法不能再被子类重写
	// 且密封方法一定和 override 一起出现
}
