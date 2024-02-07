using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson19
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("============== EXERCISESES 1 ==============");
			#region 习题 1 | 用户名和密码
			bool userLogin = false;
			bool isFirst = true; 
			string userName, userPass;
			do
			{
				if (!isFirst)
				{
					Console.Clear();
					Console.WriteLine("============== EXERCISESES 1 ==============");
					Console.WriteLine("× The username or password you entered is incorrect. Please re-enter it.");
				}
				Console.WriteLine("□ Please enter your username:");
				userName = Console.ReadLine();
				Console.WriteLine("□ Please enter your password:");
				userPass = Console.ReadLine();
				isFirst = false;
				if (userName == "admin" && userPass == "8888")
				{
					userLogin = true;
					continue;
				}
			} while (!userLogin);

			Console.Clear();
			Console.WriteLine("============== EXERCISESES 1 ==============");
			Console.WriteLine("√ Hi, " + userName + "! You have successfully logged in.");
			Console.WriteLine("△ Please press any key to enter the program for Exercise 2!");
			Console.ReadKey();
			Console.Clear();
			#endregion

			Console.WriteLine("============== EXERCISESES 2 ==============");
			#region 习题2 | 输入你的名字
			isFirst = true;
			userName = "";

			do
			{
				if (!isFirst)
				{
					Console.Clear();
					Console.WriteLine("============== EXERCISESES 2 ==============");
					Console.WriteLine("× The content you entered is not quite correct. Give it a try again, perhaps you will succeed at some point.");
				}
				Console.WriteLine("□ You need to enter your name to continue running the program:");
				userName = Console.ReadLine();
				isFirst = false;
			} while (userName != "小德");

			Console.Clear();
			Console.WriteLine("============== EXERCISESES 2 ==============");
			Console.WriteLine("√ Hi, " + userName + "! You're finally back.");
			Console.WriteLine("△ Please press any key to exit the program.");
			Console.ReadKey();
			System.Diagnostics.Process.GetCurrentProcess().Close();
			#endregion
		}
	}
}
