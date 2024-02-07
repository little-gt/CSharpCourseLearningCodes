using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_课后作业
{
	class Program
	{
		static void Main(string[] args)
		{
			//第一个课后作业
			//请用户输入用户名、年龄、班级；
			Console.WriteLine("===== 1 =====");
			Console.WriteLine("你好，我们需要搜集您的一些信息，请每一项信息输入完成以后按回车确认。");
			
			Console.WriteLine("请输入用户名");
			Console.ReadLine();

			Console.WriteLine("请输入你的年龄");
			Console.ReadLine();

			Console.WriteLine("请输入你的班级");
			Console.ReadLine();

			Console.WriteLine("谢谢(#^.^#)");

			//第二个课后作业
			//问用户喜欢什么运动，不管用户输入什么，你都回答：“哈哈，好巧，我也喜欢这个运动“。
			Console.WriteLine("===== 2 =====");
			Console.WriteLine("小明：你喜欢什么运动呢？");

			Console.Write("你：我喜欢");
			Console.ReadLine();

			Console.WriteLine("小明：哈哈，好巧，我也喜欢这个运动。");

			//第三个课后作业
			//在控制台上输出10X10的空心方阵
			Console.WriteLine("===== 3 =====");
			Console.WriteLine("□□□□□□□□□□");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□        □");
			Console.WriteLine("□□□□□□□□□□");

			//课后作业结束
			Console.WriteLine("===== END · 按任意键退出 =====");
			Console.ReadKey();
		}
	}
}
