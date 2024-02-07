using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson8
{
	static class MathCalculator
	{
		/// <summary>
		/// 常量 | π (精确度10位)
		/// </summary>
		private static float PI = 3.141592678f;

		/// <summary>
		/// 计算圆的面积 | 返回float的圆面积，π精度为10位有效数字
		/// </summary>
		/// <param name="r">圆半径</param>
		/// <returns>圆面积</returns>
	    public static float CircularArea(float r)
		{
			return PI * r * r;
		}

		/// <summary>
		/// 计算圆的周长 | 返回float的圆周长，π精度为10位有效数字
		/// </summary>
		/// <param name="r">圆的半径</param>
		/// <returns>圆周长</returns>
		public static float Circumference(float r)
		{
			return 2 * PI * r;
		}

		/// <summary>
		/// 计算矩形的面积 | 返回float类型的矩形的面积
		/// </summary>
		/// <param name="length">长</param>
		/// <param name="width">宽</param>
		/// <returns>矩形面积</returns>
		public static float RectangularArea(float length, float width)
		{
			return length * width;
		}

		/// <summary>
		/// 计算矩形的周长 | 返回float类型的矩形的周长
		/// </summary>
		/// <param name="length">长</param>
		/// <param name="width">宽</param>
		/// <returns>矩形周长</returns>
		public static float RectangularPerimeter(float length, float width)
		{
			return length * 2 + width * 2;
		}

		/// <summary>
		/// 取绝对值 | 返回输入的float值的绝对值
		/// </summary>
		/// <param name="v">需要取绝对值的数</param>
		/// <returns>绝对值</returns>
		public static float AbsoluteValue(float v)
		{
			if (v < 0f)
			{
				return -v;
			}
			return v;
		}
	}

	class Program
	{

		#region 界面 | 程序开始页面绘制
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
			Console.WriteLine("Write a static class for math calculations. This class provides methods for calculating the area of a circle, the circumference of a circle, the area of a rectangle, the circumference of a rectangle, and the absolute value of a number.");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("□ Press Any Key To Start Running");
			Console.ReadKey(true);
			Console.Clear();
		}
		#endregion

		#region 界面 | 作业结束页面绘制
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
			Console.ReadKey(true);
			Environment.Exit(0);
		}
		#endregion

		#region 功能 | 根据选中的选项进行处理
		static void DrawFunctionalInterfaces(int selectedOption, string strDescriptionFunction)
		{
			float valueA;
			float valueB;
			Console.Clear();
			// 界面 | 标题文字
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("Simple Calculator");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Function:" + strDescriptionFunction);
			Console.WriteLine("Please enter the data as prompted and press enter to confirm.");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("========================");

			Console.ForegroundColor = ConsoleColor.White;

			// 0 -> 圆面积
			if (selectedOption == 0)
			{
				// 要求用户输入圆的半径
				Console.Write("The radius of the circle: ");
				try
				{
					valueA = float.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(1);
					Console.ForegroundColor = ConsoleColor.White;
					valueA = 1;
				}
				// 输出圆的面积
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("========================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Results: " + MathCalculator.CircularArea(valueA));
				Console.WriteLine("Tip    : Press any key to return to the main menu.");
			}

			// 1 -> 圆周长
			if (selectedOption == 1)
			{
				// 要求用户输入圆的半径
				Console.Write("The radius of the circle: ");
				try
				{
					valueA = float.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(1);
					Console.ForegroundColor = ConsoleColor.White;
					valueA = 1;
				}
				// 输出圆的周长
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("========================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Results: " + MathCalculator.Circumference(valueA));
				Console.WriteLine("Tip    : Press any key to return to the main menu.");
			}

			// 2 -> 矩形面积
			if (selectedOption == 2)
			{
				// 要求用户输入矩形的长
				Console.Write("The length of a rectangle : ");
				try
				{
					valueA = float.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(1);
					Console.ForegroundColor = ConsoleColor.White;
					valueA = 1;
				}
				// 要求用户输入矩形的宽
				Console.Write("The width of the rectangle: ");
				try
				{
					valueB = float.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(1);
					Console.ForegroundColor = ConsoleColor.White;
					valueB = 1;
				}
				// 输出矩形的面积
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("========================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Results: " + MathCalculator.RectangularArea(valueA, valueB));
				Console.WriteLine("Tip    : Press any key to return to the main menu.");
			}

			// 3 -> 矩形周长
			if (selectedOption == 3)
			{
				// 要求用户输入矩形的长
				Console.Write("The length of a rectangle : ");
				try
				{
					valueA = float.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(1);
					Console.ForegroundColor = ConsoleColor.White;
					valueA = 1;
				}
				// 要求用户输入矩形的宽
				Console.Write("The width of the rectangle: ");
				try
				{
					valueB = float.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(1);
					Console.ForegroundColor = ConsoleColor.White;
					valueB = 1;
				}
				// 输出矩形的周长
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("========================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Results: " + MathCalculator.RectangularPerimeter(valueA, valueB));
				Console.WriteLine("Tip    : Press any key to return to the main menu.");
			}

			Console.ReadKey(true);
		}
		#endregion

		static void Main(string[] args)
		{
			DrawProgramOpeningScreen();

			int selectedOption = 0;
			bool isLoop = true;
			string[] nameMenu = new string[5] { "Calculate the area of a circle", "Calculate the circumference of a circle", "Calculate rectangular area", "Calculate the perimeter of a rectangle", "Take an absolute value" };
			do
			{
				Console.Clear();
				// 界面 | 标题文字
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("Simple Calculator");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("========================");
				// 界面 | 菜单显示
				Console.ForegroundColor = ConsoleColor.White;
				for (int i = 0; i < nameMenu.Length; i++)
				{
					if (i == selectedOption)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("> ");
					}
					Console.WriteLine(nameMenu[i]);
					Console.ForegroundColor = ConsoleColor.White;
				}
				// 界面 | 结尾说明
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("========================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Tips: Please press \"w\" or \"s\" to control the options, and press \"e\" to enter the function. If you need to exit, press the \"x\" button.");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("Selected:" + selectedOption);

				// 功能 | 获取用户按下的按键是否是“w”“s”“e”“x”中的一个，并且进行逻辑处理
				char tPressed = Console.ReadKey(true).KeyChar;
				switch (tPressed)
				{
					// 选择上面的选项
					case 'w':
						selectedOption -= 1;
						if (selectedOption <= 0)
						{
							selectedOption = 0;
						}
						break;
					// 选择下面的选项
					case 's':
						selectedOption += 1;
						if (selectedOption >= nameMenu.Length - 1)
						{
							selectedOption = nameMenu.Length - 1;
						}
						break;
					// 确认选择的选项
					case 'e':
						DrawFunctionalInterfaces(selectedOption ,nameMenu[selectedOption]);
						break;
					// 退出作业程序
					case 'x':
						isLoop = false;
						break;
				}
			} while (isLoop);

			DrawProgramEndScreen();
		}
	}
}
