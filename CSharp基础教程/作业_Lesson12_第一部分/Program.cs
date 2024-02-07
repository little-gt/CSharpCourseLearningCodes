using System;

namespace 作业_Lesson12_第一部分
{
	#region 习题 1 | 学生信息处理
	struct StudentInformation
	{
		// 初始化学院信息储存的容器
		string stuName;
		int stuSex;
		int stuAge;
		int stuClass;
		int stuSpeciality;

		// 构造函数
		public StudentInformation(string stuNane, int stuSex, int stuAge, int stuClass, int stuSpeciality)
		{
			this.stuName = stuNane;
			this.stuSex = stuSex;
			this.stuAge = stuAge;
			this.stuClass = stuClass;
			this.stuSpeciality = stuSpeciality;
		}

		// 获取性别代码对应的性别描述
		public string GetSexString()
		{
			string tempSex;
			switch (stuSex)
			{
				case 0:
					tempSex = "男";
					break;
				case 1:
					tempSex = "女";
					break;
				default:
					tempSex = "保密";
					break;
			}
			return tempSex;
		}

		// 获取对应课程代码对应的课程名
		public string GetSpecialtyString()
		{
			string tempSpecialty;
			switch (stuSpeciality)
			{
				case 0:
					tempSpecialty = "汉语言文学教育";
					break;
				case 1:
					tempSpecialty = "高等数学";
					break;
				case 2:
					tempSpecialty = "材料物理";
					break;
				case 3:
					tempSpecialty = "线性代数";
					break;
				default:
					tempSpecialty = "生物工程";
					break;
			}
			return tempSpecialty;
		}

		public void OUTPUT()
		{
			string tempSex, tempSpecialty;
			tempSex = GetSexString();
			tempSpecialty = GetSpecialtyString();

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("学员基本信息 | ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(stuName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("，性别");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("{0}(代码:{1})", tempSex, stuSex);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("。");
			Console.WriteLine("课业详细信息 | ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("{0}(代码:{1})", tempSpecialty, stuSpeciality);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("，就读于");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("{0}班", stuClass);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("。");
			Console.WriteLine("=====================================");
		}
	}
	#endregion

	#region 习题 2 | 矩形的信息处理
	struct RectangleInformation
	{
		// 初始化矩形的长宽信息
		float rectLength; // 矩形的长
		float rectWidth;  // 矩形的宽

		// 构造函数
		public RectangleInformation(float rectLength, float rectWidth)
		{
			this.rectLength = rectLength;
			this.rectWidth = rectWidth;
		}

		// 计算矩形面积
		public float CalculateArea()
		{
			return rectLength * rectWidth;
		}

		// 计算矩形周长
		public float CalculatePerimeter()
		{
			return (rectLength * 2) + (rectWidth * 2);
		}

		// 返回矩形的长宽
		public float[] ReturnParameter()
		{
			return new float[] { rectLength, rectWidth };
		}
	}
	#endregion

	#region 习题 3 | 玩家信息处理
	struct PlayerInformation
	{
		string playerName;
		int playerCareer;
		int playerSkill;

		public PlayerInformation(string playerName, int playerCareer, int playerSkill)
		{
			this.playerName = playerName;
			this.playerSkill = playerSkill;
			this.playerCareer = playerCareer;
		}

		public string PlayerName()
		{
			return playerName;
		}

		public string CareerName()
		{
			switch (playerCareer)
			{
				case 0:
					return "战士";
				case 1:
					return "猎人";
				case 2:
					return "法师";
				default:
					return "";
			}
		}

		public string SkillName()
		{
			switch (playerSkill)
			{
				case 0:
					return "冲锋";
				case 1:
					return "假死";
				case 2:
					return "奥术冲击";
				default:
					return "普攻";
			}
		}
	}
	#endregion

	class Program
	{

		#region 方法 | 程序title
		static void ProgramTitle(int programNumber)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("======== -| ");
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("习题" + programNumber);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" |- ========");
		}
		#endregion

		#region 方法 | 程序暂停
		static void ProgramPause()
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Write("程序已暂停，请按下任意键继续运行......");
			Console.ReadKey(true);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
		}
		#endregion

		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();

			#region 习题 1
			// 习题 1 开始
			ProgramTitle(1);
			Console.WriteLine("=====================================");
			// 初始化第一位学员的信息
			StudentInformation stu1 = new StudentInformation("小德", 0, 17, 10, 2);
			stu1.OUTPUT();
			// 初始化第二位学员的信息
			StudentInformation stu2 = new StudentInformation("小克", 0, 18, 10, 2);
			stu2.OUTPUT();
			ProgramPause();
			// 习题 1 结束
			#endregion

