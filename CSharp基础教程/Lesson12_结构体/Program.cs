using System;

namespace Lesson12_结构体
{
	#region 知识点 1 | 基本概念
	/* 结构体是一种自定义变量类型，类似于枚举需要我们自己定义
	 * 结构体是数据和函数的集合 ——> 在结构体中可以申明各种变量和函数(方法)
	 */

	//作用：用来表现存在关系的数据的集合 比如用结构体表现：学生、动物、人类等等
	#endregion

	#region 知识点 2 | 基本语法
	/* 注意：
	 * 1. 结构体一般写在 namespace语句块 中
	 * 2. 结构体的关键词 struct
	 */

	/*
	struct 自定义结构体名
	{
		// 第一部分 
		// 变量(必选)

		// 第二部分
		// 构造函数(可选)

		// 第三部分
		// 函数(常用)
	}
	*/

	// 注意：结构体名字是使用帕斯卡命名法
	#endregion

	#region 知识点 3 | 实例
	// 例子 | 学生数据的结构体
	struct Student
	{
		#region 知识点 5 | 访问修饰符
		// 访问修饰符
		// 修饰结构体中的变量和方法，说明是否可以被外部使用
		/* public  ——> 公共的 可以被外部访问
		 * private ——> 私有的
		 */
		// 注意：不申明默认为private
		#endregion

		// 变量
		// 构造体申明的变量，不能直接初始化
		// 变量类型可以写任意类型，包括其他结构体，但是不能自己包含自己
		public int stuAge;       // 年龄
		public bool stuSex;      // 性别
		public int stuNumber;    // 学号
		public string stuName;   // 姓名

		// 构造函数
		#region 知识点 6 | 构造体的构造函数
		// 基本概念
		// 1.没有返回值
		// 2.函数名必须和结构名相同
		// 3.必须有参数
		// 4.如果申明了构造函数 那么必须在其中对所有变量数据初始化

		// 构造函数一般是方便外部进行初始化的
		public Student(int stuAge, bool stuSex, int stuNumber, string stuName)
		{
			// 关键词 this |
			// 用于表示同名的变量是否属于是自己的
			this.stuAge = stuAge;
			this.stuName = stuName;
			this.stuNumber = stuNumber;
			this.stuSex = stuSex;
		}
		#endregion

		// 函数方法
		// 表现这个数据结构的行为
		// 注意：在结构体中的方法，目前暂不需要加上 static关键词
		public void Speak()
		{
			// 函数中可以直接使用结构体中的变量的
			Console.WriteLine("我的名字是{0}，我今年{1}岁了，很高兴认识你!", stuName, stuAge);
		}
		// 可以根据需要写无数个函数
	}
	#endregion


	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 4 | 结构体的使用
			// 变量的申明
			// 变量类型 变量名;
			Student s1;
			s1.stuAge = 10;
			s1.stuName = "小德";
			s1.stuSex = false;
			s1.stuNumber = 233;
			s1.Speak();

			Student s2 = new Student(17, false, 666, "小方");
			s2.Speak();
			#endregion
		}
	}
}
