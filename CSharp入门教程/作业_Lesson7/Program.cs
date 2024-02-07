using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson7
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 问题1 | 什么情况下会出现数据类型的隐式转换，请举例说明
			// 大范围存小范围

			// double <—— float <—— 整形（无符号、有符号） <—— char
			// decimal <—— 整形（无符号、有符号） <—— char
			// long <—— int <—— short <—— sbyte
			// ulong <—— uint <—— ushort <—— byte

			// 无符号 没法隐式存储 有符号
			// 有符号 可以隐式存储 无符号（范围大小）
			#endregion

			#region 问题2 | 把你的名字转化为ASCII码，然后在控制台输出出来
			int myNameC1 = '小';
			int myNameC2 = '德';
			Console.WriteLine("我名字的ASCII码是：" + myNameC1 + " " + myNameC2);
			#endregion
		}
	}
}
