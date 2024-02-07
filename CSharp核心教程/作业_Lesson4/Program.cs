using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson4
{
	#region 习题1 | 使用Human作为类，并且进行构造函数的重构，之后创建多个对象
	enum E_HumanSex
	{
		Undefined,
		Male,
		Female,
		Other,
	}
	class Human
	{
		string name;
		uint age;
		uint weight;
		uint height;
		E_HumanSex sex;

		#region 构造函数 | 对对象进行初始化，全部赋值
		/// <summary>
		/// 无参数构造，默认全部赋值为初始值
		/// </summary>
		public Human()
		{
			name = "";
			age = 0;
			weight = 0;
			height = 0;
			sex = E_HumanSex.Undefined;
		}
		/// <summary>
		/// 有参数构造，只给传入的参数赋值，其他的为初始值
		/// </summary>
		/// <param name="name">姓名</param>
		public Human(string name) : this()
		{
			this.name = name;
		}
		/// <summary>
		/// 有参数构造，只给传入的参数赋值，其他的为初始值
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="age">年龄(X岁)</param>
		public Human(string name, uint age) : this()
		{
			this.name = name;
			this.age = age;
		}
		/// <summary>
		/// 有参数构造，只给传入的参数赋值，其他的为初始值
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="age">年龄(X岁)</param>
		/// <param name="weight">体重(Xkg)</param>
		/// <param name="height">身高(Xcm)</param>
		public Human(string name, uint age, uint weight, uint height) : this()
		{
			this.name = name;
			this.weight = weight;
			this.height = height;
			this.age = age;
		}
		/// <summary>
		/// 全参数构造，将所有的参数进行赋值
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="age">年龄(X岁)</param>
		/// <param name="weight">体重(Xkg)</param>
		/// <param name="height">身高(Xcm)</param>
		/// <param name="sex">性别</param>
		public Human(string name, uint age, uint weight, uint height, E_HumanSex sex)
		{
			this.name = name;
			this.age = age;
			this.height = height;
			this.weight = weight;
			this.sex = sex;
		}
		#endregion
	}
	#endregion

	#region 习题2 | 使用Grade作为类，并且使用构造函数的重构，之后创建多个对象
	enum E_ClassCode
	{
		Chinese,
		Math,
		English,

		Physics,
		Chemotherapy,
		Biotechnology,

		Geography,
        Politics,
        History,
	}
	class Student
	{
		string stuName;
		uint stuCode;
		uint stuAge;
		E_HumanSex stuSex;

		#region 构造函数 | 全部初始化
		/// <summary>
		/// 基本初始化 | 包含姓名和学号信息
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="code">学号</param>
		public Student(string name, uint code)
		{
			stuName = name;
			stuCode = code;
		}
		/// <summary>
		/// 完整初始化 | 包含所有的基本信息
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="code">学号</param>
		/// <param name="age">年龄</param>
		/// <param name="sex">性别</param>
		public Student(string name, uint code, uint age, E_HumanSex sex)
		{
			stuName = name;
			stuCode = code;
			stuAge = age;
			stuSex = sex;
		}
		#endregion
	}
	class Grade
	{
		uint basic_ClassCode;
		uint basic_YearOfEnrolment;
		uint basic_YearOfSchooling;
		uint basic_NumberOfStudents;
		E_ClassCode[] class_ClassCodetable;
		Student[] students;

		#region 构造函数 | 全部进行赋值
		/// <summary>
		/// 无参数构造，默认全部赋值为0或者无
		/// </summary>
		public Grade()
		{
			basic_ClassCode = 0;
			basic_NumberOfStudents = 0;
			basic_YearOfEnrolment = 0;
			basic_YearOfSchooling = 0;
			students = new Student[0];
		}
	    /// <summary>
		/// 基础初始化，只包含入学年级和学制
		/// </summary>
		/// <param name="classCode">班级代码</param>
		/// <param name="yearOfEnrolment">入学年份</param>
		/// <param name="yearOfSchooling">学年学制</param>
		public Grade(uint classCode, uint yearOfEnrolment, uint yearOfSchooling)
		{
			basic_ClassCode = classCode;
			basic_YearOfEnrolment = yearOfEnrolment;
			basic_YearOfSchooling = yearOfSchooling;
			students = new Student[0];
		}
		/// <summary>
		/// 基础初始化，没有导入学生的详细资料
		/// </summary>
		/// <param name="classCode"></param>
		/// <param name="yearOfEnrolment"></param>
		/// <param name="yearOfSchooling"></param>
		/// <param name="numberOfStudents"></param>
		public Grade(uint classCode, uint yearOfEnrolment, uint yearOfSchooling, uint numberOfStudents)
		{
			basic_ClassCode = classCode;
			basic_YearOfEnrolment = yearOfEnrolment;
			basic_YearOfSchooling = yearOfSchooling;
			basic_NumberOfStudents = numberOfStudents;
			students = new Student[0];
		}
		/// <summary>
		/// 高级初始化，导入所有班级学生的资料
		/// </summary>
		/// <param name="classCode"></param>
		/// <param name="yearOfEnrolment"></param>
		/// <param name="yearOfSchooling"></param>
		/// <param name="numberOfStudents"></param>
		/// <param name="students"></param>
		public Grade(uint classCode, uint yearOfEnrolment, uint yearOfSchooling, uint numberOfStudents, Student[] students)
		{
			basic_ClassCode = classCode;
			basic_YearOfEnrolment = yearOfEnrolment;
			basic_YearOfSchooling = yearOfSchooling;
			basic_NumberOfStudents = numberOfStudents;
			this.students = students;
		}
		#endregion

		#region 方法函数 | 添加学生到班级
		/// <summary>
		/// 方法：添加学生到班级
		/// </summary>
		/// <param name="needAdd">需要添加的学生信息</param>
		public void Function_AddStudent(Student needAdd)
		{
			// 新建 | 存缓学生数组
			Student[] temp_Students = new Student[students.Length + 1];
			// 循环 | 将旧的已绑定的学生迁移到缓存学生数组中
			for (int i = 0; i < students.Length; i++)
			{
				temp_Students[i] = students[i];
			}
			// 添加 | 将新添加的学生加入到缓存的学生数组当中
			temp_Students[temp_Students.Length - 1] = needAdd;
			// 迁移 | 将学生数组进行迁移
			students = temp_Students;
			// 回收 | 对垃圾进行回收，防止内存占用
			GC.Collect();
		}
		#endregion

	}
	#endregion

	#region 习题3 | 使用Ticket作为类，并且通过此类进行价格和打折运算
	class Ticket
	{
		uint basicKilometers;
		uint basicNumber;
		uint basicOriginalPrice;
		public float ticketUnitPrice;
		public float ticketTotalPrice;
		public float ticketTotalDiscount;

		#region 构造函数 | 要求所有的基本信息
		/// <summary>
		/// 初始化票务计算，要求输入所有的基本信息
		/// </summary>
		/// <param name="distance">里程(km)且取整数</param>
		/// <param name="number">票数(张)且必为整数</param>
		public Ticket(uint distance, uint number)
		{
			// 对基本信息就行处理
			basicKilometers = distance;
			basicNumber = number;
			basicOriginalPrice = basicKilometers * basicNumber;

			// 对折扣就行处理，确定折扣
			if (basicKilometers <= 100)
			{
				ticketTotalDiscount = 1f;
			}
			if (basicKilometers >= 101 && basicKilometers <= 200)
			{
				ticketTotalDiscount = 0.95f;
			}
			if (basicKilometers >= 201 && basicKilometers <= 300)
			{
				ticketTotalDiscount = 0.9f;
			}
			if (basicKilometers >= 301)
			{
				ticketTotalDiscount = 0.8f;
			}

			// 计算所有折扣后的实付价格
			ticketUnitPrice = basicKilometers * ticketTotalDiscount;
			ticketTotalPrice = basicOriginalPrice * ticketTotalDiscount;
		}
		#endregion

		#region 方法 | 输出确认界面信息
		/// <summary>
		/// 信息核对界面，返回真表示正确无误，返回假表示出现错误
		/// </summary>
		/// <returns></returns>
		public bool DrawConfirmationScreen()
		{
			// title
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("Welcome to the ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("E+ Length Ticket Purchasing");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine(" System.");

			// split line
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("=======================");

			// describe
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("□ We sincerely hope you can check your order information:");

			// split line
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("=======================");

			// information
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("◆ Mileage: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(basicKilometers);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" km");

			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("◆ Numbers: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(basicNumber);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" tickets");

			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("◆ Discounted Price (per ticket): ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(ticketUnitPrice);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" CNY");

			// split line
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("=======================");

			// comform
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("■ Press ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[a]");
			Console.ForegroundColor = ConsoleColor.White; 
			Console.Write(" for accurate information and ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[d]");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" for incorrect information.");

			do
			{
				char tempE = Console.ReadKey(true).KeyChar;
				switch (tempE)
				{
					case 'a':
						Console.Clear();
						return true;
					case 'd':
						Console.Clear();
						return false;
				}
			} while (true);
		}
		#endregion

		#region 方法 | 输出最终界面信息
		public void DrawEndScreen()
		{
			// title
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("Welcome to the ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("E+ Length Ticket Purchasing");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine(" System.");

			// split line
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("=======================");

			// describe
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("□ Thank you for purchasing our tickets, detailed order information can be found below:");

			// split line
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("=======================");

			// details
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Purchased {0} tickets with mileage of {1} kilometers each for a total of ${2}.", basicNumber, basicKilometers, ticketTotalPrice);

			Console.Write("★ Discount: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(1f - ticketTotalDiscount);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" OFF");

			Console.Write("★ Original Price: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(basicOriginalPrice);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" CNY");

			Console.Write("★ Accumulated Savings: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(basicOriginalPrice - ticketTotalPrice);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" CNY");

			// split line
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("=======================");

			// operation
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("■ Press any button to continue.");
			Console.ReadKey(true);
			Console.Clear();
		}
		#endregion

	}
	#endregion

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
			Console.WriteLine("Post-course exercises (3 questions) on constructors, destructors and rubbish collection mechanism.");
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

			#region 习题1 | 对人类(Human类)的构造函数进行重载，用人类创建若干个对象
			Human human1 = new Human("钟昂然", 12, 55, 168, E_HumanSex.Male);
			Human human2 = new Human("万光耀", 15, 60, 175);
			Human human3 = new Human("钱炎彬", 17);
			Human human4 = new Human("叶宏茂");
			Human human5 = new Human();
			Console.WriteLine("> 习题 1 的程序已经运行，请阅读源文件，检查");
			#endregion

			#region 习题2 | 对班级类的构造函数进行重载，用班级类创建若干个对象
			Student student1 = new Student("融平惠", 23310013);
			Student student2 = new Student("漕一禾", 23310014);
			Student student3 = new Student("王桂芝", 23310015);
			Student student4 = new Student("印笑天", 23310016);

			Grade G2023_Class1 = new Grade(233001, 2023, 3);
			G2023_Class1.Function_AddStudent(student1);
			G2023_Class1.Function_AddStudent(student2);

			Grade G2023_Class2 = new Grade(233002, 2023, 3);
			G2023_Class2.Function_AddStudent(student3);
			G2023_Class2.Function_AddStudent(student4);

			Console.WriteLine("> 习题 2 的程序已经运行，请阅读源文件，检查");
			#endregion

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("> The program for the third question has UI drawing, press any key to load it.");
			Console.ReadKey(true);
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;

			#region 习题3 | 写一个Ticket类，有一个距离变量(distance在构造对象时赋值，不能为负数)，有一个价格特征，有一个方法GetPrice可以读取到价格，并且根据距离distance汁算价格price(1元/公里)
			Ticket ticket;
			do
			{
				Console.Clear();

				uint tempMileage;
				uint tempNumbers;

				// title
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write("Welcome to the ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("E+ Length Ticket Purchasing");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine(" System.");

				// split line
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("=======================");
				Console.ForegroundColor = ConsoleColor.White;

				// discount
				Console.WriteLine("□ Tickets implement different discount programs based on mileage (Less than one kilometer is counted as one kilometer, e.g., 2.3 kilometers is counted as 3 kilometers).");

				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("★ ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("No discount: ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("0 to 100 kilometers");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("★ ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Enjoy 05% off: ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("101 to 200 kilometers");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("★ ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Enjoy 10% off: ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("201 to 300 kilometers");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("★ ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Enjoy 20% off: ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("over 30 kilometers");

				// enter
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("=======================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("■ Please enter the mileage (in kilometers):");
			    
				try
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					tempMileage = Convert.ToUInt32(Console.ReadLine());
					if (tempMileage == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("× We're sorry, the ticket numbers you entered is not legal, please press any key and try again.");
						Console.ForegroundColor = ConsoleColor.White;
						Console.ReadKey(true);
						continue;
					}
					Console.ForegroundColor = ConsoleColor.White;
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× We're sorry, the mileage you entered is not legal, please press any key and try again.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.ReadKey(true);
					continue;
				}

				// enter
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("=======================");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("■ Please enter the number of tickets you need to purchase (at least 1):");

				try
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					tempNumbers = Convert.ToUInt32(Console.ReadLine());
					if (tempNumbers == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("× We're sorry, the ticket numbers you entered is not legal, please press any key and try again.");
						Console.ForegroundColor = ConsoleColor.White;
						Console.ReadKey(true);
						continue;
					}
					Console.ForegroundColor = ConsoleColor.White;
				}
				catch (Exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× We're sorry, the ticket numbers you entered is not legal, please press any key and try again.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.ReadKey(true);
					continue;
				}

				// submit
				ticket = new Ticket(tempMileage,tempNumbers);

				// operation
				Console.WriteLine("=======================");
				Console.WriteLine("■ Your order has been submitted, press any key for order verification.");
				Console.ReadKey(true);
				Console.Clear();

				// 确认订票信息，如果不对，重新开始
				if (!ticket.DrawConfirmationScreen())
				{
					continue;
				}

				ticket.DrawEndScreen();
				break;
			} while (true);
			#endregion

			DrawProgramEndScreen();
		}
	}
}
