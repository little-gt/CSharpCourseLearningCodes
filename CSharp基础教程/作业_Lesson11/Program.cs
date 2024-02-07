using System;

namespace 作业_Lesson11
{
	class Program
	{
		#region 递归函数计算阶乘
		static int Fun1(int num)
		{
			if (num == 1)
				return 1;
			return num * Fun1(num - 1);
		}
		#endregion

		#region 递归函数计算阶乘数列
		static int Fun2(int num)
		{
			if (num == 1)
				return 1;
			return Fun1(num) + Fun2(num - 1);
		}
		#endregion

		#region 每天砍竹竿问题
		static void Fun3(float length, int days = 0)
		{
			length /= 2;
			if (days == 10)
			{
				Console.WriteLine("第{0}天后，竹子长{1}米", days, length);
				return;
			}
			++days;
			Fun3(length, days);
		}
		#endregion

		#region 递归函数打印20~200
		static bool Fun4(int num)
		{
			Console.WriteLine(num);
			return num == 200 || Fun4(num + 1);
		}
		#endregion

		static void Main(string[] args)
		{
			Console.WriteLine(Fun1(5));
		}
	}
}
