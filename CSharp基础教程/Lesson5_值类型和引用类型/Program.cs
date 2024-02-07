using System;

namespace Lesson5_值类型和引用类型
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== -/ 值类型和引用类型 /- ======");

			#region 知识点 1 | 变量类型的复习
			// 无符号整形
			/*
			byte valueByte = 1;
			ushort valueUshort = 1;
			uint valueUint = 1;
			ulong valueUlong = 1;
			*/

			// 有符号整形
			/*
			sbyte valueSbyte = 1;
			short valueShort = 1;
			int valueInt = 1;
			long valueLong = 1;
			*/

			// 浮点数
			/*
			float valueFloat = 2.33f;
			double valueDouble = 2.33;
			decimal valueDecimal = 2.33m;
			*/

			// 特殊类型
			/*
			bool valueBool = true;
			char valueChar = '6';
			string valueString = "233";
			*/

			// 复杂类型
			/*   1. 枚举 (enum)

			// 写在namespace下，不写在函数语句块中

			//enum E_自定义枚举名
	        //{
	        //    //枚举中包裹的 整型变量 第一个默认是0 下面的会一次累加
	        //    自定义枚举项名字,  // 0
	        //    自定义枚举项名字1, // 1
	        //	  自定义枚举项名字2, // 2
         	//} 

			/*   2. 数组（int[]、int[,]、int[][]）
			   
			// ☆ 一维数组
			// int[] valueArrayInt1 = new int[3];

			// ☆ 二维数组
			// int[,] valueArrayInt2 = new int[3,3];

			// ☆ 交错数组
			// int[][] valueArrayInt3 = new int[3][];
			
			 */

			// 把以上学过的变量类型 分成 值类型和引用类型
			// 引用类型：string, 数组, 类
			// 值类型：其他的（如int等）, 结构体
			#endregion

			#region 知识点 2 | 值类型和引用类型的区别
			/* 1. 使用上的区别 */

			// 值类型
			int a = 10;
			// 引用类型
			int[] arr = new int[] { 1, 2, 3, 4 };

			// 申明了一个b让其等于之前的a
			int b = a;
			// 申明了一个arr1让其等于之前的arr
			int[] arr1 = arr;

			// 区别的体现
			// 值类型 在相互赋值时 把内存拷贝给了对方 他变我不变
			// 引用类型的相互赋值 是把两者同时指向同一个值 他变我也变
			Console.WriteLine("====== -/ 初次赋值以后的状态 /- ======");
			Console.WriteLine("a = {0}; b = {1}", a, b);
			Console.WriteLine("arr[0] = {0}; arr1[0] = {1}", arr[0], arr1[0]);
			b = 233;
			arr1[0] = 233;
			Console.WriteLine("====== -/ 修改赋值以后的状态 /- ======");
			Console.WriteLine("a = {0}; b = {1}", a, b);
			Console.WriteLine("arr[0] = {0}; arr1[0] = {1}", arr[0], arr1[0]);

			/* 2. 为什么有以上的区别 */

			// 值类型 和 引用类型 存储在的内存区域是不同的 存储方式是不同的
			// 所以造成了 他们在使用上的不同

			// 值类型   存储在 栈空间 ——> 系统分配，自动回收，小而快
			// 引用类型 存储在 堆空间 ——> 手动申请，手动释放，大而慢


			#endregion
		}
	}
}
