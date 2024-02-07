using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== Homework - lesson 9 - 习题1 ======");

			#region 习题1 | 请用户输入一个数字。如果输入有误，则提示用户输入错误。
			int userLuckyNumber;
			try
			{
				Console.WriteLine("请输入一个你的幸运数字：");
				userLuckyNumber = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("I’m sorry~ | 你输入的幸运数字不合法");
			}
			#endregion

			Console.WriteLine();
			Console.WriteLine("====== Homework - lesson 9 - 习题1 ======");

			#region 习题2 | 提示用户输入姓名、语文、数学、英语成绩。如果输入的成绩有误，则提示用户输入错误；否则将输入的字符串转为整形变量存储。
			string stuName;
			int stuChinese;
			int stuMath;
			int stuEnglish;
			try {
				Console.WriteLine("■ 请输入学生姓名：");
				stuName = Console.ReadLine();
				Console.WriteLine("□ 请输入语文成绩：");
				stuChinese = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("□ 请输入数学成绩：");
				stuMath = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("□ 请输入英语成绩：");
				stuEnglish = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("○ 数据录入完成，需要你请核对信息");
				Console.WriteLine("===== 成 ===== 绩 ===== 单 =====");
				Console.WriteLine("姓名：" + stuName + "\n" + "语文：" + stuChinese + " |数学：" + stuMath + " |英语：" + stuEnglish);
				Console.WriteLine("===== 请 ===== 核 ===== 对 =====");
			}
			catch {
				Console.WriteLine("○ 数据录入失败，录入了不合法的数据");
			}
			#endregion
		}
	}
}
