using System;

namespace 作业_Lesson8
{
	class Program
	{
		static void GetUserName(out string userName)
		{
			do
			{
				Console.WriteLine("====== -/ 用户登录 /- ======");
				Console.WriteLine("■ 请输入账户的用户名：");
				userName = Console.ReadLine();
				if (userName != "")
				{
					break;
				}
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("× 欲登录的账户的用户名不得为空，请重新输入.");
				Console.ForegroundColor = ConsoleColor.White;
			} while (true);
		}

		static void GetUserPass(out string userPass)
		{
			do
			{
				Console.WriteLine("====== -/ 用户登录 /- ======");
				Console.WriteLine("■ 请输入账户的密码：");
				userPass = Console.ReadLine();
				if (userPass != "")
				{
					break;
				}
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("× 欲登录的账户的密码不得为空，请重新输入.");
				Console.ForegroundColor = ConsoleColor.White;
			} while (true);
		}

		static bool UserLogin(string userName, string userPass, ref string loginErrorInfo)
		{
			if (userName != "小德")
			{
				loginErrorInfo = "账户用户名错误";
				return false;
			}
			if (userPass != "233")
			{
				loginErrorInfo = "账户密码错误";
				return false;
			}
			return true;
		}

		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();

			string userName;
			string userPass;
			string loginErrorInfo = "未知错误";
			do
			{
				// 获取账户的用户名和密码
				GetUserName(out userName);
				Console.Clear();
				GetUserPass(out userPass);
				Console.Clear();
				// 进行用户登录，并且获取结果
				if (UserLogin(userName, userPass, ref loginErrorInfo))
				{
					break;
				}
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("× 登录失败，因为{0}.", loginErrorInfo);
				Console.ForegroundColor = ConsoleColor.White;
			} while (true);

			Console.WriteLine("====== -/ 你好，{0} /- ======", userName);
			Console.Write("□ 用户名:");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(userName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(",密码:");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(userPass);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(".");
			Console.WriteLine("====== -/ 再见，{0} /- ======", userName);
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}
	}
}
