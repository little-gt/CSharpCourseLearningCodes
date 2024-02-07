using System;

namespace Lesson2_一维数组
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 1 | 基本概念
			// 数组是存储一组相同类型
			// 数组分为 一维、多维、交错数组
			// 一般情况下：一维数组 被简称为 数组
			#endregion

			#region 知识点 2 | 数组的申明
			// 方法 1 | 只是申明了一个数组 但是没有存入数据 必须要在使用前初始化
			// 变量类型[] 数组名;
			int[] arr1;

			// 方法 2 | 申明数组，并且默认开了房间 每个房间内的值都为0
			// 变量类型[] 数组名 = new 变量类型[数组长度];
			int[] arr2 = new int[5];

			// 方法 3 | 申明数组，并且对每个房间进行赋值 且不能少必须全部赋值
			// 变量类型[] 数组名 = new 变量类型[数组长度]{内容1,内容2,内容3,......};
			int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

			// 方法 4 | 申明数组，并且花括号内的内容数量就是房间的个数，也就是对应房间内的值
			// 变量类型[] 数组名 = new 变量类型{内容1,内容2,内容3,......};
			int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			// 方法 5 | 方法4的简化版本，更加快捷
			int[] arr5 = { 1, 2, 3, 4, 5, 0 };
			#endregion

			#region 知识点 3 | 数组的使用
			// 1. 数组的长度
			// 数组变量名.Length
			/* Length获取的长度是从1开始的，所以
			 * 数组的标号最大 应该是 ( 数组变量名.Length - 1 )
			 */
			Console.WriteLine(arr5.Length);

			// 2. 获取数组中的元素
			// 数组中的下标和引索 他们都是从0开始的
			/* 通过索引下标去获取数组中某一个元素的值时
			 *  一定要注意！！！不可以越界！
			 */
			Console.WriteLine(arr5[0]);
			Console.WriteLine(arr5[1]);
			Console.WriteLine(arr5[2]);
			Console.WriteLine(arr5[5]);
			Console.WriteLine("===============");

			// 3. 修改数组中的元素
			// 数组变量名[引索值] = 某一个值;
			/* 引索值不能越界 这个值必须和变量类型一致
			 */
			arr5[5] = 6;

			// 4. 遍历数组 通过循环 快速获取数组中的每一个元素
			for (int i = 0; i < arr5.Length; i++)
			{
				Console.WriteLine(arr5[i]);
			}

			// 5. 增加数组的元素
			// 数组初始化以后 是不能 直接添加新的元素的 所以要搬家
			int[] arr6 = new int[10];
			// 搬家
			for (int i = 0; i < arr5.Length; i++)
			{
				arr6[i] = arr5[i];
			}
			arr5 = arr6;
			// 查看
			Console.WriteLine("===============");
			for (int i = 0; i < arr5.Length; i++)
			{
				Console.WriteLine(arr5[i]);
			}

			// 6. 删除数组中的元素
			// 在数组申明以后 是不能直接删除元素的 所有还要搬家
			int[] arr7 = new int[5];
			for (int i = 0; i < arr7.Length; i++)
			{
				arr7[i] = arr5[i];
			}
			arr5 = arr7;

			// 7. 查找数组中的元素
			// 99 2 3 4 5
			int a = 3;
			int[] arr8 = { 99, 2, 3, 4, 5 };
			for (int i = 0; i < arr8.Length; i++)
			{
				if (a == arr8[i])
				{
					Console.WriteLine("值0在arr8的第{0}的位置", i);
				}
			}
			#endregion

			arr1 = new int[] { 233, 233, 666 };
		}
	}
}
