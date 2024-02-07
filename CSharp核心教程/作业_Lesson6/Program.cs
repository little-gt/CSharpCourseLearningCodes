using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson6
{
	class StuScore
	{
		private int stuCode;
		private int[] examScore;
		private int[] examDate;
		private string[] examName;

		#region 构造 | 要求一定要绑定一个学生ID，以用于验证身份
		/// <summary>
		/// 构造 | 要求必须绑定学生ID，且只能在创建以后写入学生成绩
		/// </summary>
		/// <param name="stuCode">学生ID</param>
		public StuScore(int stuCode)
		{
			this.stuCode = stuCode;
		}
		#endregion

		#region 索引 | 考试名称
		/// <summary>
		/// 索引 | 考试名称查询与写入，返回与赋值均为string类型
		/// </summary>
		/// <param name="examID">考试次数(即Debug中的考试ID)</param>
		/// <returns></returns>
		public string this[int examID]
		{
			get
			{
				if (examName == null)
				{
					System.Diagnostics.Debug.WriteLine("× 学生 {0} 尚未记录任何考试名称的数据，请检查.", stuCode);
					return null;
				}
				if (examID > examName.Length || examID < 1)
				{
					System.Diagnostics.Debug.WriteLine("× 学生 {0} 的考试成绩记录次数为 {1} 次，查询的ID不合法.", stuCode, examScore.Length);
					return null;
				}
				return examName[examID - 1];
			}
			set
			{
				// 错误捕捉 | 考试ID不符合要求
				if (examID < 1)
				{
					System.Diagnostics.Debug.WriteLine("× 学生 {0} ,的考试记录添加失败，因为考试ID不能小于1.", stuCode, value);
					return;
				}
				// 初次创建 | 新建数组，并且写入初次考试的名称，默认创建一个长度为10的数组，留空为10方便下一次写入
				if (examName == null)
				{
					examName = new string[10];
					examName[0] = value;
					System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试名称记录，考试ID为 {1} ，名称为 {2} .", stuCode, examID, value);
					return;
				}
				// 余量不足 | 要写入的次数大于空余次数，进行扩容并且搬迁数据
				if (examID > examName.Length)
				{
					string[] tempName = new string[examID + 9];
					for (int i = 0; i < examName.Length; i++)
					{
						tempName[i] = examName[i];
					}
					tempName[examID - 1] = value;
					examName = tempName;
					System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试名称记录，考试ID为 {1} ，名称为 {2} .", stuCode, examID, value);
					GC.Collect();
					return;
				}
				// 正常写入 | 写入到指定的位置
				examName[examID - 1] = value;
				System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试名称记录，考试ID为 {1} ，名称为 {2} .", stuCode, examID, value);
				return;
			}
		}
		#endregion

		#region 索引 | 综合查询与赋值
		/// <summary>
		/// 索引 | 综合查询与赋值，可查询"考试分数"或"考试时间"，并且返回int参数
		/// </summary>
		/// <param name="searchType">查询目标(s -> 分数；d -> 时间)</param>
		/// <param name="examID">考试次数(即Debug中的考试ID)</param>
		/// <returns></returns>
		public int this[char searchType, int examID]
		{
			get
			{
				switch (searchType)
				{
					// 查询 考试分数
					case 's':
						// 错误捕捉 | 检查是否创建了考试分数数据，查询是否超出范围
						if (examScore == null)
						{
							System.Diagnostics.Debug.WriteLine("× 学生 {0} 尚未记录任何考试分数的数据，请检查.", stuCode);
							return -1;
						}
						if (examID > examScore.Length || examID < 1)
						{
							System.Diagnostics.Debug.WriteLine("× 学生 {0} 的考试成绩记录次数为 {1} 次，查询的ID不合法.", stuCode, examScore.Length);
							return -1;
						}
						// 分数查询 | 返回要查询的分数
						return examScore[examID - 1];

					// --------------------------------------------------------------------- //

					// 查询 考试时间
					case 'd':
						// 错误捕捉 | 检查是否创建了考试时间数据，查询是否超出范围
						if (examDate == null)
						{
							System.Diagnostics.Debug.WriteLine("× 学生 {0} 尚未记录任何考试时间的数据，请检查.", stuCode);
							return -1;
						}
						if (examID > examDate.Length || examID < 1)
						{
							System.Diagnostics.Debug.WriteLine("× 学生 {0} 的考试时间记录次数为 {1} 次，查询的ID不合法.", stuCode, examDate.Length);
							return -1;
						}
						// 分数查询 | 返回要查询的时间
						return examDate[examID - 1];
				}
				// 错误返回 | 传入的参数不正确
				System.Diagnostics.Debug.WriteLine("× 参数 {0} 未被定义，其中 s -> 考试分数，d -> 考试时间", searchType);
				return -1;
			}

			set
			{
				switch (searchType)
				{
					// 操作 | 写入 分数 数据
					case 's':
						// 错误捕捉 | 考试ID不符合要求
						if (examID < 1)
						{
							System.Diagnostics.Debug.WriteLine("× 学生 {0} ,的考试记录添加失败，因为考试ID不能小于1.", stuCode, value);
							return;
						}
						// 初次创建 | 新建数组，并且写入初次考试的成绩，默认创建一个长度为10的数组，留空为10方便下一次写入
						if (examScore == null)
						{
							examScore = new int[10];
							examScore[0] = value;
							System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试成绩记录，考试ID为 {1} ，成绩为 {2} .", stuCode, examID, value);
							return;
						}
						// 余量不足 | 要写入的次数大于空余次数，进行扩容并且搬迁数据
						if (examID > examScore.Length)
						{
							int[] tempScore = new int[examID + 9];
							for (int i = 0; i < examScore.Length; i++)
							{
								tempScore[i] = examScore[i];
							}
							tempScore[examID - 1] = value;
							examScore = tempScore;
							System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试成绩记录，考试ID为 {1} ，成绩为 {2} .", stuCode, examID, value);
							GC.Collect();
							return;
						}
						// 正常写入 | 写入到指定的位置
						examScore[examID - 1] = value;
						System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试成绩记录，考试ID为 {1} ，成绩为 {2} .", stuCode, examID, value);
						return;

					// --------------------------------------------------------------------- //

					// 操作 | 写入 时间 数据
					case 'd':
						// 错误捕捉 | 考试ID不符合要求
						if (examID < 1)
						{
							System.Diagnostics.Debug.WriteLine("× 学生 {0} ,的考试记录添加失败，因为考试ID不能小于1.", stuCode, value);
							return;
						}
						// 初次创建 | 新建数组，并且写入初次考试的时间，默认创建一个长度为10的数组，留空为10方便下一次写入
						if (examDate == null)
						{
							examDate = new int[10];
							examDate[0] = value;
							System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试时间记录，考试ID为 {1} ，时间为 {2} .", stuCode, examID, value);
							return;
						}
						// 余量不足 | 要写入的次数大于空余次数，进行扩容并且搬迁数据
						if (examID > examDate.Length)
						{
							int[] tempDate = new int[examID + 9];
							for (int i = 0; i < examDate.Length; i++)
							{
								tempDate[i] = examDate[i];
							}
							tempDate[examID - 1] = value;
							examDate = tempDate;
							System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试时间记录，考试ID为 {1} ，时间为 {2} .", stuCode, examID, value);
							GC.Collect();
							return;
						}
						// 正常写入 | 写入到指定的位置
						examDate[examID - 1] = value;
						System.Diagnostics.Debug.WriteLine("> 学生 {0} ，新增一条考试时间记录，考试ID为 {1} ，时间为 {2} .", stuCode, examID, value);
						return;
				}
				// 错误返回 | 传入的参数不正确
				System.Diagnostics.Debug.WriteLine("× 参数 {0} 未被定义，其中 s -> 考试分数，d -> 考试时间", searchType);
				return;
			}
		}
		#endregion

		#region 方法 | 验证学生ID是否匹配
		/// <summary>
		/// 函数 | 校验学生ID是否匹配，并且返回结果
		/// </summary>
		/// <param name="stuID">学生ID</param>
		/// <returns></returns>
		public bool FunctionCheckStu(int stuID)
		{
			if (stuID == stuCode)
			{
				return true;
			}
			return false;
		}
		#endregion

		#region 方法 | 删除学生成绩记录

		#endregion
	}

	class Program
	{

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
			Console.WriteLine("自定义一个自行数组类，该类中有一个整形数组变量，为他封装一个直接增加和删除的方法");
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
			DrawProgramEndScreen();
		}
	}
}
