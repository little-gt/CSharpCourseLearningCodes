using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_变量的本质
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("第三课 变量的本质");

			#region 变量类型回顾
			// 类型1 | 有符号的整数
			// sbyte     [-128~127]
			// int       [-21亿多~21亿多]
			// short     [-3万多~3万多]
			// long      [-9百万兆多~9百万兆多]

			// 类型2 | 无符号的整数
			// byte      [0~255]
			// uint      [0~42亿多]
			// ushort    [0~6万多]
			// ulong     [0~18百万兆多]

			// 类型3 | 浮点数（以有效数字计）
			// float     [7~8位有效数字]
			// double    [15~17位有效数字]
			// decimal   [27~28位有效数字]

			// 类型4 | 特殊类
			// bool      [布尔数 true 或 false]
			// char      [查尔数 只能存储 一个字符]
			// string    [字符串 可以存储 一串字符]
			#endregion

			#region 知识点1 | 变量的存储空间（在内存中的存储空间）
			// 1byte = 8bit
			// 1MB = 1024byte
			// 1GB = 1024MB
			// 1TB = 1024GB

			// 通过sizeof方法 可以获取变量类型所占的内存空间 （单位：字节）
			// 有符号
			Console.WriteLine("========== 这是 有符号 的变量的内存空间 ==========");
			int SizeSbyte = sizeof(sbyte);
			Console.WriteLine("sbyte   所占的字节数为：" + SizeSbyte);
			int SizeInt = sizeof(int);
			Console.WriteLine("int     所占的字节数为：" + SizeInt);
			int SizeShort = sizeof(short);
			Console.WriteLine("short   所占的字节数为：" + SizeShort);
			int SizeLong = sizeof(long);
			Console.WriteLine("long    所占的字节数为：" + SizeLong);
			//无符号
			Console.WriteLine("========== 这是 无符号 的变量的内存空间 ==========");
			int SizeByte = sizeof(byte);
			Console.WriteLine("byte    所占的字节数为：" + SizeByte);
			int SizeUint = sizeof(uint);
			Console.WriteLine("uint    所占的字节数为：" + SizeUint);
			int SizeUshort = sizeof(ushort);
			Console.WriteLine("ushort  所占的字节数为：" + SizeUshort);
			int SizeUlong = sizeof(ulong);
			Console.WriteLine("ulong   所占的字节数为：" + SizeUlong);
			//浮点数
			Console.WriteLine("========== 这是 浮点数 的变量的内存空间 ==========");
			int SizeFloat = sizeof(float);
			Console.WriteLine("float   所占的字节数为：" + SizeFloat);
			int SizeDouble = sizeof(double);
			Console.WriteLine("double  所占的字节数为：" + SizeDouble);
			int SizeDecimal = sizeof(decimal);
			Console.WriteLine("decimal 所占的字节数为：" + SizeDecimal);
			//特殊型
			Console.WriteLine("========== 这是 特殊型 的变量的内存空间 ==========");
			int SizeBool = sizeof(bool);
			Console.WriteLine("bool    所占的字节数为：" + SizeBool);
			int SizeChar = sizeof(char);
			Console.WriteLine("char    所占的字节数为：" + SizeChar);
			// sizeof是无法得到 string类型 的内存空间的 因为 字符串的大小是可变的！
			// 你只能得一个 可以确定大小 的变量的内存空间
			#endregion


			#region 知识点2 | 变量的本质

			#endregion
		}
	}
}
