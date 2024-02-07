using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson15
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("======== 习题 1 ========");
			#region 习题1 | 比较两个数的大小，求出最大的。
			Random random = new Random();
			int valueNumber1 = random.Next(1, 100);
			int valueNumber2 = random.Next(1, 100);

			Console.WriteLine("□ 欲比较数: " + valueNumber1 + " | " + valueNumber2);
			Console.WriteLine("○ 最大的数：" + (valueNumber1 > valueNumber2 ? valueNumber1 : valueNumber2));
			#endregion

			Console.WriteLine("======== 习题 2 ========");
			#region 习题2 | 提示用户输入一个姓名，然后再控制台输出姓名，只要输入的不是帅哥，就显示美女。
			Console.WriteLine("□ 请输入一个姓名");
			string inputName = Console.ReadLine();
			Console.WriteLine("○ 您输入的姓名：" + inputName + " ，是" + (inputName == "帅哥" ? "帅哥" : "美女") + "吗？");
			#endregion

			Console.WriteLine("======== 习题 3 ========");
			#region 习题3 | 依次输入学生的姓名，C#语言的成绩，Unity的成绩，两门成绩都大于等于90分，才能毕业，请输出最后的结果。
			string stuName;
			int scoreCSharp, scoreUnity;

			Console.WriteLine("□ 请输入您的姓名：");
			stuName = Console.ReadLine();
			Console.WriteLine("□ 请输入 C#语言 成绩：");
			try
			{
				scoreCSharp = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("× 非法成绩，各科目成绩作废");
				scoreCSharp = 0;
			}
			Console.WriteLine("□ 请输入 Unity 成绩：");
			try
			{
				scoreUnity = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("× 非法成绩，各科目成绩作废");
				scoreUnity = 0;
			}
			Console.WriteLine("☆ 毕业结论：" + (scoreCSharp >= 90 && scoreUnity >= 90 ? "准许毕节" : "不予毕业"));
			#endregion

			Console.WriteLine("======== 习题 4 ========");
			#region 习题4 | 要求用户输入一个年份，然后判断是不是闰年？
			int cacheYear;
			bool cacheLeapYear1, cacheLeapYear2;

			Console.WriteLine("□ 请输入一个年份：");
			try
			{
				cacheYear = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				cacheYear = random.Next(1000, 3000);
				Console.WriteLine("× 非法数据，已随机生成一个年份" + cacheYear);
			}
			if ((cacheYear / 400) == 0)
			{
				cacheLeapYear1 = true;
			}
			else
			{
				cacheLeapYear1 = false;
			}
			if ((cacheYear/4) == 0 && (cacheYear/100) != 0)
			{
				cacheLeapYear2 = true;
			}
			else
			{
				cacheLeapYear2 = false;
			}
			Console.WriteLine("☆ 年份" + cacheYear + "是:" + (cacheLeapYear1 || cacheLeapYear2 ? "闰年" : "平年"));
			#endregion
		}
	}
}
