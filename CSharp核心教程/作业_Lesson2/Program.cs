using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson2
{
	#region 数组 | 性别
	enum E_HumanSex
	{
		Woman,     // 女性
		Man,       // 男性
		Other,     // 其他性别
		Undefined, // 未设置
	}
	#endregion

	#region 类 | 人类
	class Human
	{
		public string name;     //姓名
		public float height;      //身高
		public E_HumanSex sex = E_HumanSex.Undefined; // 性别
		public string location; //地址
	}
	#endregion

	#region 类 | 个人
	class Person
	{
		int age;
	}
	#endregion

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
			Console.WriteLine("Write a program to sort an array with 100 elements assigned by random numbers in ascending and descending order by selecting the sorting method.");
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
			Environment.Exit(0);
		}
		#endregion

		#region 程序 | 输出性别代码对应的性别
		static string FunctionSexCode(E_HumanSex code)
		{
			switch (code)
			{
				case E_HumanSex.Woman:
					return "female";
				case E_HumanSex.Man:
					return "male";
				case E_HumanSex.Other:
					return "other";
				case E_HumanSex.Undefined:
					return "undefined";
				default:
					return "error";
			}
		}
		#endregion

		#region 程序 | 修改用户的变量
		static void FunctionP1ChangeValue(int tempCode, ref Human H1, ref Human H2)
		{
			bool isLoopMain = true;

			do
			{
				// 界面 | 界面和操作指引
				Console.Clear();
				Console.WriteLine("■ Please enter what you want to change and press enter to confirm.");
				if (tempCode >= 0 && tempCode <= 3)
				{
					Console.Write("□ ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("H1's ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.Write("□ ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("H2's ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				if (tempCode == 0 || tempCode == 4)
				{
					Console.Write("New Name: ");
				}
				if (tempCode == 1 || tempCode == 5)
				{
					Console.Write("New Sex (Please enter \"Woman\" \"Man\" \"Other\" or \"Undefined\"): ");
				}
				if (tempCode == 2 || tempCode == 7)
				{
					Console.Write("New Height: ");
				}
				if (tempCode == 3 || tempCode == 8)
				{
					Console.Write("New Location: ");
				}

				// 操作 | 用户输入修改内容
				Console.ForegroundColor = ConsoleColor.Cyan;
				string tempEnter = Console.ReadLine();
				Console.ForegroundColor = ConsoleColor.White;

				try
				{
					// H1 |
					if (tempCode == 0)
					{
						H1.name = tempEnter;
					}
					if (tempCode == 1)
					{
						H1.sex = (E_HumanSex)Enum.Parse(typeof(E_HumanSex), tempEnter);
					}
					if (tempCode == 2)
					{
						H1.height = Convert.ToSingle(tempEnter);
					}
					if (tempCode == 3)
					{
						H1.location = tempEnter;
					}
					// H2 |
					if (tempCode == 4)
					{
						H2.name = tempEnter;
					}
					if (tempCode == 5)
					{
						H2.sex = (E_HumanSex)Enum.Parse(typeof(E_HumanSex), tempEnter);
					}
					if (tempCode == 6)
					{
						H2.height = Convert.ToSingle(tempEnter);
					}
					if (tempCode == 7)
					{
						H2.location = tempEnter;
					}
					isLoopMain = false;
				}
				catch (Exception)
				{
					// 异常 | 输入的值不合法，询问是否重新尝试或者退出
					Console.Clear();
					Console.WriteLine("======== |ERROR| ========");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× The modification cannot be completed because what you have entered does not comply with the regulations.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("■ Press \"x\" to exit, or \"r\" to try again.");
					bool isLoopChar = true;
					do
					{
						char tempChar = Console.ReadKey(true).KeyChar;
						switch (tempChar)
						{
							case 'x':
								isLoopChar = false;
								isLoopMain = false;
								break;
							case 'r':
								isLoopChar = false;
								break;
						}
					} while (isLoopChar);
				}
			} while (isLoopMain);
		}
		#endregion

		static void Main(string[] args)
		{
			// 作业程序开始UI
			DrawProgramOpeningScreen();

			#region 习题 1 | 3P是什么？
			// 输出标题和题目  |
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("======== |HOMEWORK| ========");
			Console.WriteLine("■ HOMEWORK |");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("访问修饰符是哪 3P ，请简述？");
			// 输出答案       |
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("■ ANSWER |");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("1. public    ——> 公共的 | 允许内外部进行使用");
			Console.WriteLine("2. private   ——> 私有的 | 只允许内部进行使用");
			Console.WriteLine("3. protected ——> 保护的 | 只允许该类中的使用");
			// 程序结束输出提示 |
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine();
			Console.WriteLine("This subtopic has ended, press any key to switch to the next subtopic.");
			Console.ReadKey(true);
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			#endregion

			#region 习题 2 | 定义一个人类，有姓名，身高，年龄，家庭住址等特征用人创建若干个对象
			// 初始化对象和对象的值
			Human H1 = new Human();
			Human H2 = new Human();
			H1.name = "Sample 1";              // 0
			H1.sex = E_HumanSex.Man;           // 1
			H1.height = 2.33f;                 // 2
			H1.location = "Sample Location 1"; // 3
			H2.name = "Sample 2";              // 4
			H2.sex = E_HumanSex.Woman;         // 5
			H2.height = 2.33f;                 // 6
			H2.location = "Sample Location 2"; // 7

			// 初始化选中的选项
			int tempSelection = 0;
			bool isLoopMain = true;

			// 主屏幕 | 选择与输出
			do
			{
				Console.Clear();
				// 输出标题和题目  |
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("======== |HOMEWORK| ========");
				Console.WriteLine("■ HOMEWORK |");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("定义一个人类，有姓名，身高，年龄，家庭住址等特征用人创建若干个对象");
				// 输出答案       |
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("■ OPERATION |");
				Console.WriteLine("□ Please press \"w\" and \"s\" to select up and down, and then press \"e\" to confirm the selection and edit. Please press \"x\" to proceed to the next question.");
				Console.WriteLine();
				Console.WriteLine("======== |USER PROFILE| ========");
				// 输出选项 ( H1 )
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("■ Profile: {0} |", H1.name);
				for (int i = 0; i < 4; i++)
				{
					// 判断是否选中，选中后进行标记突出
					if (i == tempSelection)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write("> ");
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.White;
					}
					// 根据代码输出对应的信息
					switch (i)
					{
						case 0:
							Console.WriteLine("Name        | {0}", H1.name);
							break;
						case 1:
							string tempSexDescription = FunctionSexCode(H1.sex);
							Console.WriteLine("Sex & Code  | {0} (Code:{1})", tempSexDescription, (int)H1.sex);
							break;
						case 2:
							Console.WriteLine("Height (cm) | {0}", H1.height);
							break;
						case 3:
							Console.WriteLine("Location    | {0}", H1.location);
							break;
					}
					Console.ForegroundColor = ConsoleColor.White;
				}
				Console.WriteLine();
				// 输出选项 ( H2 )
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("■ Profile: {0} |", H2.name);
				for (int i = 4; i < 8; i++)
				{
					// 判断是否选中，选中后进行标记突出
					if (i == tempSelection)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write("> ");
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.White;
					}
					// 根据代码输出对应的信息
					switch (i)
					{
						case 4:
							Console.WriteLine("Name        | {0}", H2.name);
							break;
						case 5:
							string tempSexDescription = FunctionSexCode(H2.sex);
							Console.WriteLine("Sex & Code  | {0} (Code:{1})", tempSexDescription, (int)H2.sex);
							break;
						case 6:
							Console.WriteLine("Height (cm) | {0}", H2.height);
							break;
						case 7:
							Console.WriteLine("Location    | {0}", H2.location);
							break;
					}
					Console.ForegroundColor = ConsoleColor.White;
				}
				char tempChar = Console.ReadKey(true).KeyChar;
				// 判断按下的按键 执行对应操作
				switch (tempChar)
				{
					case 'w':
						if (tempSelection <= 0)
						{
							tempSelection = 0;
							break;
						}
						tempSelection -= 1;
						break;
					case 's':
						if (tempSelection >= 7)
						{
							tempSelection = 7;
							break;
						}
						tempSelection += 1;
						break;
					case 'x':
						isLoopMain = false;
						break;
					case 'e':
						FunctionP1ChangeValue(tempSelection, ref H1, ref H2);
						break;
				}
			} while (isLoopMain);
			// 程序结束输出提示 |
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine();
			Console.WriteLine("This subtopic has ended, press any key to switch to the next subtopic.");
			Console.ReadKey(true);
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			#endregion

			DrawProgramEndScreen();
		}
	}
}
