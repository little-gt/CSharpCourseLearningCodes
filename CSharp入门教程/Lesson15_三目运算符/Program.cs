using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_三目运算符
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 三目运算符 ======");

			#region 知识点1 | 基本语法
			// 套路 | 3个空位 2个符号!!!
			// 固定写法 | 空位     ? 空位                : 空位;
			// 关键信息 | bool类型 ? bool类型为真返回内容 : bool类型为假返回的内容;
			// 三目运算符 会有返回值，这个返回值类型必须一致，并且必须使用
			string str;
			str = true ? "条件为真" : "条件为假";
			Console.WriteLine(str);
			str = true ? "条件为真" : "条件为假";
			Console.WriteLine(str);
			#endregion

			#region 知识点2 | 具体使用
			Random random = new Random();
			int a, i;
			
			a = random.Next(1, 100);
			str = a >= 50 ? "a大于等于50" : "a小于50";
			Console.WriteLine("a:" + a + " | 判断:" + str);

			a = random.Next(1, 100);
			i = a >= 50 ? 233 : 666;
			Console.WriteLine("i:" + i);

			// 第一个空位   | 始终是结果为 bool类型的值 或者 条件表达式 或者 逻辑运算符表达式
			// 第二三个空位 | 什么表达式都可以 只要保证他们的结果类型是一致的

			bool b = a >= 50 ? a > 6 : !false;
			#endregion
		}
	}
}
