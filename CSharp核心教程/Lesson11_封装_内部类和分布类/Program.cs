using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_封装_内部类和分布类
{
	#region 知识点 1 | 内部类
	// 概念 |
	// 在一个类中再申明一个类

	// 特点 |
	// 使用时要用包裹者点出自己

	// 作用 |
	// 紧密关系的变现

	// 注意 |
	// 在内部类中，分修饰符的作用很大

	class Person
	{
		public int age;
		public string name;
		public Body body;
		public class Body
		{
			Arm leftArm;
			Arm rightArm;
			class Arm
			{

			}
		}
	}

	#endregion

	#region 知识点 2 | 分部类
	// 概念 |
	// 把一个类分成好几个部分

	// 关键字 |
	// partial

	// 作用 |
	// 1. 分布描述一个类；
	// 2. 增加程序的拓展性。

	// 注意 |
	// 1. 分部类可以写在多个脚本文件当中；
	// 2. 分部类的访问修饰符要一致；
	// 3. 分部类当中不能有重复的成员。

	public partial class Student
	{
		public string name;
		public int age;
	}

	public partial class Student
	{
		public void Speak(string context)
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(name + " ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(context);
		}
	}

	#endregion

	#region 知识点 3 | 分布方法
	// 概念 | 
	// 将方法的申明和实现分离
	
	// 特点 |
	// 1. 不能加访问修饰符【默认私有】；
	// 2. 只能在部分类当中申明；
	// 3. 返回值只能是void；
	// 4. 可以有参数，但是不用out关键字。

	// 注意 | 局限较大，了解即可

	partial class exampleP3
	{
		public bool sasa;

		partial void Speak();
	}

	partial class exampleP3
	{
		partial void Speak()
		{
			throw new NotImplementedException();
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 内部类的使用
			Person p = new Person();
			Person.Body body = new Person.Body();
		}
	}
}
