using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson16
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("======== 习题 1 ========");
			#region 习题1 | 请用户输入今日看唐老师视频花了多少分钟，如果大于60分钟，那么在控制台输出“今天看视频花了XX分种，看来你离成功又进了一步！”
			int timeWatchTeacherTangVedio;
			Console.WriteLine("□ 请输入您今日观看唐老师视频的时长（单位：分钟）：");
			try
			{
				timeWatchTeacherTangVedio = int.Parse(Console.ReadLine());
			}
			catch
			{
				timeWatchTeacherTangVedio = 0;
				Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
			}
			Console.WriteLine("○ 今天观看视频花了" + timeWatchTeacherTangVedio + "分钟，" + (timeWatchTeacherTangVedio > 60 ? "看来你离成功又进了一步！" : "看来你还需要多多努力哦~"));
			#endregion

			Console.WriteLine("======== 习题 2 ========");
			#region 习题2 | 请轴入你的语文，数学，英语成绩，满足特定条件，则输出“非常棒，继续加油”
			int scoreChinese, scoreMath, scoreEnglish;
			bool scoreGetRule = false;

			Console.WriteLine("□ 请输入你的 语文 成绩：");
			try
			{
				scoreChinese = Convert.ToInt32(Console.ReadLine());
				if (scoreChinese > 100 || scoreChinese < 0)
				{
					scoreChinese = 0;
					Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
				}
			}
			catch
			{
				scoreChinese = 0;
				Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
			}

			Console.WriteLine("□ 请输入你的 数学 成绩：");
			try
			{
				scoreMath = Convert.ToInt32(Console.ReadLine());
				if (scoreMath > 100 || scoreMath < 0)
				{
					scoreMath = 0;
					Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
				}
			}
			catch
			{
				scoreMath = 0;
				Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
			}

			Console.WriteLine("□ 请输入你的 英语 成绩：");
			try
			{
				scoreEnglish = Convert.ToInt32(Console.ReadLine());
				if (scoreEnglish > 100 || scoreEnglish < 0)
				{
					scoreEnglish = 0;
					Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
				}
			}
			catch
			{
				scoreEnglish = 0;
				Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
			}

			if ( scoreChinese > 70 && scoreMath > 80 && scoreEnglish > 90 )
			{
				scoreGetRule = true;
				Console.WriteLine("√ 你的成绩 完成了目标 | 语文成绩大于70 并且 数学成绩大于80 并且 英语成绩大于90");
			}
			if ( scoreChinese == 100 || scoreEnglish == 100 || scoreMath == 100 )
			{
				scoreGetRule = true;
				Console.WriteLine("√ 你的成绩 完成了目标 | 语文成绩等于100 或者 数学成绩等于100 或者 英语成绩等于100");
			}
			if ( scoreChinese > 90 && (scoreEnglish > 70 || scoreMath > 70) )
			{
				scoreGetRule = true;
				Console.WriteLine("√ 你的成绩 完成了目标 | 语文成绩大于90 并且 其它两门中有一门成绩大于70");
			}

			if ( scoreGetRule )
			{
				Console.WriteLine("☆ 你非常棒哦！继续加油吧~");
			}
			else
			{

				Console.WriteLine("√ 你的成绩 | 没有满足任意一条要求哦！");
				Console.WriteLine("○ 不要灰心嘛~加油，你一定可以的！");
			}
			#endregion

			Console.WriteLine("======== 习题 3 ========");
			#region 习题3 | 定义一个变量，存储小赵的考试成绩，如果小赵的考试成绩大于（含）90分，那么爸营奖励100元钱，否则一个月不能玩游戏
			int scoreXiaoZhao;

			Console.WriteLine("□ 请输入小赵的成绩（100分制）：");
			try
			{
				scoreXiaoZhao = int.Parse(Console.ReadLine());
				if (scoreXiaoZhao < 0 || scoreXiaoZhao > 100)
				{
					scoreXiaoZhao = 0;
					Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
				}
			}
			catch
			{
				scoreXiaoZhao = 0;
				Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
			}

			if (scoreXiaoZhao >= 90)
			{
				Console.WriteLine("☆ 小赵的爸爸会奖励他100元！");
			}
			else
			{
				Console.WriteLine("○ 小赵接下来的1个月不能玩游戏啦。");
			}
			#endregion

			Console.WriteLine("======== 习题 4  ========");
			#region 习题4 | 要求用户输入两个数a、b，如果两个数可以整除或者这两个数加起来大于100，则输出a的值，否则输出b的值
			int a, b;

			Console.WriteLine("□ 请输入一个数a：");
			try
			{
				a = Convert.ToInt32(Console.ReadLine());
				if ( a == 0 )
				{
					a = 233;
					Console.WriteLine("× 输入了不合法的值，已自动填充该值");
				}
			}
			catch
			{
				a = 233;
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			Console.WriteLine("□ 请输入一个数b：");
			try
			{
				b = Convert.ToInt32(Console.ReadLine());
				if (b == 0)
				{
					b = 233;
					Console.WriteLine("× 输入了不合法的值，已自动填充该值");
				}
			}
			catch
			{
				b = 666;
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			if ( a % b == 0 || b % a == 0 )
			{
				Console.WriteLine("○ " + a);
			}
			else if ( a + b > 100 )
			{
				Console.WriteLine("○ " + a);
			}
			else
			{
				Console.WriteLine("○ " + b);
			}
			#endregion

			Console.WriteLine("======== 习题 5  ========");
			#region 习题5 | 输入一个整数，如果这个数是偶数，则打印“Your input is even”，否则打印“Your input is odd”
			long cacheNumber;

			Console.WriteLine("□ 请输入一个整数：");
			try
			{
				cacheNumber = int.Parse(Console.ReadLine());
			}
			catch
			{
				cacheNumber = 666;
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			if (cacheNumber % 2 == 0)
			{
				Console.WriteLine("○ Your input is even");
			}
			else
			{
				Console.WriteLine("○ Your input is odd");
			}
			#endregion

			Console.WriteLine("======== 习题 6  ========");
			#region 习题6 | 有3个整形变量，分别存储不同的值，编写代码输出其中最大的整数
			int valueNumber1, valueNumber2, valueNumber3;
			int cacheNumber1, cacheNumber2;

			Console.WriteLine("□ 请输入第 1 个数：");
			try
			{
				valueNumber1 = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				valueNumber1 = 111;
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			Console.WriteLine("□ 请输入第 2 个数：");
			try
			{
				valueNumber2 = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				valueNumber2 = 222;
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			Console.WriteLine("□ 请输入第 3 个数：");
			try
			{
				valueNumber3 = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				valueNumber3 = 333;
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			cacheNumber1 = ( valueNumber1 > valueNumber2 )? valueNumber1 : valueNumber2;
			cacheNumber2 = ( valueNumber2 > valueNumber3 )? valueNumber2 : valueNumber3;
			cacheNumber  = ( cacheNumber1 > cacheNumber2 )? cacheNumber1 : cacheNumber2;

			Console.WriteLine("○ 在依次输入的三个数:" + valueNumber1 + "," + valueNumber2 + "," + valueNumber3 + "，中，值" + cacheNumber + "是最大的");
			#endregion

			Console.WriteLine("======== 习题 7  ========");
			#region 习题7 | 写一个程序接受用户输入的字符，如果输入的字符是0~9数字中的一个，则显示“您输入了一个数字”，否则显示“您输入的不是一个数字”
			int cache_userC7Input;
			char userC7Input;

			Console.WriteLine("请输入一个字符（超出要求会自动截断输入的内容）：");
			try
			{
				cache_userC7Input = Console.Read();
				userC7Input = (char)cache_userC7Input;
			}
			catch
			{
				userC7Input = '6';
				Console.WriteLine("× 输入了不合法的值，已自动填充该值");
			}

			if (userC7Input == '0' || userC7Input == '1' || userC7Input == '2' || userC7Input == '3' || userC7Input == '4' || userC7Input == '5' || userC7Input == '6' || userC7Input == '7' || userC7Input == '8' || userC7Input == '9' )
			{
				Console.WriteLine("○ 你输入的『 " + userC7Input + " 』是一个数字");
			}
			else
			{
				Console.WriteLine("○ 你输入的『 " + userC7Input + " 』不是个数字");
			}
			#endregion

			Console.WriteLine("======== 习题 8  ========");
			#region 习题8 | 提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”，并且密码是“8888“，则提示正确。否则，如果用户名不是admin还提示用户用户名不存在，如果用户名是admin则提示密码错误
			string userAcc  = "233";
			string userPass = "666";

			Console.WriteLine("■ 请输入用户名：");
			userAcc = Console.ReadLine();
			if (userAcc != "admin")
			{
				Console.WriteLine("× 你输入了：" + userAcc + "，你还可以尝试1次。");
				Console.WriteLine("□ 请输入用户名：");
			    userAcc = Console.ReadLine();
			}

			Console.WriteLine("■ 请输入密码：");
			userPass = Console.ReadLine();
			if (userPass != "8888")
			{
				Console.WriteLine("× 你输入了：" + userPass + "，你还可以尝试1次。");
				Console.WriteLine("□ 请输入密码：");
				userPass = Console.ReadLine();
			}
			
			if (userAcc == "admin")
			{
				if (userPass=="8888")
				{
					Console.WriteLine("○ 正确，登录成功");
				}
				else
				{
					Console.WriteLine("× 输入的密码不正确");
				}
			}
			else
			{
				Console.WriteLine("× 输入的用户名不存在");
			}
			#endregion

			Console.WriteLine("======== 习题 9  ========");
			#region 习题9 | 提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，则提示用户是否继续查看（yes.no），如果辅入的是yes则提示用户请查看，否则提示“退出”
			int userAge;
			string userAgreement;

			Console.WriteLine("□ 我们需要验视您的年龄，现在，请输入您的年龄：");
			try
			{
				userAge = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				userAge = 0;
				Console.WriteLine("× 输入了不合法的值，已自动放弃该值");
			}

			if ( userAge >= 18 )
			{
				Console.WriteLine("○ 验视成功，欢迎浏览！");
			}
			else if (userAge >= 13 && userAge < 18)
			{
				Console.WriteLine("■ 您真的要继续吗，请输入 yes 以继续");
				userAgreement = Console.ReadLine().ToLower();
				if ( userAgreement == "yes" )
				{
					Console.WriteLine("○ 验视成功，欢迎浏览！");
				}
				else
				{
					Console.WriteLine("× 验视失败，拒绝访问！");
				}
			}
			else
			{
				Console.WriteLine("× 验视失败，拒绝访问！");
			}
			#endregion
		}
	}
}
