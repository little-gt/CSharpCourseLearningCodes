using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson14
{
	class Program
	{
		#region 函数 | 根据传入参数进行选择排序
		static void FeatureSelectionSorting(bool isUP, int[] rawArr, out int[] outArr)
		{
			// 第 1 步 | 将原函数转移到输出函数
			outArr = new int[rawArr.Length];
			for (int i = 0; i < rawArr.Length; i++)
			{
				outArr[i] = rawArr[i];
			}

			// 第 2 步 | 判断排序的方式(升序/降序)
			if (isUP)
			{
				// 第 3 步 | 进行升序排序
				for (int i = 0; i < outArr.Length; i++)
				{
					int index = 0;
					for (int k = 1; k < outArr.Length - 1 - i; k++)
					{
						if (outArr[index] < outArr[k])
						{
							index = k;
						}
					}
					int temp = outArr[index];
					outArr[index] = outArr[outArr.Length - 1 - i];
					outArr[outArr.Length - 1 - i] = temp;
				}
			}
			else
			{
				// 第 3 步 | 进行降序排序
				for (int i = 0; i < outArr.Length; i++)
				{
					int index = 0;
					for (int k = 1; k < outArr.Length - 1 - i; k++)
					{
						if (outArr[index] > outArr[k])
						{
							index = k;
						}
					}
					int temp = outArr[index];
					outArr[index] = outArr[outArr.Length - 1 - i];
					outArr[outArr.Length - 1 - i] = temp;
				}
			}
		}
		#endregion

		#region 界面 | 程序开始界面绘制与功能实现
		static void DrawProgramOpeningScreen()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine();
			Console.WriteLine("        ... ........                                                                    ........     ");
			Console.WriteLine("        ............                                                                    ...,`...     ");
			Console.WriteLine("    .....=@]..@@]    ....        ............        ....,`.............    .. .    .=@@@^......     ");
			Console.WriteLine("    ....=@@@@@=@@@@]]]]]]].        O@@@^.O@@@..       ..]@@@`..@@@@@@@@@@.    .,]]]]]]]]@@@O]]]]].   ");
			Console.WriteLine("    ...@@@@@,@@@@@@@@@[[[[`        @@@@^ @@@@..    ....=@@@^...@@...O@@@@.    .=@@@@[[[[[[[[[[[[.    ");
			Console.WriteLine("    ..@@@@@.@@@@@=@@@@.....        @@@@^ @@@@..    .......=@...@@@@@@@@@@.     =@@@@..O@@@@@@@@..    ");
			Console.WriteLine("    .@@@@@@^=@@@@`=@@@@.............@@@@^ @@@@`........=@@@@@@@@@..... .....     @@@O....@@@@....... ");
			Console.WriteLine("    ..,@@@@^...,`.=@@@@[[[`.....@@..@@@@^ @@@@`.@`....,[[[@@[[[@@@@@@@@@..     O@@@OO@@@@@@@@@@@@@@. ");
			Console.WriteLine("        .=@^      =@@@@.....    =@@.@@@@^ @@@@,@@..    ..@@@@`....@@@@^...    .@@@@^.   =@@@@^.@@@.. ");
			Console.WriteLine("        .=@^      =@@@@@@@@^    .=@@@@@^ @@@@@@^...    .@@@^@@@@@@@@@@@@^    .@@@@^..  =@@@@^...[... ");
			Console.WriteLine("        .=@^      =@@@@.     .....@@@@@@^.@@@@[`.......@^=@^.,.. .@@@@^. .    .@@@@^.   =@@@@^       ");
			Console.WriteLine("        .=@^      =@@@@.    ...@@@@@@@@@@@@@@@@@@@@^.....=@^.. ...@@@@^. .     @@@@^..  =@@@@^       ");
			Console.WriteLine("        .=@^    ..=@@@@.                              ...=@^.=@@@@@@@@@@@@@^...@@@@^...,@@@@@^       ");
			Console.WriteLine("        ....    ...`,.`.                                ............  ...........[``.........[[`     ");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("■ HOMEWORK: ");
			Console.WriteLine("Write a program to sort an array with 100 elements assigned by random numbers in ascending and descending order by selecting the sorting method.");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("□ Press Any Key To Start Running");
			Console.ReadKey(true);
			Console.Clear();
		}
		#endregion

		#region 界面 | 作业结束页面
		static void DrawProgramEndScreen()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine();
			Console.WriteLine("        ... ........                                                                    ........     ");
			Console.WriteLine("        ............                                                                    ...,`...     ");
			Console.WriteLine("    .....=@]..@@]    ....        ............        ....,`.............    .. .    .=@@@^......     ");
			Console.WriteLine("    ....=@@@@@=@@@@]]]]]]].        O@@@^.O@@@..       ..]@@@`..@@@@@@@@@@.    .,]]]]]]]]@@@O]]]]].   ");
			Console.WriteLine("    ...@@@@@,@@@@@@@@@[[[[`        @@@@^ @@@@..    ....=@@@^...@@...O@@@@.    .=@@@@[[[[[[[[[[[[.    ");
			Console.WriteLine("    ..@@@@@.@@@@@=@@@@.....        @@@@^ @@@@..    .......=@...@@@@@@@@@@.     =@@@@..O@@@@@@@@..    ");
			Console.WriteLine("    .@@@@@@^=@@@@`=@@@@.............@@@@^ @@@@`........=@@@@@@@@@..... .....     @@@O....@@@@....... ");
			Console.WriteLine("    ..,@@@@^...,`.=@@@@[[[`.....@@..@@@@^ @@@@`.@`....,[[[@@[[[@@@@@@@@@..     O@@@OO@@@@@@@@@@@@@@. ");
			Console.WriteLine("        .=@^      =@@@@.....    =@@.@@@@^ @@@@,@@..    ..@@@@`....@@@@^...    .@@@@^.   =@@@@^.@@@.. ");
			Console.WriteLine("        .=@^      =@@@@@@@@^    .=@@@@@^ @@@@@@^...    .@@@^@@@@@@@@@@@@^    .@@@@^..  =@@@@^...[... ");
			Console.WriteLine("        .=@^      =@@@@.     .....@@@@@@^.@@@@[`.......@^=@^.,.. .@@@@^. .    .@@@@^.   =@@@@^       ");
			Console.WriteLine("        .=@^      =@@@@.    ...@@@@@@@@@@@@@@@@@@@@^.....=@^.. ...@@@@^. .     @@@@^..  =@@@@^       ");
			Console.WriteLine("        .=@^    ..=@@@@.                              ...=@^.=@@@@@@@@@@@@@^...@@@@^...,@@@@@^       ");
			Console.WriteLine("        ....    ...`,.`.                                ............  ...........[``.........[[`     ");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("□ The program has now finished running and exited. Please close the console window to exit completely.");
			Environment.Exit(0);
		}
		#endregion

		static void Main(string[] args)
		{
			DrawProgramOpeningScreen();

			// 创建随机数组并且为其赋值
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("Please Be Patient: the array is being evaluated");
			Random random = new Random();
			int[] rawArr = new int[100];
			for (int i = 0; i < rawArr.Length; i++)
			{
				rawArr[i] = random.Next(0, 100);
			}
			Console.Clear();

			// 对随机数组进行排序
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("Please Be Patient: the array is undergoing selection sorting");
			int[] sortArrUP;
			int[] sortArrDOWN;
			FeatureSelectionSorting(true, rawArr, out sortArrUP);
			FeatureSelectionSorting(false, rawArr, out sortArrDOWN);
			Console.Clear();

			// 进入输出控制的界面
			int tempSelectedOption = 0;
			bool tempIsRUN = false;
			do
			{
				// 界面 | 按要求输出数组
				if (tempIsRUN)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
					Console.WriteLine("======== -| Array Output Interface |- ========");

					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("■ The Original Array |");
					Console.ForegroundColor = ConsoleColor.White;
					for (int i = 0; i < rawArr.Length; i++)
					{
						Console.Write(rawArr[i] + " ");
					}
					Console.WriteLine();

					if (tempSelectedOption == 0 || tempSelectedOption == 1)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("■ The Ascending Array |");
						Console.ForegroundColor = ConsoleColor.White;
						for (int i = 0; i < sortArrUP.Length; i++)
						{
							Console.Write(sortArrUP[i] + " ");
						}
						Console.WriteLine();
					}

					if (tempSelectedOption == 0 || tempSelectedOption == 2)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("■ The Descending Array |");
						Console.ForegroundColor = ConsoleColor.White;
						for (int i = 0; i < sortArrDOWN.Length; i++)
						{
							Console.Write(sortArrDOWN[i] + " ");
						}
						Console.WriteLine();
					}

					Console.WriteLine();
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("■ Press the \"x\" button to return to the previous screen.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("==========================");
					Console.WriteLine("Student: GarfieldTom | Date: 2023-08-25 | Lesson14");
					do
					{
						char press = Console.ReadKey(true).KeyChar;
						if (press == 'x' || press == 'X')
						{
							break;
						}
					} while (true);

					tempIsRUN = false;
					Console.Clear();
				}

				// 界面 | 主菜单选择界面
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("□ The array has been processed, do you need to have the program output the array for verification?");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("■ Press \"w\" and \"s\" to select up and down, and press \"e\" to confirm the selection");
				Console.WriteLine("==========================");
				Console.WriteLine();

				switch (tempSelectedOption)
				{
					case 0:
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("> Outputs all arrays");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("- Output ascending array");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("- Output descending array");

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("- EXIT");
						break;
					case 1:
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("- Outputs all arrays");
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("> Output ascending array");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("- Output descending array");

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("- EXIT");
						break;
					case 2:
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("- Outputs all arrays");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("- Output ascending array");
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("> Output descending array");

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("- EXIT");
						break;
					case 3:
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("- Outputs all arrays");
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("- Output ascending array");
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("- Output descending array");

						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine();
						Console.WriteLine("> EXIT");
						break;
				}
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("==========================");
				Console.WriteLine("Student: GarfieldTom | Date: 2023-08-25 | Lesson14");

				switch (Console.ReadKey(true).KeyChar)
				{
					case 'w':
					case 'W':
						if (tempSelectedOption > 0)
						{
							tempSelectedOption -= 1;
						}
						break;

					case 's':
					case 'S':
						if (tempSelectedOption < 3)
						{
							tempSelectedOption += 1;
						}
						break;

					case 'e':
					case 'E':
						tempIsRUN = true;
						break;
				}
				if (tempIsRUN)
				{
					if (tempSelectedOption == 3)
					{
						break;
					}
				}
				Console.Clear();
			} while (true);

			DrawProgramEndScreen();
		}
	}
}
