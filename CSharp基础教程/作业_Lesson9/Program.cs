using System;

namespace 作业_Lesson9
{
	class Program
	{
		#region 功能 1 | 计算和、平均数
		static int[] CalculateAvg(params int[] tempArray)
		{
			int tempSum = 0;
			int tempAvg = 0;
			for (int i = 0; i < tempArray.Length; i++)
			{
				tempSum += tempArray[i];
			}
			tempAvg = tempSum / (tempArray.Length + 1);
			return new int[] { tempSum, tempAvg };
		}
		#endregion

		#region 功能 2 | 多个数字的奇数和偶数和
		static int[] CalculateSumDif(params int[] tempArray)
		{
			int tempSumOdd = 0;  //奇数和
			int tempSumEven = 0; //偶数和
			for (int i = 0; i < tempArray.Length; i++)
			{
				if (tempArray[i] % 2 != 0)
				{
					tempSumOdd += tempArray[i];
				}
				else
				{
					tempSumEven += tempArray[i];
				}
			}
			return new int[] { tempSumOdd, tempSumEven };
		}
		#endregion

		#region 特殊 | 程序暂停
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

		}
	}
}
