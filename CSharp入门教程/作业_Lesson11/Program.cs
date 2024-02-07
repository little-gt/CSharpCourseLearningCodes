using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson11
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 习题1 | 定义一个变量存储客户的姓名，然后再屏幕上显示：“你好，XXX”。XXX代表客户的姓名
			Console.WriteLine("====== 习题 1 ======");

			string clientName;

			Console.WriteLine("您好，请输入您的姓名：");
			clientName = Console.ReadLine();
			Console.WriteLine("□ 你好，" + clientName);

			Console.WriteLine();
			#endregion

			#region 习题2 | 定义两个变量，一个存储客户的姓名，另一个存储年龄，然后再屏幕上显示：“xxx+yyy岁了“。xxx代表客户的姓名，yyy代表年龄。
			Console.WriteLine("====== 习题 2 ======");

			string userName;
			string userAge;

			Console.WriteLine("请输入您的用户名：");
			userName = Console.ReadLine();
			Console.WriteLine("请输入您的年龄：");
			userAge = Console.ReadLine();
			Console.WriteLine("□ {0}{1}岁了。", userName, userAge);

			Console.WriteLine();
			#endregion

			#region 习题3 | 当我们去面试时，前台会要求我们填一张表格，有姓名，年龄，邮箱，家庭住址，期望工资，请把这些信息在控制台输出
			Console.WriteLine("====== 习题 3 ======");

			string intervieweeName;
			string intervieweeEmail;
			string intervieweeAdress;
			int intervieweeAge = 0;
			int intervieweeIdealSalary = 0;

			Console.WriteLine("☆ 欢迎参加面试，我们需要您填写一些基本信息！");
			Console.WriteLine("○ 请输入您的姓名：");
			intervieweeName = Console.ReadLine();
			Console.WriteLine("○ 请输入您的电子邮箱地址：");
			intervieweeEmail = Console.ReadLine();
			Console.WriteLine("○ 请输入您的住址的大体位置：");
			intervieweeAdress = Console.ReadLine();
			try
			{
				Console.WriteLine("○ 请输入您的年龄：");
				intervieweeAge = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{ 
				intervieweeAge = 0;
				Console.WriteLine("× 填写的内容有误，未记录");
			}
			try
			{
				Console.WriteLine("○ 请输入您的理想工资（单位：元/月）：");
				intervieweeIdealSalary = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				intervieweeIdealSalary = 0;
				Console.WriteLine("× 填写的内容有误，未记录");
			}

			Console.WriteLine("☆ 填写完成，按任意键继续。");
			Console.ReadKey();
			Console.WriteLine();
			Console.WriteLine("☆ 好的，现在需要核验信息。");
			Console.WriteLine("□ 您填写的信息：\n□ 姓名：{0} 年龄：{1} 邮箱地址：{2} 家庭住址：{3} 理想工资：{4}", intervieweeName, intervieweeAge, intervieweeEmail, intervieweeAdress , intervieweeIdealSalary);

			Console.WriteLine();
			#endregion

			#region 习题4 | 请用户输入因户名、年龄、班级，最后一起用占位符形式打印出来
			Console.WriteLine("====== 习题 4 ======");

			string stuName;
			int stuAge = 0;
			int stuClass = 0;

			Console.WriteLine("☆ 欢迎登陆校园网，请完成相关信息的填写");
			Console.WriteLine("○ 请输入你的用户名：");
			stuName = Console.ReadLine();
			try
			{
				Console.WriteLine("○ 请输入你的年龄：");
				stuAge = int.Parse(Console.ReadLine());
			}
			catch
			{
				stuAge = 0;
				Console.WriteLine("× 填写的内容有误，未记录");
			}
			try
			{
				Console.WriteLine("○ 请输入你的班级号：");
				stuClass = int.Parse(Console.ReadLine());
			}
			catch
			{
				stuClass = 0;
				Console.WriteLine("× 填写的内容有误，未记录");
			}
			Console.WriteLine("□ 你好，{0}：\n□ 你的年龄：{1} | 你的班级号：{2}", stuName, stuAge, stuClass);
			#endregion
		}
	}
}
