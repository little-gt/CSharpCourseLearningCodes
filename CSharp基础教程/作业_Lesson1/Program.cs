using System;

namespace 作业_Lesson1
{
	#region 用户在线状态信息初始化
	enum E_UserOnlineState
	{
		Normal = 0,
		Qme,
		Leaving,
		Busy,
		NoDisturb,
		HideMe,
		Offline,
	}
	#endregion

	#region 咖啡类型代码初始化
	enum E_StarbucksType
	{
		Middle = 0,
		Big,
		SuperBig,
	}
	#endregion

	#region 咖啡价格表目初始化
	enum E_StarbucksPrice
	{
		Middle = 35,
		Big = 40,
		SuperBig = 43,
	}
	#endregion

	#region 玩家信息初始化
	enum E_PlayerSex
	{
		Male,
		Famle,
	}
	enum E_PlayerCareer
	{
		Soldier,
		Hunter,
		Mage,

	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 初始化变量
			bool isRun;
			string userState = "在线";
			string coffeeType = "中杯";
			string userName, userPass;
			int positionCursorTop;
			int positionCursorLeft;

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Clear();

			Console.WriteLine("■ Press any key to execute the program for 'Homework 1'.");
			Console.ReadKey(true);
			Console.Clear();
			isRun = true;
			#region 作业 1 | QQ状态设置
			Console.WriteLine("□ 请设置一个用户名：");
			userName = Console.ReadLine();
			Console.Clear();
			Console.CursorVisible = false;

			E_UserOnlineState userStateCode = E_UserOnlineState.Normal;
			do
			{
				int chooseT = (int)userStateCode;
				switch (userStateCode)
				{
					case E_UserOnlineState.Normal:
						userState = "正常";
						break;
					case E_UserOnlineState.Qme:
						userState = "Q我吧";
						break;
					case E_UserOnlineState.Leaving:
						userState = "离开";
						break;
					case E_UserOnlineState.Busy:
						userState = "忙碌";
						break;
					case E_UserOnlineState.NoDisturb:
						userState = "勿扰";
						break;
					case E_UserOnlineState.HideMe:
						userState = "隐身";
						break;
					case E_UserOnlineState.Offline:
						userState = "离线[按下'e'切换到下一个作业的程序]";
						break;
					default:
						break;
				}
				Console.WriteLine("○ 用户：" + userName + " 在线状态：" + userState);
				for (int i = 0; i < 7; i++)
				{
					if (i == (int)userStateCode)
					{
						Console.Write("■");
					}
					else
					{
						Console.Write("□");
					}
				}
				Console.WriteLine();
				Console.WriteLine("○ 作业编号：1 | 按下'a'或'd'对在线状态进行切换");
				Console.CursorLeft = 0;
				char pressChar = Console.ReadKey(true).KeyChar;
				switch (pressChar)
				{
					case 'a':
					case 'A':
						chooseT = chooseT - 1;
						if (chooseT < 0)
						{
							chooseT = 0;
						}
						break;
					case 'd':
					case 'D':
						chooseT = chooseT + 1;
						if (chooseT >= 6)
						{
							chooseT = 6;
						}
						break;
					case 'e':
					case 'E':
						if (chooseT == 6)
						{
							isRun = false;
						}
						break;
					default:
						break;
				}
				userStateCode = (E_UserOnlineState)chooseT;
				Console.Clear();
			} while (isRun);
			Console.Clear();
			#endregion

			Console.WriteLine("■ Press any key to execute the program for 'Homework 2'.");
			Console.ReadKey(true);
			Console.Clear();
			isRun = true;
			#region 作业 2 | 咖啡订单
			Console.CursorVisible = true;
			Console.WriteLine("○ 欢迎使用咖啡店订单系统，请先登录 ○");
			Console.WriteLine("□ 请输入用户名：");
			userName = Console.ReadLine();
			Console.WriteLine("□ 请输入密码：");
			userPass = Console.ReadLine();
			Console.Clear();
			Console.CursorVisible = false;
			E_StarbucksType coffeeTypeCode = E_StarbucksType.Middle;

