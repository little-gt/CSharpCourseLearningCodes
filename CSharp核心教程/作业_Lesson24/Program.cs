using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
						if (selKey == 'w' || selKey == 'W')
						{
							if (selectedOption <= 0)
							{
								selectedOption = 0;
							}
							else
							{
								break;
							}
						}
						if (selKey == 's' || selKey == 'S')
						{
							if (selectedOption >= itemMenu.Length)
							{
								selectedOption = itemMenu.Length;
							}
							else
							{
								break;
							}
						}
						if (selKey == 'e' || selKey == 'E')
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
							selectedOption -= 1;
							break;
						case 'S':
						case 's':
							// 向下选择 ( 选中的序号增加 )
							selectedOption += 1;
							break;
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

namespace 作业_Lesson24
{
	class Program
	{
		static void Main(string[] args)
		{
			Draw.Globe.OpenPage(24, "StringBuilder");

			#region 习题 1 | 请描述 String 和 StringBuilder 的区别
			Draw.Question.Introduction(1, "请描述 String 和 StringBuilder 的区别");

			StringBuilder strAnswer = new StringBuilder("在 C# 中，String 和 StringBuilder 类型的主要区别如下：\n");
			strAnswer.Append("1. 可变性（Mutability）\n");
			strAnswer.Append("○ String：C# 中的 System.String 类是不可变的。这意味着一旦创建了一个 String 对象，它的值就不能被改变。每次对字符串进行修改操作时（如拼接、替换字符等），系统都会在内存中创建一个新的 String 对象，原始对象保持不变。\n");
			strAnswer.Append("○ StringBuilder：System.Text.StringBuilder 是一个可变的类，允许在不创建新对象的情况下直接修改内部缓冲区的内容。这意味着它可以高效地进行多次添加或删除操作，而不需要每次都生成新的字符串对象。\n");
			strAnswer.Append("2. 性能和资源消耗\n");
			strAnswer.Append("○ String：由于每次修改都要创建新对象，频繁进行字符串连接操作（尤其是在循环内）会导致大量的内存分配和垃圾回收，从而影响性能。尤其在处理大量数据或者构建长字符串时，性能开销会显著增加。\n");
			strAnswer.Append("○ StringBuilder：它通过维护一个可以动态扩展的内部数组来优化这些操作，避免了重复的对象创建，因此在处理大量字符串操作时效率更高。\n");
			strAnswer.Append("3. 线程安全\n");
			strAnswer.Append("○ String：由于其不可变性质，在多线程环境下，读取同一个 String 对象是安全的，但不会涉及任何修改操作。\n");
			strAnswer.Append("○ StringBuilder：默认情况下，StringBuilder 在多线程环境中不是线程安全的，如果需要多个线程同时访问并修改 StringBuilder 实例，开发者需要自己实现同步机制以确保线程安全。虽然.NET Framework 也有一个名为 System.Text.StringBuilder.Synchronized() 的方法可以返回一个线程安全的包装器，但建议使用 System.Text.StringBuilder 类的线程安全替代品 System.Text.StringBuilder（注意这里应为 System.Threading.ThreadSafeStringWriter 或其他并发容器管理，但在 .NET Framework 中并没有直接提供完全等同于 StringBuffer 的线程安全版本，可能需要手动同步代码块）。\n");
			strAnswer.Append("■ 总结来说，当仅需简单且不频繁的字符串操作时，使用 String 就足够了；而在需要执行大量字符串连接、插入或删除操作，尤其是性能敏感的场合，应当优先考虑使用 StringBuilder。");
			Draw.AnswerPage.ShortAnswerQuestion("请描述 String 和 StringBuilder 的区别？", strAnswer.ToString());
			#endregion

			Draw.Globe.EndsPage();
		}
	}
}

