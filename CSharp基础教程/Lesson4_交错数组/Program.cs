using System;

namespace Lesson4_交错数组
{
	class Program
	{
		static void Main(string[] args)
		{
			/* 交错数组是一个非重点知识 */

			#region 知识点 1 | 基本概念
			// 交错数组 是 数组的数组，每个维度的数量可以不同
			// 注意：二维数组的每行列数必须相同，交错数组每行列数可以不同
			#endregion

			#region 知识点 2 | 交错数组的申明
			// 变量类型[][] 交错数组名;
			int[][] arr1;

			// 变量类型[][] 交错数组名 = new 变量类型[行数][];
			int[][] arr2 = new int[3][];

			// 变量类型[][] 交错数组名 = new 变量类型[行数][]{一维数组1, 一维数组2, 一维数组3, ... ...};
			int[][] arr3 = new int[4][] { new int[] {1, 1, 3, 5 },
										  new int[] {3, 2, 5 },
										  new int[] {9, 6 },
										  new int[] {7 }};
			#endregion

			#region 知识点 3 | 数组的使用
			int[][] array = { new int[] {1, 2, 3},
							  new int[] {4, 5},
							  new int[] {6}        };

			// 1. 数组的长度
			// 行
			Console.WriteLine(array.GetLength(0));
			// 列
			Console.WriteLine(array[1].Length);

			// 2. 获取交错数组中的元素
			// 注意：不要越界
			Console.WriteLine(array[0][1]);

			// 3. 修改交错数组中的元素
			array[0][0] = 0;
			Console.WriteLine(array[0][1]);

			// 4. 遍历交错数组
			Console.WriteLine("====== -| 数组 · 开始 |- ======");
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					Console.Write(array[i][j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("====== -| 数组 · 结束 |- ======");

			// 5. 增加交错数组的元素
			int[][] newHouse_ADD = new int[5][];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					newHouse_ADD[i][j] = array[i][j];
				}
			}

			// 6. 删除交错数组的元素
			int[][] newHouse_LIT = new int[2][];
			for (int i = 0; i < newHouse_LIT.GetLength(0); i++)
			{
				for (int j = 0; j < newHouse_LIT[i].Length; j++)
				{
					newHouse_LIT[i][j] = array[i][j];
				}
			}

			// 7. 查找交错数组的元素
			arr1 = new int[1][] { new int[] { 0, 1, 2, 3, 4, 5, 6, 7 } };
			Console.WriteLine(arr1[0][5]);
			#endregion
		}
	}
}
