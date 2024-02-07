using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_类和对象
{
	#region 知识回顾 | 面向对象编程概念
	// 万物皆对象
	// 用程序来抽象(形容)对象
	// 用面向对象的思维方法进行编程
	#endregion

	#region 知识点 1 | 什么是类
	// 基本概念 |
	// 具有相同特征
	// 具有相同行为
	// 一类事物的抽象
	// 类是对象的模版
	// 可以通过类创建出对象
	// 类的关键词:class
	#endregion

	#region 知识点 2 | 类申明在哪里
	// 类，一般申明在 namespace 语句块中
	#endregion

	#region 知识点 3 | 类申明的语法
	// 命名：帕斯卡命名法
	// 注意：在同一个语句块中的不同类 不能重名
	class 类名
	{
		// 特征 —— 成员变量
		// 行为 —— 成员方法
		// 保护特征 —— 成员属性

		// 构造函数和析构函数
		// 索引器
		// 运算符重载
		// 静态成员
	}
	#endregion

	#region 知识点 4 | 类申明实例
    // 这个类是用来形容人的
	class Person
	{

	}
	// 这个类是用来表示机器的
	class Machine
	{

	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 5 | 什么是(类)对象
			// 基本概念 |
			// 类的申明 和 类对象(变量)的申明 是两个概念
			// 类的申明 类似 枚举 和结构体的申明 类的申明相当于申明了一个自定义的变量类型
			// 而对象是类创建出来的
			// 相当于申明一个指定类型的变量
			// 类创建对象的过程 一般称为实例化对象
			// 类对象 都是引用类型的
			#endregion

			#region 知识点 6 | 实例化对象基本语法
			// 类名 变量名;
			// 类名 变量名 = null; // null 代表空
			// 类名 变量名 = new 类名();
			#endregion

			#region 知识点 7 | 实例化对象
			Person p1;
			Person p2 = null;        // null 代表空 代表不分配堆内存空间 和上面的写法效果是一致的
			Person p3 = new Person();// 相当于一个人对象
			Person p4 = new Person();// 相当于是另外一个人了
									 // 注意 |
									 // 虽然他们都是来自一个实例化对象
									 // 但是他们的特征、行为等等信息都是独立的
									 // 数据互不共享，彼此没有关系
			
			Machine m1 = new Machine();
			Machine m2 = new Machine();
			#endregion
		}
	}
}
