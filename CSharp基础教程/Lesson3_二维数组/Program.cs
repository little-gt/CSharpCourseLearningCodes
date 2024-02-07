using System;

namespace Lesson3_二维数组
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 1 | 基本概念
			// 二维数组 是使用两个下标(引索)来确定元素的数组
			// 两个索引 可以理解为 行标 和 列标
			// 比如矩阵
			/* 1 2 3
			   4 5 6 */
			// 就可以使用二维数组 int[2,3] 表示
			// 好比 两行 三列 的数据集合
			#endregion

			#region 知识点 2 | 二维数组的申明
			// □ 与一维数组申明类似 |

			// 变量类型[,] 二维数组变量名;  // □ 这种方法在申明过后必须要在后面初始化

			// 变量类型[,] 二维数组变量名 = new 变量类型[行,列];

			// 变量类型[,] 二维数组变量名 = new 变量类型[行,列]{ {0行内容1, 0行内容2, 0行内容3, ... ...}，{1行内容1, 1行内容2, 1行内容3, ... ...} }；
			int[,] arr = new int[3, 3] { { 1, 2, 3 },
										 { 4, 5, 6 },
										 { 7, 8, 9 } };

			// 变量类型[,] 二维数组变量名 = new 变量类型[,]{ {0行内容1, 0行内容2, 0行内容3, ... ...}，{1行内容1, 1行内容2, 1行内容3, ... ...} }；
			int[,] arr2 = new int[,] { { 1, 2, 3 },
									   { 4, 5, 6 },
									   { 7, 8, 9 } };

			#endregion

			#region 知识点 3 | 二维数组的使用
			int[,] array = new int[,] { { 0, 2, 3 },
										{ 4, 5, 6 } };

			// 1. 二维数组的长度
			// 我们需要获取 行 和 列 分别是多长
			// 得到多少 行
			Console.WriteLine(array.GetLength(0));
			// 得到多少 列
			Console.WriteLine(array.GetLength(1));

			// 2. 获取二维数组中的元素
			// 注意：第一个元素的索引是0 最后一个元素的引索是Length-1
			Console.WriteLine(array[0, 1]);
			Console.WriteLine(array[1, 2]);

			// 3. 修改二维数组中的元素
			array[0, 0] = 1;
			Console.WriteLine(array[0, 0]);

			// 4. 遍历二维数组
			Console.WriteLine("===== - □ - =====");
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					// i 行
					// j 列
					Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}

			// 5. 增加数组的元素
			// 数组 申明初始化以后 就不能再在原有的基础上对房间进行 增加或者删除 了
			// 与一维数组一样，使用相同的方法进行搬家
			Console.WriteLine("===== - □ - =====");
			int[,] newhouse = new int[3, 3];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					newhouse[i, j] = array[i, j];
				}
			}
			for (int i = 0; i < newhouse.GetLength(0); i++)
			{
				for (int j = 0; j < newhouse.GetLength(1); j++)
				{
					Console.Write(newhouse[i, j] + " ");
				}
				Console.WriteLine();
			}

			// 6. 删除数组中的元素
			// 数组 申明初始化以后 就不能再在原有的基础上对房间进行 增加或者删除 了
			// 与一维数组一样，使用相同的方法进行搬家
			Console.WriteLine("===== - □ - =====");
			int[,] newhome = new int[3, 2];
			for (int i = 0; i < newhome.GetLength(0); i++)
			{
				for (int j = 0; j < newhome.GetLength(1); j++)
				{
					newhome[i, j] = newhouse[i, j];
				}
			}
			for (int i = 0; i < newhome.GetLength(0); i++)
			{
				for (int j = 0; j < newhome.GetLength(1); j++)
				{
					Console.Write(newhome[i, j] + " ");
				}
				Console.WriteLine();
			}

			// 7. 查找数组元素
			// 如果要在数组中查找个元素是否等于某个值
			// 通过遍历的形式去查找
			int a = 2;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (a == arr[i, j])
					{
						Console.WriteLine("和{0}相等的元素在数组第{1}行，第{2}列位置", a, i + 1, j + 1);
						break;
					}
				}
			}
			//打印结果：和2相等的元素在数组第1行，第2列位置

			#endregion
		}
	}
}
