using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson5
{
	enum E_Sex
	{
		Male,
        Female,
	}
	class Student
	{
		string stuName;
		int stuAge;
		int stuScore_CSharp;
		int stuScore_Unity;
		E_Sex stuSex;

		#region 构造函数 | 要求完全初始化或者基本初始化
		/// <summary>
		/// 构造 | 完全初始化，传入所有参数
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="age">年龄，范围[0,150]</param>
		/// <param name="CSharpScore">C#分数，范围[0,100]</param>
		/// <param name="UnityScore">Unity分数，范围[0,100]</param>
		/// <param name="sex">性别，只能是男生或者女生</param>
		public Student(string name, int age, int CSharpScore, int UnityScore, E_Sex sex)
		{
			stuName = name;
			ValueAge = age;
			ValueCSharpScore = CSharpScore;
			ValueUnityScore = UnityScore;
			stuSex = sex;
		}
		/// <summary>
		/// 构造 | 基本初始化，不出入成绩
		/// </summary>
		/// <param name="name">姓名</param>
		/// <param name="age">年龄，范围[0,150]</param>
		/// <param name="sex">性别，只能是男生或者女生</param>
		public Student(string name, int age, E_Sex sex)
		{
			stuName = name;
			ValueAge = age;
			stuSex = sex;
			stuScore_CSharp = -1;
			stuScore_Unity = -1;
		}
		#endregion

		/// <summary>
		/// 公开 | 学生的年龄，赋值时要求值在0~150之间，否则会导致赋值失败
		/// </summary>
		public int ValueAge
		{
			// 要求 | 年龄必须在 0 ~ 150 岁之间
			set 
			{
				if (value >= 0 && value <= 150)
				{
					stuAge = value;
				}
				else
		        {
					// 不符合要求，输出Debug报错信息
					System.Diagnostics.Debug.WriteLine("× 类 Student 的 ValueAge 在赋值时的区间为[0,150]，传入的值({0})不在这个范围内，赋值失败.", value);
				}
			}
			// 返回 | 正常返回 
			get
			{
				return stuAge;
			}
		}

		/// <summary>
		/// 公开 | 学生的C#分数，赋值时要求值在0~100之间，否则会导致赋值失败
		/// </summary>
		public int ValueCSharpScore
		{
			// 要求 | 分数必须在0~100之间
			set
			{
				if (value >= 0 && value <= 100)
				{
					stuScore_CSharp = value;
				}
				else
				{
					// 不符合要求，输出Debug报错信息
					stuScore_CSharp = -1;
					System.Diagnostics.Debug.WriteLine("× 类 Student 的 ValueCSharpScore 在赋值时的区间为[0,100]，传入的值({0})不在这个范围内，赋值失败.", value);
				}
			}
			// 返回 | 正常返回
			get
			{
				return stuScore_CSharp;
			}
		}

		/// <summary>
		/// 公开 | 学生的Unity分数，赋值时要求值在0~100之间，否则会导致赋值失败
		/// </summary>
		public int ValueUnityScore
		{
			// 要求 | 分数必须在0~100之间
			set
			{
				if (value >= 0 && value <= 100)
				{
					stuScore_Unity = value;
				}
				else
				{
					// 不符合要求，输出Debug报错信息
					stuScore_Unity = -1;
					System.Diagnostics.Debug.WriteLine("× 类 Student 的 ValueUnityScore 在赋值时的区间为[0,100]，传入的值({0})不在这个范围内，赋值失败.", value);
				}
			}
			// 返回 | 正常返回
			get
			{
				return stuScore_Unity;
			}
		}

		/// <summary>
		/// 限制 | 学生的姓名，只允许读取不允许修改
		/// </summary>
		public string ValueName
		{
			get
			{
				return stuName;
			}
		}

		/// <summary>
		/// 方法 | 在控制台输出对自己的介绍，格式为：自己叫XX，今年X岁了，是男同学还是女同学
		/// </summary>
		public void Function_DrawIntroduceMyself()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("你好啊，我叫");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(stuName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(".");

			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("我今年已经");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(stuAge);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("岁了，我可是");
			Console.ForegroundColor = ConsoleColor.Green;
			if (stuSex == E_Sex.Male)
			{
				Console.Write("男");
			}
			else
			{
				Console.Write("女");
			}
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("同学哦，很高兴认识你~");
		}

		/// <summary>
		/// 方法 | 计算学生的两门课程的平均分(进行四舍五入，只保留整数)，并且返回
		/// </summary>
		/// <returns></returns>
		public int Function_CalculateTheAverageScore()
		{
			if (stuScore_CSharp != -1 && stuScore_Unity != -1)
			{
				return (stuScore_CSharp + stuScore_Unity) / 2;
			}
			else
			{
				System.Diagnostics.Debug.WriteLine("× 类 Student 的 score 的两个参数没有完全赋值，无法进行计算，已返回错误代码-1.");
				return -1;
			}
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student("小德", 17, 85, 83, E_Sex.Male);
			Student student2 = new Student("小涵", 18, 83, 84, E_Sex.Male);
			Student student3 = new Student("小栗", -1, 101, 102, E_Sex.Male);
			student1.Function_DrawIntroduceMyself();
			Console.WriteLine("> 平均分：" + student1.Function_CalculateTheAverageScore());
			student2.Function_DrawIntroduceMyself();
			Console.WriteLine("> 平均分：" + student2.Function_CalculateTheAverageScore());
			student3.Function_DrawIntroduceMyself();
			Console.WriteLine("> 平均分：" + student3.Function_CalculateTheAverageScore());
		}
	}
}
