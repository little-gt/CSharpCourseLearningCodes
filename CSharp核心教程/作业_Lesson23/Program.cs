using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 载入 | 载入作业程序 固定UI 页面绘制
using ConsoleDraw;

namespace ConsoleDraw
{
	static public class Draw
	{
		/// <summary>
		/// 绘制 | 全局界面
		/// </summary>
		public static class Globe
		{
			#region 界面 | 程序开始页面绘制
			/// <summary>
			/// 绘制 | 作业程序开始界面绘制
			/// </summary>
			/// <param name="number">课程编号</param>
			/// <param name="context">课程名称</param>
			static public void OpenPage(int number, string context)
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
				Console.WriteLine("Lesson {0} | {1}", number, context);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("□ Press Any Key To Start Running");
				Console.ReadKey(true);
				Console.Clear();
			}
			#endregion

			#region 界面 | 作业结束页面绘制
			/// <summary>
			/// 绘制 | 作业程序结束界面绘制
			/// </summary>
			static public void EndsPage()
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
		}

		/// <summary>
		/// 问题界面绘制
		/// </summary>
		public static class Question
		{
			#region 题目 | 题目介绍绘制
			/// <summary>
			/// 绘制 | 题目介绍页面绘制
			/// </summary>
			/// <param name="number">题目序号</param>
			/// <param name="context">题目介绍</param>
			static public void Introduction(int number, string context)
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();

				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("■ 第 {0} 题 |", number);

				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine(context);

				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("————————————————————");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("Please press any key to enter the procedure for this question ...");
				Console.ReadKey(true);

				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
			}
			#endregion

			#region 题目 | 题目菜单绘制
			/// <summary>
			/// 功能 | 绘制题目菜单页面并且返回用户选中的选项索引
			/// </summary>
			/// <param name="itemTitle">菜单题目</param>
			/// <param name="itemMenu">菜单选项</param>
			/// <returns>选中的菜单序号(如果运行异常，返回-1)</returns>
			static public int DetailedMenu(string itemTitle, string[] itemMenu)
			{
				// 初始化题目菜单绘制的参数
				bool isLoop = true;
				int selectedOption = 0;
				char selKey = '0';
				// 初始化题目菜单背景的参数
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
				while (isLoop)
				{
					// 绘制 界面标题
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("■ " + itemTitle + " |");

					// 绘制 菜单操作提示
					Console.WriteLine("■ Menu Operation Tips:");
					Console.WriteLine("Press [w] or [s] up and down to select options, press [e] to confirm options.");

					// 绘制 菜单选项
					Console.WriteLine("————————————————————");
					for (int i = 0; i < itemMenu.Length; i++)
					{
						if (i == selectedOption)
						{
							Console.ForegroundColor = ConsoleColor.DarkYellow;
							Console.Write("> ");
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine(itemMenu[i]);
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.White;
							Console.WriteLine("  " + itemMenu[i]);
						}
					}
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("————————————————————");
					if (selectedOption == itemMenu.Length)
					{
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.Write("> ");
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Exit the UI menu of this programming exercise program.");
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine("  Exit the UI menu of this programming exercise program.");
					}
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("————————————————————");

					// 操作 读取用户所按下的按键
					// 防止因为按下不合法的按键导致闪屏，影响用户体验
					while (true)
					{
						selKey = Console.ReadKey(true).KeyChar;
						if (selKey == 'w' || selKey == 's' || selKey == 'e')
						{
							break;
						}
						if (selKey == 'W' || selKey == 'S' || selKey == 'E')
						{
							break;
						}
					}

					// 逻辑 根据用户所按下的按键做出判断
					switch (selKey)
					{
						case 'W':
						case 'w':
							// 向上选择 ( 选中的序号减少 )
							if (selectedOption <= 0)
							{
								selectedOption = 0;
								break;
							}
							else
							{
								selectedOption -= 1;
								break;
							}
						case 'S':
						case 's':
							// 向下选择 ( 选中的序号增加 )
							if (selectedOption >= itemMenu.Length)
							{
								selectedOption = itemMenu.Length;
								break;
							}
							else
							{
								selectedOption += 1;
								break;
							}
						case 'E':
						case 'e':
							return selectedOption;
						default:
							break;
					}
					Console.Clear();
				}
				return -1;
			}
			#endregion
		}

		/// <summary>
		/// 答案页面界面绘制 ( 简答题 )
		/// </summary>
		public static partial class AnswerPage
		{
			/// <summary>
			/// 绘制简答题答案显示页面
			/// </summary>
			/// <param name="itemQuestion">简答题问题</param>
			/// <param name="itemAnswer">简答题答案</param>
			public static void ShortAnswerQuestion(string itemQuestion, string itemAnswer)
			{
				int tempConsHeight = Console.WindowHeight;
				int tempConsWidths = Console.WindowWidth;
				int tempCursTop;

			    // 初始化控制台界面设置
				Console.BackgroundColor = ConsoleColor.Black; 
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();

				// 问题
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(">>> Question ---------------");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine(itemQuestion);

				// 答案
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(">>> Answer   ---------------");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine(itemAnswer);

				// 控制台
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(">>> Consoles ---------------");
				tempCursTop = Console.CursorTop;
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.Write("Press [x] to Close This Page.");
				while (true)
				{
					if (Console.ReadKey(true).KeyChar == 'x')
					{
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.White;
						Console.Clear();
						return;
					}
					Console.WindowHeight = tempConsHeight;
					Console.WindowWidth = tempConsWidths;
					Console.CursorTop = tempCursTop;
					Console.CursorLeft = 0;
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.Write("Press [x] to Close This Page.");
				}

			}
		}
	}
}

