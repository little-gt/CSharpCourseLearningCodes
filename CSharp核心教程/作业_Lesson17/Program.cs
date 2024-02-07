using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson17
{
	#region 类 | 鸭子类
	class Duck
	{
		public string type;
		public string hoot;

		/// <summary>
		/// DUCK的构造函数
		/// </summary>
		/// <param name="type">鸭子类型</param>
		/// <param name="hoot">鸭子叫声</param>
		public Duck(string type, string hoot)
		{
			this.type = type;
			this.hoot = hoot;
		}

		/// <summary>
		/// 虚拟函数 | 鸭子叫
		/// </summary>
		public virtual void Crow()
		{
			Console.WriteLine("DUCK CROWING HAHAHA ... ...");
		}
	}
	// 真鸭子类
	class DuckReal : Duck
	{
		public DuckReal(string hook) : base("真的鸭子", hook) { }

		public override void Crow()
		{
			// base.Crow();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(type + ": ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(hoot);
		}
	}
	// 木头鸭子类
	class DuckWood : Duck
	{
		public DuckWood(string hook) : base("木头鸭子", hook) { }

		public override void Crow()
		{
			// base.Crow();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(type + ": ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(hoot);
		}
	}
	// 橡皮鸭子类
	class DuckRubber : Duck
	{
		public DuckRubber(string hook) : base("橡皮鸭子", hook) { }

		public override void Crow()
		{
			// base.Crow();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(type + ": ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(hoot);
		}
	}
	#endregion

	#region 类 | 打卡程序类
	public enum E_WorkerType
	{
		NormalWorker,
		Manger,
		Programmer
	}

	public class Company
	{
		public string cname;
		public int idcode;

		public Company(string cname,int idcode)
		{
			this.cname = cname;
			this.idcode = idcode;
		}

		/// <summary>
		/// 系统核心签到逻辑
		/// </summary>
		/// <param name="e_Worker">员工类型</param>
		/// <param name="time">签到时间</param>
		/// <returns></returns>
		public virtual bool CheckIn(E_WorkerType e_Worker,int[] time)
		{
			switch (e_Worker)
			{
				case E_WorkerType.NormalWorker:
					// 普通员工的打卡逻辑
					if (time[0] == 9)
					{
						if (time[1] >= 0 || time[1] <= 20)
						{
							return true;
						}
					}
					return false;
				case E_WorkerType.Manger:
					// 经理的打卡逻辑
					if (time[0] == 11)
					{
						if (time[1] >= 0 || time[1] <= 30)
						{
							return true;
						}
					}
					return false;
				case E_WorkerType.Programmer:
					// 程序员的打卡逻辑
					return false;
				default:
					return false;
			}
		}
	}
	// 类 | 普通员工
	class CompanyWorkers : Company
	{
		string name;
		int timesCheckIn;
		E_WorkerType workerType;
		
		public CompanyWorkers(string name, string cname, int idcode) : base(cname, idcode) 
		{
			this.name = name;
			workerType = E_WorkerType.NormalWorker;
		}

		/// <summary>
		/// 普通员工打卡
		/// </summary>
		/// <param name="e_Worker"></param>
		/// <param name="time"></param>
		/// <returns></returns>
		public override bool CheckIn(E_WorkerType e_Worker, int[] time)
		{
			bool isCheckIn = base.CheckIn(workerType, time);
			if (isCheckIn)
			{
				timesCheckIn += 1;
			}
			return isCheckIn;
		}
	}
	// 类 | 经理
	class CompanyManger : Company
	{
		string name;
		int timesCheckIn;
		E_WorkerType workerType;

		public CompanyManger(string name, string cname, int idcode) : base(cname, idcode)
		{
			this.name = name;
			workerType = E_WorkerType.Manger;
		}

		/// <summary>
		/// 经理打卡
		/// </summary>
		/// <param name="e_Worker"></param>
		/// <param name="time"></param>
		/// <returns></returns>
		public override bool CheckIn(E_WorkerType e_Worker, int[] time)
		{
			bool isCheckIn = base.CheckIn(workerType, time);
			if (isCheckIn)
			{
				timesCheckIn += 1;
			}
			return isCheckIn;
		}
	}
	// 类 | 程序员
	class CompanyProgrammer : Company
	{
		string name;
		int timesCheckIn;
		E_WorkerType workerType;

		public CompanyProgrammer(string name, string cname, int idcode) : base(cname, idcode)
		{
			this.name = name;
			workerType = E_WorkerType.Programmer;
		}

		/// <summary>
		/// 程序员打卡
		/// </summary>
		/// <param name="e_Worker"></param>
		/// <param name="time"></param>
		/// <returns></returns>
		public override bool CheckIn(E_WorkerType e_Worker, int[] time)
		{
			return false;
		}
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
			Console.WriteLine("Lesson 17 | VOB parent and child classes");
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

		static void Main(string[] args)
		{
			DrawProgramOpeningScreen();
			#region 习题 1 |
			// 标题的部分程序
			Console.WriteLine("□ 习题 1 |");
			Console.WriteLine("真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫");
			Console.WriteLine("=======================");
			// 鸭子叫部分程序
			Duck duckReal = new DuckReal("嘎嘎嘎");
			Duck duckWood = new DuckWood("吱吱吱");
			Duck duckRubber = new DuckRubber("唧唧唧");
			object[] ducks = new object[] { duckReal, duckWood, duckRubber };
			for (int i = 0; i < ducks.Length; i++)
			{
				if (ducks[i] is DuckReal)
				{
					(ducks[i] as DuckReal).Crow();
				}
				if (ducks[i] is DuckRubber)
				{
					(ducks[i] as DuckRubber).Crow();
				}
				if (ducks[i] is DuckWood)
				{
					(ducks[i] as DuckWood).Crow();
				}
			}
			// 程序结束，询问是否加入到下一题
			Console.WriteLine("=======================");
			Console.WriteLine("○ Now that the code for this problem has been run, press any key to continue running the program.");
			Console.ReadKey(true);
			Console.Clear();
			#endregion

			#region 习题 2 |

			// 标题的部分程序
			Console.WriteLine("□ 习题 2 |");
			Console.WriteLine("所有员工9点打卡，但经理11点打卡，程序员不打卡。");
			Console.WriteLine("=======================");
			// 程序代码
			Company cworkers = new CompanyWorkers("工人", "公司", 1);
			Company cmanger = new CompanyManger("经理", "公司", 2);
			Company cprogrammer = new CompanyProgrammer("程序员", "公司", 3);
			int[] time = new int[2] { 9, 10 };
			(cworkers as CompanyWorkers).CheckIn(E_WorkerType.NormalWorker, time);
			time[0] = 11;
			(cmanger as CompanyManger).CheckIn(E_WorkerType.Manger, time);
			// 程序结束，询问是否加入到下一题
			Console.WriteLine("=======================");
			Console.WriteLine("○ Now that the code for this problem has been run, press any key to continue running the program.");
			Console.ReadKey(true);
			Console.Clear();
			#endregion

			DrawProgramEndScreen();
		}
	}
}
