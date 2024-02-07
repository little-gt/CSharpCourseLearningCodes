using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson14
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 作业 · lesson 14 ======");

			#region 习题1 | 35<<4 和 66>>1 的结果？
			Console.WriteLine("□习题1 |");
			// 35 ——> 100011
			// << ==> 1000110000
			Console.WriteLine("35<<4 的结果 | " + (35 << 4));
			// 66 ——> 1000010
			// >> ==> 10001
			Console.WriteLine("66>>1 的结果 | " + (66 >> 1));
			#endregion

			#region 习题2 | 99^33 和 76|85 的结果？
			Console.WriteLine("□习题2 |");
			// 99 ——> 1100011
			// 33 ——> 0100001
			// ^  ==> 1000010
			Console.WriteLine("99^33 的结果 | " + (99 ^ 33));
			// 76 ——> 1001100
			// 85 ——> 1010101
			// |  ==> 1011101
			Console.WriteLine("76|85 的结果 | " + (76 | 85));
			#endregion
		}
	}
}
