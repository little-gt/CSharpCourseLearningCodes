using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson18
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("========== 习题 1 ==========");
			#region 习题1 | 输出1到100
			int tempNumber = 0;
			while (tempNumber < 100)
			{
				tempNumber++;
				Console.Write(tempNumber + " ");
			}
			Console.WriteLine();
			#endregion

			Console.WriteLine("========== 习题 2 ==========");
			#region 习题2 | 输出从1到100的整数的和
			int tempTotal;
			tempNumber = 0;
			tempTotal = 0;
			while (tempNumber < 100)
			{
				tempNumber++;
				tempTotal = tempNumber + tempTotal;
			}
			Console.WriteLine("□ 合计：" + tempTotal + " | 最后一个数：" + tempNumber);
			#endregion

			Console.WriteLine("========== 习题 3 ==========");
			#region 习题3 | 用while和continue实现计算1到100（包含）之间的除了能被7整除之外所有整数的和
			tempNumber = 0;
			tempTotal = 0;
			while (tempNumber < 100)
			{
				tempNumber++;
				if (tempNumber % 7 == 0)
				{
					continue;
				}
				tempTotal = tempTotal + tempNumber;
			}
			Console.WriteLine("□ 合计：" + tempTotal + " | 最后一个数：" + tempNumber);
			#endregion

			Console.WriteLine("========== 习题 4 ==========");
			#region 习题4 | 提示用户输入一个数，判断该数是否是素数并打印
			bool isCirculate = true;
			bool isPrime = true;
			tempNumber = 0;
			tempTotal  = 1;

			Console.WriteLine("■ 素数/质数 | 只能被1和这个数字本身整除的数字，1不是素数/质数，最小的素数/质数是2。");
			while (isCirculate)
			{
				try
				{
					Console.WriteLine("□ 请输入一个数，以判断它是否是素数/质数：");
					tempNumber = Convert.ToInt32(Console.ReadLine());
					if (tempNumber < 0)
					{
						// 数值必须为非负数
						Console.WriteLine("× 你输入的值不合法哦，请重试！");
						continue;
					}
					isCirculate = false;
				}
				catch
				{
					Console.WriteLine("× 你输入的值不合法哦，请重试！");
				}
			}

			if (tempNumber == 0 || tempNumber == 1)
			{
				// 0 或者 1 既不是合数也不是质数
				isPrime = false;
				Console.WriteLine("○ 你输入的：" + tempNumber + " 不是质数，因为它既不是质数也不是合数");
			}
			else if (tempNumber == 2)
			{
				// 2 是最小的质数
				isPrime = true;
				Console.WriteLine("○ 你输入的：" + tempNumber + " 是个质数");
			}
			else
			{
				// 除了 0 1 2 以外通过定义判断
				while (tempNumber > tempTotal)
				{
					tempTotal++;
					if (tempNumber % tempTotal == 0 && tempTotal != tempNumber)
					{
						// 发现除了他本身以外得数可以被整数
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					Console.WriteLine("○ 你输入的：" + tempNumber + " 是个质数");
				}
				else
				{
					Console.WriteLine("○ 你输入的『 " + tempNumber + " 』不是质数，而且它可以被除了1或者本身的数『 " + tempTotal + " 』整除");
				}
			}
			#endregion

			Console.WriteLine("========== 习题 5 ==========");
			#region 习题5 | 要求输入用户名和密码（admin/8888），用户名或者密码错误，则提示“用户名或密码错误”，直到输入正确为止
			string userAccount, userPassword;
			isCirculate = true;
			while (isCirculate)
			{
				Console.WriteLine("□ 请输入用户名：");
				userAccount = Console.ReadLine();
				Console.WriteLine("□ 请输入密码：");
				userPassword = Console.ReadLine();
				if (userAccount == "admin" && userPassword == "8888")
				{
					isCirculate = true;
					Console.WriteLine("☆ 欢迎您：" + userAccount + "\n" + "☆ 您已成功登录系统，请耐心等待系统加载......");
					break;
				}
				Console.WriteLine("× 用户名或者密码不正确，请重新尝试");
			}
			#endregion

			Console.WriteLine("========== 习题 6 ==========");
			#region 习题6 | 输入班级人数，然后依次输入学员成绩(需提示当前是第几个学员），计算班级学员的平均成绩和总成绩
			int stuNumber, stuScoreTotal, stuScoreTemp, stuNow;

		    Console.WriteLine("□ 请输入班级总人数（必须为正数）：");
			try
			{
				stuNumber = Convert.ToInt32(Console.ReadLine());
				if (stuNumber <= 0)
				{
					stuNumber = 20;
					Console.WriteLine("× 输入的参数不合规，已经自动填充数值");
				}
			}
			catch
			{
				stuNumber = 20;
				Console.WriteLine("× 输入的参数不合规，已经自动填充数值");
			}

			stuNow = 0;
			stuScoreTotal = 0;
			while (stuNumber > stuNow)
			{
				stuNow++;
				try
				{
					Console.WriteLine("□ 现在是第『 " + stuNow + " 』名学生，共计" + stuNumber + "名学生，请他的输入成绩：");
					stuScoreTemp = Convert.ToInt32(Console.ReadLine());
					if (stuScoreTemp <= 0)
					{
						stuScoreTemp = 0;
						Console.WriteLine("× 输入的成绩不正确，已自动抛弃该成绩。");
					}
					stuScoreTotal = stuScoreTotal + stuScoreTemp;
				}
				catch
				{
					stuScoreTemp = 0;
					stuScoreTotal = stuScoreTotal + stuScoreTemp;
					Console.WriteLine("× 输入的成绩不正确，已自动抛弃该成绩。");
				}
			}
			Console.WriteLine("■ 学生总数为：" + stuNumber + " | 总成绩为：" + stuScoreTotal + " | 平均分为：" + (stuScoreTotal / stuNumber));
			#endregion

			Console.WriteLine("========== 习题 7 ==========");
			#region 习题7 | 定义一个整形变量sum，然后分别把1~100之间的数字依次累加到sum中，当sum的值大于500的时候，中断操作，并在控制台输出累加到第几个数字就可以使sum大于500
			int sum = 0;
			tempNumber = 0;
			while(sum <= 500)
			{
				tempNumber++;
				sum = sum + tempNumber;
			}
			Console.WriteLine("■ 累加到" + tempNumber + "时，sum值（" + sum + "）大于了500.");
			#endregion

			Console.WriteLine("========== 习题 8 ==========");
			#region 习题8 | 假设看唐老狮视频的同学有100人，每个月增长20%，请问按此速度增长，经历多少个月看唐老狮视频的同学能达到1000人?
			int dataNumber;
			float dataTemp, dataTotal;

			dataNumber = 0;
			dataTemp = 100f;
			dataTotal = dataTemp;

			while ((dataTotal - 1000f) <= 0)
			{
				dataNumber++;
				dataTemp = dataTemp * 1.2f;
				dataTotal = dataTotal + dataNumber;
			}

			Console.WriteLine("□ 需要经历" + dataNumber + "月看唐老狮视频的同学能达" + dataTotal + "人");
			#endregion

			Console.WriteLine("========== 习题 9 ==========");
			#region 习题9 | 求数列1,1,2,3,5,8,13…的第20位数字是多少？
			string tempSeries;
			int tempN1, tempN2, tempN;
			tempN1 = 1;
			tempN2 = 1;
			tempNumber = 2;
			tempSeries = "1 1";

			while (tempNumber < 20)
			{
				tempNumber++;
				tempN = tempN1 + tempN2;
				tempN1 = tempN2;
				tempN2 = tempN;
				tempSeries = tempSeries + " " + tempN2;
			}
			Console.WriteLine("□ 数列计算结果：" + tempSeries + " ... ...");
			Console.WriteLine("□ 数列的第20项：" + tempN2);
			#endregion
		}
	}
}
