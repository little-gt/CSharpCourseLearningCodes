using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson12
{
	#region 自定义类 | 人类
	class Human
	{
		string name;
		int age;

		public void Speak(string context)
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(name + " ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(context);
		}
	}
	#endregion

	#region 继承类   | （人类）战士类
	class Soldier : Human
	{
		public void Attack()
		{
			Console.WriteLine("ATTACK!");
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