			do
			{
				int chooseT = (int)coffeeTypeCode;
				switch (coffeeTypeCode)
				{
					case E_StarbucksType.Middle:
						coffeeType = "中杯";
						break;
					case E_StarbucksType.Big:
						coffeeType = "大杯";
						break;
					case E_StarbucksType.SuperBig:
						coffeeType = "超大杯";
						break;
					default:
						break;
				}
				Console.WriteLine("○ 你好：" + userName + "，\n○ 欢迎使用咖啡店订单系统");
				Console.WriteLine("===== ===== ===== =====");
				Console.WriteLine("○ 您当前选中的规格：" + coffeeType);
				Console.WriteLine("===== ===== ===== =====");
				for (int i = 0; i < 3; i++)
				{
					if (i == chooseT)
					{
						Console.Write("■ ");
					}
					else
					{
						Console.Write("□ ");
					}
					switch (i)
					{
						case 0:
							Console.WriteLine("中杯 | ¥ 35");
							break;
						case 1:
							Console.WriteLine("大杯 | ¥ 40");
							break;
						case 2:
							Console.WriteLine("超大杯 | ¥ 43");
							break;
					}
				}
				Console.WriteLine("===== ===== ===== =====");
				Console.WriteLine("○ 作业编号：2 | 按下'w'或's'按键进行上下选择，按下'e'确认");
				char pressT = Console.ReadKey(true).KeyChar;
				switch (pressT)
				{
					case 'w':
					case 'W':
						chooseT = chooseT - 1;
						if (chooseT < 0)
						{
							chooseT = 0;
						}
						break;
					case 's':
					case 'S':
						chooseT = chooseT + 1;
						if (chooseT > 2)
						{
							chooseT = 2;
						}
						break;
					case 'e':
						isRun = false;
						break;
				}
				coffeeTypeCode = (E_StarbucksType)chooseT;
				Console.Clear();
			} while (isRun);
			switch (coffeeTypeCode)
			{
				case E_StarbucksType.Middle:
					Console.WriteLine("○ 下单成功，你购买了" + coffeeType + "花费了" + (int)E_StarbucksPrice.Middle);
					break;
				case E_StarbucksType.Big:
					Console.WriteLine("○ 下单成功，你购买了" + coffeeType + "花费了" + (int)E_StarbucksPrice.Big);
					break;
				case E_StarbucksType.SuperBig:
					Console.WriteLine("○ 下单成功，你购买了" + coffeeType + "花费了" + (int)E_StarbucksPrice.SuperBig);
					break;
				default:
					break;
			}
			Console.WriteLine("○ 作业编号：2 | 按下'e'结束运行本程序");
			isRun = true;

			while (isRun)
			{
				char pressT = Console.ReadKey(true).KeyChar;
				if (pressT == 'e')
				{
					isRun = false;
				}
			}
			Console.Clear();
			#endregion

			Console.WriteLine("■ Press any key to execute the program for 'Homework 1'.");
			Console.ReadKey(true);
			Console.Clear();
			isRun = true;
			#region 作业 3 | 新建游戏角色
			string playerName;
			int playerMale, playerAttack, playerDefence;

			Console.CursorVisible = true;
			do
			{
				Console.WriteLine("□ 正在新建你的角色，正在进行第1步骤，共需要3步");
				Console.WriteLine("□ 请给你的角色取个名字：");
				playerName = Console.ReadLine();
				Console.Clear();

				Console.WriteLine("□ 正在新建你的角色，正在进行第1步骤，共需要3步");
				Console.WriteLine("□ 确认要叫\"" + playerName + "\"吗？之后的冒险中，这个名字都不可改变啰。");
				Console.WriteLine("===== ===== ===== =====");
				Console.WriteLine("按下'y'确认，按下其他任意键重新设置。");
				Console.WriteLine("===== ===== ===== =====");
				char pressT = Console.ReadKey(true).KeyChar;
				if (pressT == 'y')
				{
					isRun = false;
				}
				Console.Clear();
			} while (isRun);

			#endregion
		}
	}
}
