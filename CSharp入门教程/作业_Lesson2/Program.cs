using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_课后作业
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("===== 1 =====");
			//作业1：下面代码的输出结果是？
			//double num = 36.6;
			//Console.WriteLine("num");
			Console.WriteLine("因为使用了 双引号把内容包裹 所以输出的为字符串 num");

			Console.WriteLine("===== 2 =====");
			//作业2：声明float类型变量时，为何要在数字后面加f?
			Console.WriteLine("因为系统会默认的小数赋值类型为double，所以需要用f表示赋值的类型是float，防止精度丢失");

			Console.WriteLine("===== 3 =====");
			//作业3：请定义系列变量来存储你的名字、年龄、性别、身高、体重、家庭住址等，并打的出来。
			string UserName, UserLocat, UserSex;
			byte UserAge;
			float UserHeight, UserWeight;
			Console.WriteLine("请输入您的姓名，按回车确认：");
			UserName = Console.ReadLine();
			Console.WriteLine("请输入您的住址，按回车确认：");
			UserLocat = Console.ReadLine();
			Console.WriteLine("请输入您的年龄，按回车确认：");
			UserAge = byte.Parse(Console.ReadLine());
			Console.WriteLine("请选择您的性别，输入“男”或“女”或其他，按回车确认：");
			UserSex = Console.ReadLine();
			Console.WriteLine("请输入您的身高（单位：m），按回车确认：");
			UserHeight = float.Parse(Console.ReadLine());
			Console.WriteLine("请输入您的体重（单位：kg），按回车确认：");
			UserWeight = float.Parse(Console.ReadLine());
			Console.WriteLine("您的基本信息 |");
			Console.Write("姓名：" + UserName + "  ");
			Console.Write("年龄：" + UserAge + "  ");
			Console.Write("性别：" + UserSex +'\n');
			Console.WriteLine("您的身体指数 |");
			Console.Write("身高：" + UserHeight + "m  ");
			Console.Write("体重：" + UserWeight + "kg  ");
			Console.Write("BMI:"+ UserWeight/(UserHeight*UserHeight) +'\n');
			Console.WriteLine("您的家庭住址 |");
			Console.Write("性别：" + UserLocat + '\n');
	        
			Console.WriteLine("===== 4 =====");
			//作业4：小明的数学考试成绩是80，语文的考试成绩是78，英语的考试成绩是98，请用变呈描述并打印。
			byte ScoreMath, ScoreChinese, ScoreEnglish;
			ScoreMath = 80;
			ScoreChinese = 78;
			ScoreEnglish = 98;
			Console.WriteLine("您好，欢迎查询成绩，请输入您的姓名：");
			if (Console.ReadLine() == "小明")
			{
				Console.WriteLine("——— 小明的成绩单 ———");
				Console.WriteLine("语文成绩：" + ScoreChinese + "分");
				Console.WriteLine("数学成绩：" + ScoreMath + "分");
				Console.WriteLine("英语成绩：" + ScoreEnglish + "分");
				Console.WriteLine("平均成绩：" + (ScoreMath + ScoreEnglish + ScoreChinese) / 3 + "分");
				Console.WriteLine("——— 希望你可以再接再厉！ ———");
			}
			else
			{
				Console.WriteLine("——— 成绩单不存在 ———");
			}

			Console.WriteLine("===== END · 按任意键退出 =====");
			Console.ReadKey();
		}
	}
}
