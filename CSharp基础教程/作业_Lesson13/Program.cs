using System;
using System.Threading;

namespace 作业_Lesson13
{
	class Program
	{
		#region 冒泡排序函数
		static void SortBubbling(bool isUP, int[] inputArr, out int[] syncArr)
		{
			int[] arr = new int[inputArr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = inputArr[i];
			}
			if (isUP)
			{
				// 升序排序
				for (int m = 0; m < arr.Length; m++)
				{
					bool isRUN = false;
					for (int n = 0; n < arr.Length - m - 1; n++)
					{
						if (arr[n] > arr[n + 1])
						{
							int temp = arr[n];
							arr[n] = arr[n + 1];
							arr[n + 1] = temp;
							isRUN = true;
						}
					}
					if (!isRUN)
					{
						break;
					}
				}
			}
			else
			{
				// 降序排序
				for (int m = 0; m < arr.Length; m++)
				{
					bool isRUN = false;
					for (int n = 0; n < arr.Length - m - 1; n++)
					{
						if (arr[n] < arr[n + 1])
						{
							int temp = arr[n + 1];
							arr[n + 1] = arr[n];
							arr[n] = temp;
							isRUN = true;
						}
					}
					if (!isRUN)
					{
						break;
					}
				}
			}
			// 返回结果
			syncArr = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				syncArr[i] = arr[i];
			}
		}
		#endregion

		#region 作业开屏界面
		static void ProgramStartScreen()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("======== -|HOMEWORK|- ========");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("Using the bubbling sort method, write a function that can sort ascending or descending depending on the arguments passed in.");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("■ Please press any button to start running the main part of the program");
			Console.ReadKey(true);
			Console.Clear();
		}
		#endregion

		#region 询问是否输出数组
		static bool AskIsOutputArr()
		{
			bool isOUTPUT = true;
			bool isLOOP = true;
			do
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("======== -/HOMEWORK/- ========");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("□ Do you want the program to output the processed array (including ascending and descending arrays)?");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("■ Please press the \"a\" or \"d\" button to make a selection, and press \"e\" to confirm.");
				if (isOUTPUT)
				{
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.Write("< ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("YES ");
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.Write("NO ");
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine(">");

				}
				else
				{
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.Write("< ");
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.Write("YES ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("NO ");
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine(">");
				}
				char press = Console.ReadKey(true).KeyChar;
				switch (press)
				{
					case 'a':
						isOUTPUT = true;
						break;
					case 'd':
						isOUTPUT = false;
						break;
					case 'e':
						isLOOP = false;
						break;
				}
				Console.Clear();
			} while (isLOOP);
			Console.Clear();
			return isOUTPUT;
		}
		#endregion

		#region 作业结束页面
		static void ProgramEndScreen()
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("○ The homework program has completed running, press any key to end.");
			Console.ReadKey(true);
			Console.Clear();
			Environment.Exit(0);
		}
		#endregion

		static void Main(string[] args)
		{
			ProgramStartScreen();

			// 输出提示 "正在生成数组" 字符
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("======== -|HOMEWORK|- ========");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("■ Please be patient while the program generates a random array ...");
			// 生成数组
			int[] radomArr = new int[100];
			Random random = new Random();
			for (int i = 0; i < radomArr.Length; i++)
			{
				radomArr[i] = random.Next(0, 101);
			}
			// 延时
			Thread.Sleep(1000);
			Console.Clear();

			// 输出提示 "正在对数组进行排序" 字符
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("======== -|HOMEWORK|- ========");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("■ Please be patient while the program sorts the random array ...");
			// 升序排序
			int[] sortedUP;
			SortBubbling(true, radomArr, out sortedUP);
			// 降序排序
			int[] sortedDOWN;
			SortBubbling(false, radomArr, out sortedDOWN);
			// 延时
			Thread.Sleep(1000);
			Console.Clear();

			// 询问是否要输出排序以后得数组
			bool isOutput = AskIsOutputArr();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("======== -|HOMEWORK|- ========");
			if (isOutput)
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("■ Based on your choice, the program will output the sorted array content, which may take several seconds or even minutes.");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("======== | Original Array | ========");
				for (int i = 0; i < radomArr.Length; i++)
				{
					Console.Write(radomArr[i] + " ");
				}
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("======== | Ascending Array | ========");
				for (int i = 0; i < sortedUP.Length; i++)
				{
					Console.Write(sortedUP[i] + " ");
				}
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("======== | Descending Array | ========");
				for (int i = 0; i < sortedDOWN.Length; i++)
				{
					Console.Write(sortedDOWN[i] + " ");
				}
				Console.WriteLine();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("■ According to your choice, the program will not output any content.");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("======== | Original Array | ========");
				for (int i = 0; i < radomArr.Length; i++)
				{
					Console.Write(radomArr[i] + " ");
				}
				Console.WriteLine();
			}

			ProgramEndScreen();
		}
	}
}
