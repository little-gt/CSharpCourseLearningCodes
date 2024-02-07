using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson6
{
	class Program
	{
		static void Main(string[] args)
		{
			/*  作业 |
			 *  请用至少两种方式在控制台打印出：
			 *  -----------------------------
			 *  我是小明
             *  我今年18
             *  我的爱好是制作游戏
             *  我要好好学习，天天向上
			 */
			Console.WriteLine("====== lesson6 ======");

			//1
			Console.WriteLine("我是小明" + "\n" + "我今年18" + "\n" + "我的爱好是制作游戏" + "\n" + "我要好好学习，天天向上");
			Console.WriteLine();

			//2
			Console.WriteLine("我是小明");
			Console.WriteLine("我今年18");
			Console.WriteLine("我的爱好是制作游戏");
			Console.WriteLine("我要好好学习，天天向上");
			Console.WriteLine();

			//3
			Console.Write("我是小明");
			Console.WriteLine();
			Console.Write("我今年18");
			Console.WriteLine();
			Console.Write("我的爱好是制作游戏");
			Console.WriteLine();
			Console.Write("我要好好学习，天天向上");
			Console.WriteLine();
		}
	}
}
