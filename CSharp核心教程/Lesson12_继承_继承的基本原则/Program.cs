using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_继承_继承的基本原则
{
	#region 知识点 1 | 基本概念
	// 一个类A继承一个类B
	// 类A将会继承类B的所有成员
	// A类将拥有B类的所有特征和行为

	// 被继承的类
	// 称之为：父类、基类、超类

	// 继承的类
	// 称之为：子类、派生类

	// 注意 |
	// 子类可以有自己的特征和行为

	// 特点 |
	// 1. 单根性：子类只可以有一个父类
	// 2. 传承性：子类可以间接继承父类的父类
	#endregion

	#region 知识点 2 | 基本语法
	// class 类名 : 被继承的类名
	// {
	//     // CODES
	// }
	#endregion

	#region 知识点 3 | 实例
	class Teacher
	{
		/// <summary>
		/// 姓名
		/// </summary>
		public string name;
		/// <summary>
		/// 姓名
		/// </summary>
		public int id;

		public void SpeakName()
		{
			Console.WriteLine(name);
		}
	}

	class TeachingTeacher : Teacher
	{
		/// <summary>
		/// 任教科目
		/// </summary>
		public string subject;

		public void SpeakSubject()
		{
			Console.WriteLine(subject + "老师");
		}
	}

	class ChineseTeacher : TeachingTeacher
	{
		public void Skill_SpeakAPoem()
		{
			Console.WriteLine("一行白鹭上青天");
		}
	}
	#endregion

	#region 知识点 4 | 访问修饰符的影响
	// public    - 公共   内外部访问
	// private   - 私有   只能在内部访问
	// protected - 保护的 可以在内部和子类访问

	// 之后将会讲解到的访问修饰符：
	// internal  - 内部的 只有在同一个程序集的文件中，内部类型或者是成员才可以访问
	#endregion

	#region 知识点 5 | 子类和父类的同名成员
	// 非常不建议使用此方法
	class Computer
	{
		public string host;
	}
	class ComputerCPU : Computer
	{
		public string  host;
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			TeachingTeacher tt = new TeachingTeacher();
			tt.name = "TEST TEACHER";
			tt.id = 1;
			tt.subject = "C#";

			tt.SpeakName();
			tt.SpeakSubject();
		}
	}

	#region 总结 |

	#endregion
}
