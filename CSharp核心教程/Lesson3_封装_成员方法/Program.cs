using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_封装_成员方法
{
	#region 知识点 1 | 成员方法的申明
	// 基本概念 |
	// 成员方法(函数) 用来表现对象的行为
	// 1. 申明在类语句块中
	// 2. 是用来描述对象的行为的
	// 3. 规则和函数申明规则相同
	// 4. 受到访问修饰符规则影响
	// 5. 返回值参数不做限制
	// 6. 方法的数量不做限制

	// 注意    |
	// 1. 成员方法 现阶段不要加 static(静态的) 关键字
	// 2. 成员方法 必须要实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
	// 3. 成员方法 受到访问修饰符影响

	// 代码实践 |
	// C++ 中一般把成员方法写在前面 因为重要的是要做的事情 而不是变量是什么
	// c#  中一般把成员方法写在后面 因为比较好阅读审查变量
	class Person
	{
		/// <summary>
		/// 判断是否成年
		/// </summary>
		/// <param name="str">要说的话</param>
		public void Speak(string str)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("□ ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(name);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" 说：{0}", str);
		}

		/// <summary>
		/// 判断是否成年
		/// </summary>
		/// <returns>真——>成年；假——>未成年</returns>
		public bool IsAdult()
		{
			if (age >= 18)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="P"></param>
		public void	AddFriend(Person P)
		{
			if (friends == null)
			{
				friends = new Person[] { P };
			}
			else
			{
				// 新建一个新的房间
				Person[] tempFriends = new Person[friends.Length + 1];
				// 搬家
				for (int i = 0; i < friends.Length; i++)
				{
					tempFriends[i] = friends[i];
				}
				// 把新的朋友放在最后一个
				tempFriends[tempFriends.Length - 1] = P;
				// 地址重定向
				friends = tempFriends;
			}
		}

		public string name; // 姓名
		public int age;     // 年龄
		public Person[] friends; // 朋友们
	}
	#endregion
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 2 | 成员方法的使用
			// 注意    |
			// 成员方法 必须要实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
			Person p1 = new Person();
			p1.name = "Teacher Tang";
			p1.age = 18;

			p1.Speak("Hello!");
			if (p1.IsAdult())
			{
				p1.Speak("I am an adult.");
			}
			else
			{
				p1.Speak("I am a teenager.");
			}

			Person p2 = new Person();
			p2.name = "Tang's Friend";
			p2.age = 17;

			p1.AddFriend(p2);

			Console.WriteLine(p1.friends);
			#endregion
		}
	}
}
