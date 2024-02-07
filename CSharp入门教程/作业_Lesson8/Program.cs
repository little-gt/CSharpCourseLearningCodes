using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 习题1 ======");
			#region 习题 | 将24069转成字符，并打印
			int valueInt;
			string valueString;

			valueInt = 24069;

			valueString = valueInt.ToString();
			Console.WriteLine(valueString);
			#endregion

			Console.WriteLine();
			Console.WriteLine(" ====== 习题2 ======");

			#region 习题 | 提示用户输入姓名、语文、数学、英语成绩，并将输入的3门成绩用整形变量存储
			int scoreChinese;
			int scoreMath;
			int scoreEnglish;
			string scoreName;
			Console.WriteLine("■ 欢迎使用，录入信息以后按回车确认 ■");
			Console.WriteLine("请您输入您的姓名：");
			scoreName = Console.ReadLine();
			Console.WriteLine("请输入您的语文成绩：");
			scoreChinese = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("请输入您的数学成绩：");
			scoreMath = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("请输入您的英语成绩：");
			scoreEnglish = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("■ 谢谢使用，录入信息成功，需要核实 ■");

			Console.WriteLine();
			Console.WriteLine("您录入的姓名：" + scoreName);
			Console.WriteLine("语文成绩：" + scoreChinese + "分 |数学成绩：" + scoreMath + "分 |英语成绩：" + scoreEnglish + "分");
			#endregion
		}
	}
}
