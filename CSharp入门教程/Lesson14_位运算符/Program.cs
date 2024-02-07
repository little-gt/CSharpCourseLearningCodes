using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_位运算符
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 位运算符 ======");
			// 位运算符 | 主要用数值类型进行计算
			// 将数值转换为2进制 再进行位运算

			#region 知识点1 | 位与 &
			// 位与 | 对位运算 有0则0

			int a = 1;
			int b = 5;
			// 1 ——> 001
			// 5 ——> 101
			// & ==> 001
			int c = a & b;
			Console.WriteLine("c:" + c);

			a = 3;
			b = 19;
			// 3  ——> 00011
			// 19 ——> 10011
			// &  ==> 00011
			c = a & b;
			Console.WriteLine("c:" + c);

			// 多个数值进行位运算 没有括号时 依然是 从左到右 依次计算
			a = 1;
			b = 5;
			c = 19;
			// 1  ——> 00001
			// 5  ——> 00101
			// &  ==> 00001
			// 19 ——> 10011
			// &  ==> 00001
			int d = a & b & c;
			Console.WriteLine("d:" + d);
			#endregion

			#region 知识点2 | 位或
			// 位或 | 对位计算 有1则1

			a = 1;
			b = 3;
			// 1 ——> 001
			// 3 ——> 011
			// | ==> 011
			c = a | b;
			Console.WriteLine("c:" + c);

			a = 5;
			b = 10;
			c = 20;
			// 5  ——> 00101
			// 10 ——> 01010
			// |  ==> 01111
			// 20 ——> 10100
			// |  ==> 11111
			Console.WriteLine("结果:" + (a | b | c));
			#endregion

			#region 知识点3 | 异或
			// 异或 | 对位运算 相同为0 不同为1

			a = 1;
			b = 5;
			// 1 ——> 001
			// 5 ——> 101
			// ^ ——> 100
			c = a ^ b;
			Console.WriteLine("c:" + c);

			a = 10;
			b = 11;
			c = 4;
			// 10 ——> 1010
			// 11 ——> 1011
			// ^  ==> 0001
			// 4  ——> 0100
			// ^  ==> 0101
			Console.WriteLine("结果:" + (a ^ b ^ c));
			#endregion

			#region 知识点4 | 位取反
			// 位取反 | 对位计算 0变1 1变0

			a = 5;
			// (int)5 ——> 0 000 0000 0000 0000 0000 0000 0000 0101
			//    ~   ==> 1 111 1111 1111 1111 1111 1111 1111 1010
			// 第一位是符号位 在取反以后变成了负数
			// 取反成负数以后 转换规则为反码和补码
			c = ~a;
			Console.WriteLine("c:" + c);
			#endregion

			#region 知识点5 | 左移<< 和 右移>>
			// 规则 | 让一个数的2进制数 进行 左移和右移

			// 左移几位 右侧加几个0
			a = 5;
			c = a << 5;
			// 数值 5 数  ——>  101
			// 左移 1 位  ==>  1010
			// 左移 2 位  ==>  10100
			// 左移 3 位  ==>  101000
			// 左移 4 位  ==>  1010000
			// 左移 5 位  ==>  10100000
			Console.WriteLine("c:" + c);

			// 右移几位 右侧去掉几个0
			a = 5;
			c = a >> 2;
			// 数值 5 数  ——>  101
			// 右移 1 位  ==>   10
			// 右移 2 位  ==>    1
			Console.WriteLine("c:" + c);
			#endregion
		}
	}
}
