using System;

namespace 作业_Lesson3
{
	class Program
	{
		static void Main(string[] args)
		{
			// 申明通用判断是否循环的变量
			bool isRun = true;
			// 申明判断是否要输出二维变量
			bool isOutPut = true;
			// 申明用于储存光标所在的位置
			int positionCursor_x;
			int positionCursor_y;
			//
			string infoError;

			Console.Clear();
			#region 习题 1 |
			// 申明习题1的变量
			int[,] testArrayC1 = new int[100, 100];
			int countC1 = 1;
			// 输出习题1的标题
			Console.WriteLine("====== -| 习题 1 |- ======");
			Console.WriteLine("○ 将1到10000赋值给一个二维数组(100行100列).");
			// 循环给二维数组进行赋值
			for (int i = 0; i < testArrayC1.GetLength(0); i++)
			{
				for (int j = 0; j < testArrayC1.GetLength(1); j++)
				{
					testArrayC1[i, j] = countC1;
					countC1 += 1;
				}
			}
			// 询问是否要输出二维数组
			Console.WriteLine("○ Do you want to output this 2D array matrix?");
			positionCursor_x = Console.CursorLeft;
			positionCursor_y = Console.CursorTop;
			do
			{
				Console.SetCursorPosition(positionCursor_x, positionCursor_y);
				Console.WriteLine("                                                                                                 ");
				Console.WriteLine("                                                                                                 ");
				Console.WriteLine("                                                                                                 ");
				Console.SetCursorPosition(positionCursor_x, positionCursor_y);
				if (isOutPut)
				{
					Console.WriteLine("■ Confirm");
					Console.WriteLine("□ Cancel");
					Console.WriteLine("Press 'w' or 's' to select up and down, and press 'e' to confirm the selection.");
				}
				else
				{
					Console.WriteLine("□ Confirm");
					Console.WriteLine("■ Cancel");
					Console.WriteLine("Press 'w' or 's' to select up and down, and press 'e' to confirm the selection.");
				}
				char pressKey = Console.ReadKey(true).KeyChar;
				switch (pressKey)
				{
					case 'w':
					case 'W':
						if (!isOutPut)
						{
							isOutPut = true;
						}
						break;
					case 's':
					case 'S':
						if (isOutPut)
						{
							isOutPut = false;
						}
						break;
					case 'e':
					case 'E':
						isRun = false;
						Console.SetCursorPosition(positionCursor_x, positionCursor_y);
						Console.WriteLine("                                                                                                 ");
						Console.WriteLine("                                                                                                 ");
						Console.WriteLine("                                                                                                 ");
						Console.SetCursorPosition(positionCursor_x, positionCursor_y);
						break;
				}
			} while (isRun);
			// 根据反馈进行对应操作
			if (isOutPut)
			{
				for (int i = 0; i < testArrayC1.GetLength(0); i++)
				{
					for (int j = 0; j < testArrayC1.GetLength(1); j++)
					{
						Console.Write(testArrayC1[i, j] + " ");
					}
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("☆ 已根据你的要求，取消了数组输出");
			}
			// 结束程序提示
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 | 运行下一题程序时，不要滑动滚动条 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			Console.Clear();
			#endregion

			#region 习题 2 |
			// 申明习题2的变量
			int[,] testArrayC2 = new int[4, 4];
			Random random = new Random();
			// 输出习题2的标题
			Console.WriteLine("====== -| 习题 2 |- ======");
			Console.WriteLine("○ 将二维数组(4行4列)的右上半部分置零(元素随机1~100).");
			// 按要求对数组进行随机赋值
			for (int i = 0; i < testArrayC2.GetLength(0); i++)
			{
				for (int j = 0; j < testArrayC2.GetLength(1); j++)
				{
					if (i >= j)
					{
						testArrayC2[i, j] = random.Next(1, 101);
					}
					Console.Write(testArrayC2[i, j] + " ");
				}
				Console.WriteLine();
			}
			// 结束程序提示
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 | 运行下一题程序时，不要滑动滚动条 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			Console.Clear();
			#endregion

			#region 习题 3 |
			// 申明习题3的变量
			int[,] testArrayC3 = new int[10, 10];
			int totalAdd = 0;
			string totalAddFormula = "";
			// 输出习题3的标题
			Console.WriteLine("====== -| 习题 3 |- ======");
			Console.WriteLine("○ 求二维数组(10行10列)的对角线元素的和(元素随机1~9).");
			// 根据习题3要求进行操作
			for (int i = 0; i < testArrayC3.GetLength(0); i++)
			{
				for (int j = 0; j < testArrayC3.GetLength(1); j++)
				{
					// 对数组进行赋值
					testArrayC3[i, j] = random.Next(1, 10);
					if (i == j || i + j == testArrayC3.GetLength(0) - 1)
					{
						// 对对角线上的值进行筛选并且合成算式
						totalAdd += testArrayC3[i, j];
						if (i == testArrayC3.GetLength(0) - 1 && j == testArrayC3.GetLength(1) - 1)
						{
							totalAddFormula += testArrayC3[i, j] + " = " + totalAdd;
						}
						else
						{
							totalAddFormula += testArrayC3[i, j] + "+";
						}
					}
					Console.Write(testArrayC3[i, j] + " ");
				}
				// 对二维数组进行换行
				Console.WriteLine();
			}
			Console.WriteLine(totalAddFormula);
			// 结束程序提示
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 | 运行下一题程序时，不要滑动滚动条 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			Console.Clear();
			#endregion

			#region 习题 4 |
			// 申明习题4的变量
			int[,] testArrayC4 = new int[15, 15];
			int tempMAX = 0;
			// 输出习题4的标题
			Console.WriteLine("====== -| 习题 4 |- ======");
			Console.WriteLine("○ 求二维数组(15行15列)中最大元素值及其行列号(元素随机1~500).");
			// 按题目要求处理数组的值
			for (int i = 0; i < testArrayC4.GetLength(0); i++)
			{
				for (int j = 0; j < testArrayC4.GetLength(1); j++)
				{
					testArrayC4[i, j] = random.Next(1, 501);
					if (tempMAX <= testArrayC4[i, j])
					{
						tempMAX = testArrayC4[i, j];
					}
					if (testArrayC4[i, j] < 10)
					{
						Console.Write("00" + testArrayC4[i, j] + " ");
					}
					else if (testArrayC4[i, j] < 100)
					{
						Console.Write("0" + testArrayC4[i, j] + " ");
					}
					else
					{
						Console.Write(testArrayC4[i, j] + " ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("数组中的最大值是：" + tempMAX);
			// 结束程序提示
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 | 运行下一题程序时，不要滑动滚动条 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			Console.Clear();
			#endregion

			#region 习题 5 |

			// 申明习题5的数组
			int mIndex = 5;
			int nIndex = 5;
			try
			{
				Console.WriteLine("请输入行数(非零数)");
				mIndex = int.Parse(Console.ReadLine());
				Console.WriteLine("请输入列数(非零数)");
				nIndex = int.Parse(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("请输入数字");
			}

			int[,] array5 = new int[mIndex, nIndex];
			Random r = new Random();

			bool[] hang = new bool[mIndex];//行标识
			bool[] lie = new bool[nIndex];//列标识

			for (int i = 0; i < array5.GetLength(0); i++)
			{
				for (int j = 0; j < array5.GetLength(1); j++)
				{
					array5[i, j] = r.Next(0, 2);
					if (array5[i, j] == 1)
					{
						//记录当前行列是否要变1的标识
						//要变1就为true
						hang[i] = true;
						lie[j] = true;
					}
					Console.Write(array5[i, j] + "  ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("*******分割线*******");
			for (int i = 0; i < array5.GetLength(0); i++)
			{
				for (int j = 0; j < array5.GetLength(1); j++)
				{
					//满足行列标识为true  变1
					if (hang[i] || lie[j])
					{
						array5[i, j] = 1;
					}
					Console.Write(array5[i, j] + "  ");
				}
				Console.WriteLine();
			}

			#endregion
		}
	}
}