namespace 作业_Lesson23
{
	class Exercise2
	{
		public string strPrepare;
		public string strResults;
		public char chaDelimiter;
		public string[] strsTemp;
		public Random random = new Random();

		public Exercise2(char delimiter)
		{
			chaDelimiter = delimiter;
		}

		/// <summary>
		/// 演示程序 自动生成要求长度的字符串，进行处理
		/// </summary>
		/// <param name="length">字符串数组长度</param>
		/// <returns></returns>
		public string DemoProgram(int length)
		{
			// 防止不合法的长度输入导致错误发生
			if (length <= 0)
			{
				return "ERROR : The length of the array you have entered is not legal, please re-enter it.";
			}

			// 利用随机数生成一个string字符串
			for (int i = 0; i < length; i++)
			{
				strPrepare += random.Next(0, 99);
				if (i < length - 1)
				{
					strPrepare += chaDelimiter;
				}
				GC.Collect();
			}

			// 字符串进行拆解
			strsTemp = strPrepare.Split(chaDelimiter);

			// 进行字符串数组的倒序排序
			for (int i = 0; i < strsTemp.Length; i++)
			{
				strResults += strsTemp[strsTemp.Length - 1 - i];
				if (i < length - 1)
				{
					strResults += chaDelimiter;
				}
				GC.Collect();
			}

			GC.Collect();

			return strResults;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			#region 参数 | 全局参数定义
			// 菜单页面的循环
			bool isLoop = true;
			// 用户选中的选项
			int selectOption;
			// 控制台光标位置
			int tempCurTop;
			int tempCurLef;

			// 第一题的题目菜单
			string[] menuQuestion1 = new string[] { "string的截取方法", "string的替换方法" };
			// 第二题的题目菜单
			string[] menuQuestion2 = new string[] { "运行以随机数生成数组的演示程序" };
			// 第三题的题目菜单
			string[] menuQuestion3 = new string[] { "总览性回答", "String和string", "Int32和int", "Int16和short", "Int64和long" };
			#endregion

			// 绘制 | 作业开始页面
			
			Draw.Globe.OpenPage(23, "methods in string");

			#region 习题 1 | 请写出 string 中提供的截取和替换对应的函数名
			isLoop = true;
			Draw.Question.Introduction(1, "请写出 string 中提供的截取和替换对应的函数名");
			do
			{
				selectOption = Draw.Question.DetailedMenu("概念解析查询", menuQuestion1);
				if (selectOption == 0)
				{
					Draw.AnswerPage.ShortAnswerQuestion("string的截取方法是什么？", ">>> 截取从指定位置开始之后的 所有的字符 使用 .Substring(index);\n>>> 如果要截取指定位置之后的 有限个字符 使用 .Substring(index, length),\n    index  - 开始位置\n    length - 指定位置\n    值得注意的是，.Substring(index, length)不会判断 length 是否越界，所以需要自己手动判断");
				}
				if (selectOption == 1)
				{
					Draw.AnswerPage.ShortAnswerQuestion("string的替换方法是什么？", ">>> 如果需要替换字符串当中的 所有指定内容 可以使用.Replace(\"要指定的字符串\", \"替换成的字符串\");\n    替换以后，所有符合的指定内容都会被替换");
				}
				if( selectOption == 2)
				{
					isLoop = false;
				}
			} while (isLoop);
			#endregion

			#region 习题 2 | 使用字符串切割的方法
			Draw.Question.Introduction(2, "使用字符串切割的方法：\n例如，将字符串 1|2|3|4|5|6|7 变为 2|3|4|5|6|7|8 并输出。");
			isLoop = true;
			do
			{
				selectOption = Draw.Question.DetailedMenu("字符串分割和拼接练习", menuQuestion2);
				if (selectOption == 0)
				{
					char charE2Key;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();

					// 要求用户自定义一个分隔符
					do
					{
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write("自定义一个分隔符");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine(" => 自定义数组的长度 => 生成字符串数组 => 输出要求的字符串");
						Console.WriteLine("————————————————————");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("请您输入一个符号作为分隔符，同时，这个分隔符不能是数字: ");
						tempCurTop = Console.CursorTop;
						tempCurLef = Console.CursorLeft;
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("\n————————————————————");
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("String Manipulation Demo Program");
						Console.CursorTop = tempCurTop;
						Console.CursorLeft = tempCurLef;
						Console.ForegroundColor = ConsoleColor.White;
						charE2Key = Console.ReadKey().KeyChar;
						#region 检查分隔符是否是数字
						bool isNumber = false;
						if (charE2Key == '0')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 0 is not a legal separator because 0 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '1')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 1 is not a legal separator because 1 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '2')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 2 is not a legal separator because 2 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '3')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 3 is not a legal separator because 3 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '4')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 4 is not a legal separator because 4 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '5')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 5 is not a legal separator because 5 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '6')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 6 is not a legal separator because 6 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '7')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 7 is not a legal separator because 7 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '8')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 8 is not a legal separator because 8 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (charE2Key == '9')
						{
							isNumber = true;
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | 9 is not a legal separator because 9 is a number, and numbers will exist as meaningful elements in a string.");
						}
						if (!isNumber)
						{
							break;
						}
						#endregion
					} while (true);

					// 创建 Exercise2 的对象
					Exercise2 exercise2 = new Exercise2(charE2Key);
					int intE2Length;
					Console.Clear();

					// 获取数组的长度
					do
					{
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("自定义一个分隔符 => ");
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write("自定义数组的长度");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine(" => 生成字符串数组 => 输出要求的字符串");
						Console.WriteLine("————————————————————");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("请您输入一个字符串数组的长度，也就是所含元素的数量： ");
						tempCurTop = Console.CursorTop;
						tempCurLef = Console.CursorLeft;
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("\n————————————————————");
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("String Manipulation Demo Program");
						Console.CursorTop = tempCurTop;
						Console.CursorLeft = tempCurLef;
						Console.ForegroundColor = ConsoleColor.White;
						try
						{
							intE2Length = Convert.ToInt32(Console.ReadLine());
							if(intE2Length > 0)
							{
								Console.Clear();
								break;
							}
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | The length of the array should be a positive integer, not a decimal or an integer less than or equal to zero.");
						}
						catch (Exception)
						{
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("× ERROR | The length of the array should be a positive integer and not some other character.");
						}
					} while (true);

					bool isLoopStep3 = true;
					Console.Clear();
					do
					{
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("自定义一个分隔符 => 自定义数组的长度  => ");
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write("生成字符串数组");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine(" => 输出要求的字符串");
						Console.WriteLine("————————————————————");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("正在处理您的请求，这应该不会花费太长时间... ...");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("The array is being generated, please be patient, this shouldn't take too long. If you set a length that is too long, the process may last several minutes.");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("\n————————————————————");
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("String Manipulation Demo Program");

						exercise2.DemoProgram(intE2Length);

						Console.Clear();
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("自定义一个分隔符 => 自定义数组的长度  => ");
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write("生成字符串数组");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine(" => 输出要求的字符串");
						Console.WriteLine("————————————————————");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("生成的随机数组如下，如果你不满意可以按下[r]重新生成，如果要进行下一步可以按下[e].");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write(exercise2.strPrepare);
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("\n————————————————————");
						Console.ForegroundColor = ConsoleColor.DarkGray;
						if (intE2Length >= 1500)
						{
							Console.WriteLine("The length you entered seems a bit too long, drag the slider to the top to preview the array, or press [e] if you don't want to do that.");
						}
						Console.WriteLine("String Manipulation Demo Program");

						while (true)
						{
							char tempPress = Console.ReadKey(true).KeyChar;
							if (tempPress == 'e')
							{
								isLoopStep3 = false;
								break;
							}
							if (tempPress == 'r')
							{
								exercise2.strPrepare = "";
								exercise2.strResults = "";
								exercise2.strsTemp = null;
								GC.Collect();
								Console.Clear();
								break;
							}
						}
					} while (isLoopStep3);

					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("自定义一个分隔符 => 自定义数组的长度  => 生成字符串数组 => ");
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("输出要求的字符串");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("————————————————————");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("随机生成的字符串如下：");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(exercise2.strPrepare);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("\n排序以后的字符串如下：");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(exercise2.strResults);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("\n请按下[e]确认，之后就会结束此预览程序，如果你输入的长度太长，可能导致异常，这时建议你重新启动本作业程序。");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("\n————————————————————");
					Console.ForegroundColor = ConsoleColor.DarkGray;
					if (intE2Length >= 500)
					{
						Console.WriteLine("Please press [e] to confirm, after that it will end this preview programme. The length of your input is too long, it may cause an exception, then we suggest you to restart this job programme.");
					}
					Console.WriteLine("String Manipulation Demo Program");

					while (true)
					{
						if(Console.ReadKey(true).KeyChar == 'e' || Console.ReadKey(true).KeyChar == 'E')
						{
							exercise2.strPrepare = null;
							exercise2.strResults = null;
							exercise2.strsTemp = null;
							exercise2.chaDelimiter = '0';
							exercise2.random = null;
							GC.Collect();
							break;
						}
					}
				}
				if (selectOption == 1)
				{
					isLoop = false;
					break;
				}
			} while (isLoop);
			#endregion

			#region 知识点 3 | String和string、Int32和int、Int16和short、Int64和long他们的区别是什么？
			Draw.Question.Introduction(3, "String和string、Int32和int、Int16和short、Int64和long他们的区别是什么？");
			isLoop = true;
			do
			{
				selectOption = Draw.Question.DetailedMenu("资料库 - String和string、Int32和int、Int16和short、Int64和long他们的区别是什么？", menuQuestion3);
				if (selectOption == 0)
				{
					Draw.AnswerPage.ShortAnswerQuestion("总览性回答：\nString和string、Int32和int、Int16和short、Int64和long他们的区别是什么？", "在 C# 中，String 和 string、Int32 和 int、Int16 和 short、Int64 和 long 实际上并没有区别。这些是 C# 中的类型关键字的不同表示方式，它们是等价的.\n■ String 和 string：\n在 C# 中，string 是引用类型，用于表示文本字符串。实际上，string 是 System.String 类型的别名，两者完全相同，在代码中可以互换使用。\n■ Int32 和 int：\n○ Int32 是 .NET Framework 类库中的命名空间 System 下的一个整数类型。\n○ int 是 C# 语言中对 32 位有符号整数类型的简写或关键字别名，它等同于 System.Int32。\n○ 所以 int 就是 Int32 的简化形式，它们占用 4 个字节的存储空间，取值范围从 -2,147,483,648 到 2,147,483,647。\n■ Int16 和 short：\n○ Int16 是 .NET Framework 中定义的 16 位有符号整数类型。\n○ short 是 C# 中对应 Int16 的关键字别名，占用 2 个字节的存储空间，取值范围从 -32,768 到 32,767。\n■ Int64 和 long：\n○ Int64 是 .NET Framework 中的 64 位有符号整数类型。\n○ long 是 C# 中对 Int64 的关键字别名，占用 8 个字节的存储空间，取值范围从 -9,223,372,036,854,775,808 到 9,223,372,036,854,775,807。\n总结来说，在编写 C# 代码时，你可以根据个人喜好和可读性选择使用全名（如 Int32）或关键字别名（如 int），但功能和行为是相同的。");
				}
				if (selectOption == 1)
				{
					Draw.AnswerPage.ShortAnswerQuestion("String和string的区别是什么？", "String 和 string：\n在 C# 中，string 是引用类型，用于表示文本字符串。实际上，string 是 System.String 类型的别名，两者完全相同，在代码中可以互换使用。");
				}
				if (selectOption == 2)
				{
					Draw.AnswerPage.ShortAnswerQuestion("Int32和int的区别是什么？", "Int32 和 int：\n○ Int32 是 .NET Framework 类库中的命名空间 System 下的一个整数类型。\n○ int 是 C# 语言中对 32 位有符号整数类型的简写或关键字别名，它等同于 System.Int32。\n○ 所以 int 就是 Int32 的简化形式，它们占用 4 个字节的存储空间，取值范围从 -2,147,483,648 到 2,147,483,647。");
				}
				if (selectOption == 3)
				{
					Draw.AnswerPage.ShortAnswerQuestion("Int16和short的区别是什么？", "Int16 和 short：\n○ Int16 是 .NET Framework 中定义的 16 位有符号整数类型。\n○ short 是 C# 中对应 Int16 的关键字别名，占用 2 个字节的存储空间，取值范围从 -32,768 到 32,767。");
				}
				if (selectOption == 4)
				{
					Draw.AnswerPage.ShortAnswerQuestion("Int64和long的区别是什么？", "Int64 和 long：\n○ Int64 是 .NET Framework 中的 64 位有符号整数类型。\n○ long 是 C# 中对 Int64 的关键字别名，占用 8 个字节的存储空间，取值范围从 -9,223,372,036,854,775,808 到 9,223,372,036,854,775,807。");
				}
				if (selectOption == 5)
				{
					isLoop = false;
					break;
				}
			} while (isLoop);
			#endregion

			Draw.Globe.EndsPage();
		}
	}
}
