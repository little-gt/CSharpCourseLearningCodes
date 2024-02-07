using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_封装_索引器
{
	#region 知识点 1 | 索引器的基本概念
	// 基本概念 | 
	// 让对象可以可以像数组一样，通过索引访问其中的元素，使得程序看起来更加的直观，更加容易去编写
	#endregion

	#region 知识点 2 | 索引器的语法
	// 访问修饰符 返回值 this[参数类型 参数名, 参数类型 参数名 .......]
	// {
	//        内部的写法和规则，与之前的属性是相似的
	//        get{}
	//        set{}
	// }
	class Person
	{
		private string name;
		private int age;
		private Person[] friends;
		private string[,] notebook;

		public Person this[int index]
		{
			#region 知识点 4 | 索引器中可以写逻辑
			// 可以在这里写逻辑 根据需求来处理里面的内容
			get
			{
				if (friends == null || index - 1 > friends.Length)
				{
					return null;
				}
				return friends[index];
			}
			set
			{
				if (friends != null)
				{
					if (index - 1 > friends.Length)
					{
						friends[friends.Length - 1] = value;
					}
					friends[index] = value;
				}
			}
			#endregion
		}

		#region 知识点 5 | 索引器可以重载
		// 重载的概念 |
		// 函数名相同，但是参数类型、参数数量、参数顺序不同的函数，会进行重载
		public string this[int i, int j]
		{
			get
			{
				return notebook[i, j];
			}
		}
		#endregion
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 3 | 索引器的使用
			Person person = new Person();
			// 赋值
			person[0] = new Person();
			// 调用
			Console.WriteLine(person[0]);
			#endregion
		}
		
		// 总结 |
		// 索引器对于我们的主要作用是
		// 可以让我们以中括号的形式范围，自定义类中的元素，但是规则可以自定义，访问和修改和数组一样
		// 比较适用于，在类中有数组变量时使用，可以方便的进行逻辑处理

		// 写法 |
		// 访问修饰符 返回值 this[参数列表]
		// {
		//      get{} set{} 语句块
		// }
		// 注：可以重载函数

		// 注意 |
		// 结构体里面也是可以使用索引器的哦
	}
}