			#region 习题 2 
			// 习题 2 开始
			bool isRun = true;
			RectangleInformation rect = new RectangleInformation();
			do
			{
				float tempL, tempR;
				try
				{
					// 要求输入长方体的长
					ProgramTitle(2);
					Console.WriteLine("■ 请输入长方形的长(数字)：");
					tempL = float.Parse(Console.ReadLine());
					Console.Clear();
					// 要求输入长方体的宽
					ProgramTitle(2);
					Console.WriteLine("■ 请输入长方形的宽(数字)：");
					tempR = float.Parse(Console.ReadLine());
					if (tempL < tempR)
					{
						rect = new RectangleInformation(tempR, tempL);
					}
					else
					{
						rect = new RectangleInformation(tempL, tempR);
					}
					isRun = false;
				}
				catch
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("× 请输入一个合法的数字！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (isRun);
			Console.Clear();
			// 输出要求的各项参数
			ProgramTitle(2);
			float[] rectParameter = rect.ReturnParameter();
			Console.WriteLine("长方形的面积：" + rect.CalculateArea());
			Console.WriteLine("长方形的周长：" + rect.CalculatePerimeter());
			Console.WriteLine("长方形的长宽：{0} × {1}", rectParameter[0], rectParameter[1]);
			// 习题 2 结束
			ProgramPause();
			#endregion

			#region 习题 3
			// 习题 3 开始

			// 要求用户输入用户名
			isRun = true;
			string tempPlayerName;
			do
			{
				ProgramTitle(3);
				Console.WriteLine("■ 请为你的角色取一个名字：");
				tempPlayerName = Console.ReadLine();
				if (tempPlayerName != "")
				{
					isRun = false;
					Console.Clear();
				}
				else
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("× 角色的名字可以是任意字符，但是不能为空！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (isRun);

			// 要求用户选择职业
			isRun = true;
			int tempPlayerCareer = 0;
			do
			{
				ProgramTitle(3);
				Console.Write("■ ");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(tempPlayerName);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("，请选择你的职业(按'a'和'd'选择，按'e'确定)。");
				// 选项卡界面
				switch (tempPlayerCareer)
				{
					case 0:
						Console.Write("← 法师 ");
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("战士 ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("猎人 →");
						break;
					case 1:
						Console.Write("← 战士 ");
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("猎人 ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("法师 →");
						break;
					case 2:
						Console.Write("← 猎人 ");
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("法师 ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("战士 →");
						break;
				}
				// 获取用户按下的按键进行操作
				char tempChar = Console.ReadKey(true).KeyChar;
				switch (tempChar)
				{
					case 'a':
						if (tempPlayerCareer == 0)
						{
							tempPlayerCareer = 2;
						}
						else
						{
							tempPlayerCareer -= 1;
						}
						break;
					case 'd':
						if (tempPlayerCareer == 2)
						{
							tempPlayerCareer = 0;
						}
						else
						{
							tempPlayerCareer += 1;
						}
						break;
					case 'e':
						isRun = false;
						break;
				}
				Console.Clear();
			} while (isRun);

			// 要求用户选择职业技能
			isRun = true;
			int tempPlayerSkill = tempPlayerCareer;
			do
			{
				ProgramTitle(3);
				Console.Write("■ ");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(tempPlayerName);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("，请选择你的职业技能(按'a'和'd'选择，按'e'确定)。");
				// 选项卡界面
				switch (tempPlayerSkill)
				{
					case 0:
						Console.Write("← 奥术冲击 ");
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("冲锋 ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("假死 →");
						break;
					case 1:
						Console.Write("← 冲锋 ");
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("假死 ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("奥术冲击 →");
						break;
					case 2:
						Console.Write("← 假死 ");
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("奥术冲击 ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("冲锋 →");
						break;
				}
				char tempChar = Console.ReadKey(true).KeyChar;
				switch (tempChar)
				{
					case 'a':
						if (tempPlayerSkill == 0)
						{
							tempPlayerSkill = 2;
						}
						else
						{
							tempPlayerSkill -= 1;
						}
						break;
					case 'd':
						if (tempPlayerSkill == 2)
						{
							tempPlayerSkill = 0;
						}
						else
						{
							tempPlayerSkill += 1;
						}
						break;
					case 'e':
						isRun = false;
						break;
				}
				Console.Clear();
			} while (isRun);
			// 按要求输出信息
			PlayerInformation playerD1 = new PlayerInformation(tempPlayerName, tempPlayerCareer, tempPlayerSkill);
			ProgramTitle(3);
			Console.Write("■ ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(playerD1.CareerName());
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.Write(playerD1.PlayerName());
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("释放了职业技能");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(playerD1.SkillName());
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(".");
			// 习题 3 结束
			ProgramPause();
			#endregion
		}
	}
}
