using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_条件分支语句if
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("======== 条件分支语句 if ========");

			#region 知识点1 | 作用
			// 让顺序执行的代码 出现分支
			// if语句是第一个 可以让我们的程序 产生逻辑变化的语句
			#endregion

			#region 知识点2 | if 语句
			// 作用 | 满足条件时 多执行一些代码
			// 用法 ：
			// if ( bool类型值 ) 
			// {
			//      满足条件时 要执行的代码块
			// }
			// 注意：
			// 1.if语句的语法部分 不需要写分号
			// 2.if语句可以嵌套使用
			if (true)
			{
				Console.WriteLine("进入了 if语句代码块 执行其中的代码逻辑");
				Console.WriteLine("进入了 if语句代码块 执行其中的代码逻辑");
				Console.WriteLine("进入了 if语句代码块 执行其中的代码逻辑");
			}
			//if (false)
			//{
			//	Console.WriteLine("进入了 if语句代码块 执行其中的代码逻辑");
			//	Console.WriteLine("进入了 if语句代码块 执行其中的代码逻辑");
			//	Console.WriteLine("进入了 if语句代码块 执行其中的代码逻辑");
			//}
			Console.WriteLine("离开了 if语句代码块 继续执行其他代码");

			int a = 233;
			if (a > 100 && a < 300) 
			{
				Console.WriteLine("a满足：100 < a < 300");
			}

			string userName = "鸽子";
			string userPass = "233";
			if (userName == "鸽子")
			{
				Console.WriteLine("用户名正确");
				if (userPass=="233")
				{
					Console.WriteLine("密码正确");
				}
			}
			#endregion

			#region 知识点3 | if...else... 语句
			// 作用 ：
			// 产生两条分支 十字路 满足条件做什么 不满足做什么
			// 语法 ：
			// if ( bool类型值 )
			// {
			//      满足条件执行的代码;
			// }
			// else
			// {
			//      不满足条件执行的代码;
			// }
			// 注意 ：
			// 1.if...else... 语句 语法语句 不需要写分号
			// 2.if...else... 语句 可以嵌套
			bool valueBool = false;
			if (valueBool)
			{
				Console.WriteLine("满足 if条件 执行的语句块");
			}
			else
			{
				Console.WriteLine("不满足 if条件 执行的语句块");
			}
			#endregion

			#region 知识点4 | if...else if...else if ... 语句
			// 作用 ：
			// 产生多条分支 多条道路选择 最先满足其中的一个条件 就做什么
			// 语法 ：
			// if ( bool类型值 )
			// {
			//      满足条件执行的代码;
			// }
			// else if ( bool类型值 )
			// {
			//      满足条件执行的代码;
			// }
/*
			if (true)
			{
				Console.WriteLine("啊啊啊 ε＝ε＝ε＝(#>д<)ﾉ");
			}
			else if (true)
			{
				Console.WriteLine("啊啊啊 ε＝ε＝ε＝(#>д<)ﾉ");
			}
			else if (true)
			{
				Console.WriteLine("啊啊啊 ε＝ε＝ε＝(#>д<)ﾉ");
			}
			else
			{
				Console.WriteLine("诶诶诶 ε＝ε＝ε＝(#>д<)ﾉ");
			}
*/
			// 注意 ：
			// 1. 和前面两个是一样的 不需要写分号
			// 2. 是可以嵌套的
			// 3. else是可以省略
			// 4. 注意 条件判断 从上到下执行 满足一个以后 之后的就不会执行了
			#endregion
		}
	}
}
