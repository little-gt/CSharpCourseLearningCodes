using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_逻辑运算符
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== lesson 13 | 逻辑运算符 ======");
			// 对bool类型 进行逻辑运算

			#region 知识点1 | 逻辑 与
			// 符号 | &&
			// 规则 | 对两个bool值进行逻辑运算 有假则假 同真为真
			bool result;
			result = true && false;
			Console.WriteLine(result);
			result = false && false;
			Console.WriteLine(result);
			result = true && true;
			Console.WriteLine(result);

			// bool相关的类型 bool变量 逻辑运算符 bool变量
			// 逻辑运算符优先级 低于 条件运算符和算术运算符
			int i = 3;
			result = i > 1 && i < 5; //相当于判断 1 < i < 5
			Console.WriteLine(result);

			// 多个逻辑与 组合应用
			// 在没有括号的情况下 从左到右依次看即可 有括号 先看括号内的东西
			int i2 = 5;
			result = i2 > 1 && i2 < 5 && i > 1 && i < 5;
			Console.WriteLine(result);
			#endregion

			#region 知识点2 | 逻辑 或
			// 符号 | ||
			// 规则 | 对两个bool值进行逻辑运算 有真则真 同假为假
			result = true || false;
			Console.WriteLine(result);
			result = true || true;
			Console.WriteLine(result);
			result = false || false;
			Console.WriteLine(result);

			// 多个逻辑或 组合应用
			// bool相关的类型 bool变量 逻辑运算符 bool变量
			int a = 5;
			int b = 11;
			result = a > 1 || b < 10 || a <= b;
			Console.WriteLine(result);
			#endregion

			#region 知识点3 | 逻辑 非
			// 符号 | !
			// 规则 | 对一个bool值进行取反 真变假 假变真
			result = !true;
			Console.WriteLine(result);
			result = !false;
			Console.WriteLine(result);
			result = !!true;
			Console.WriteLine(result);

			// 错误示范 | 逻辑非的优先级很高 记得打括号哦~
			// result = !3 > 2;
			a = 5;
			result = !(a > b);
			Console.WriteLine(result);
			result = !(a < 10);
			Console.WriteLine(result);
			#endregion

			#region 知识点4 | 混合使用的优先级
			// 规则 |
			// 逻辑 非 > 算数运算符 > 逻辑 与 > 逻辑 或
			bool gameOver = false;
			bool isDead = false;
			bool isMustOver = false;
			int hp = 100;

			// 结果 |
			//         false  ||   false &&   true  ||    false     
			result = gameOver || hp <= 0 && !isDead || isMustOver;
			Console.WriteLine(result);
			#endregion

			#region 知识点5 | 逻辑运算符 短路规则
			int i3 = 1;
			// || 有真则真
			// 短路的规则 | 只要 逻辑与 或者 逻辑或 满足了条件
			// i3 > 0 ——> true 则 ++i3 会被抛弃不再计算
			result = i3 > 0 || ++i3 >= 1;
			Console.WriteLine(i3);
			Console.WriteLine(result);

			// && 有假则假
			// i3 < 0 ——> false 则 i3++ 会被抛弃不再计算 
			result = i3 < 0 && i3++ > 1;
			Console.WriteLine(i3);
			Console.WriteLine(result);
			#endregion
		}
	}
}
