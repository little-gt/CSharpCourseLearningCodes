using System;

namespace 作业_Lesson7
{
	class Program
	{
		#region 习题 1 函数 | 返回两个数当中的最大值
		static int CompareTwo(int a, int b)
		{
			if (a >= b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}
		#endregion

		#region 习题 2 函数 | 计算圆的周长和面积并且返回
		static float[] CalculateGraphicCircle(float r)
		{
			float circlePerimeter = r * 3.1415926f * 2f;
			float circleArea = r * r * 3.1415926f;
			return new float[] { circlePerimeter, circleArea };
		}
		#endregion

		#region 习题 3 函数 | 求一个数组的最大值、最小值、平均值和总和
		static int[] CalculateIntArraySynthesis(int[] inputArray)
		{
			// 求出最大值
			int arrayMax = inputArray[0];
			for (int i = 0; i < inputArray.Length; i++)
			{
				if (arrayMax <= inputArray[i])
				{
					arrayMax = inputArray[i];
				}
			}
			// 求出最小值
			int arrayMin = inputArray[0];
			for (int i = 0; i < inputArray.Length; i++)
			{
				if (arrayMin >= inputArray[i])
				{
					arrayMin = inputArray[i];
				}
			}
			// 求出总和
			int arraySum = 0;
			for (int i = 0; i < inputArray.Length; i++)
			{
				arraySum = arraySum + inputArray[i];
			}
			// 求出平均数
			int arrayAvg = arraySum / (inputArray.Length + 1);
			// 按顺序输出数据
			return new int[4] { arrayMax, arrayMin, arrayAvg, arraySum };
		}
		#endregion

		#region 习题 4 函数 | 判断传入值是否是质数(素数)
		static bool IsPrimeNumber(int inputNumber)
		{
			bool tempIsTure = true;
			// 循环检查是否有大于等于2的数可以整除它
			for (int i = 2; i < inputNumber; i++)
			{
				if (inputNumber % i == 0)
				{
					i = inputNumber;
					tempIsTure = false;
				}
			}
			// 输出结果
			return tempIsTure;
		}
		#endregion

		#region 习题 5 | 判断年份是否为闰年
		static bool IsLeapYear(int inputYear)
		{
			bool tempIsTrue = false;
			// 年份能被400整除（2000）
			if (inputYear % 400 == 0)
			{
				tempIsTrue = true;
			}
			// 年份能被4整除，但是不能被100整除（2008）
			if (inputYear % 400 == 0 && inputYear % 100 != 100)
			{
				tempIsTrue = true;
			}
			return tempIsTrue;
		}
		#endregion

		#region 程序暂停
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
			Console.Clear();

			int temp_a, temp_b; // 习题 1 的暂存变量
			int tempNumber;
			float[] tempArrayFloat;
			int[] tempArrayInt;
			int[] resultArrayInt;
			Random random = new Random();

			#region 习题 1 |
			// 要求输入第一个数
			do
			{
				try
				{
					Console.WriteLine("====== -| 习题 1 |- ======");
					Console.WriteLine("■ 请输入一个整数：");
					temp_a = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× 请重新输入一个正确的整数！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (true);
			Console.Clear();
			// 要求输入第二个数
			do
			{
				try
				{
					Console.WriteLine("====== -| 习题 1 |- ======");
					Console.WriteLine("■ 请输入再一个整数：");
					temp_b = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× 请重新输入一个正确的整数！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (true);
			// 输出两个数当中较大的一个
			Console.Clear();
			Console.WriteLine("====== -| 习题 1 |- ======");
			Console.WriteLine("□ 你输入的两个数中，较大的一个是：{0}", CompareTwo(temp_a, temp_b));
			#endregion

			ProgramPause();

			#region 习题 2 |
			// 要求输入圆的半径
			do
			{
				Console.WriteLine("====== -| 习题 2 |- ======");
				Console.WriteLine("■ 请输入圆的整数半径：");
				try
				{
					tempNumber = Convert.ToInt32(Console.ReadLine());
					if (tempNumber <= 0)
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("× 圆的半径应该是一个正整数！");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						break;
					}
				}
				catch (Exception)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× 圆的半径不合法！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (true);
			// 输出结果
			Console.Clear();
			tempArrayFloat = CalculateGraphicCircle(tempNumber);
			Console.WriteLine("====== -| 习题 2 |- ======");
			Console.WriteLine("□ 半径为：{0}的圆，周长为：{1}，面积为：{2}", tempNumber, tempArrayFloat[0], tempArrayFloat[1]);
			#endregion

			ProgramPause();

			#region 习题 3 |
			// 要求输入一个整数
			do
			{
				Console.WriteLine("====== -| 习题 3 |- ======");
				Console.WriteLine("■ 请输入一个整数：");
				try
				{
					tempNumber = Convert.ToInt32(Console.ReadLine());
					if (tempNumber <= 0)
					{
						tempNumber = -tempNumber;
						break;
					}
					else
					{
						break;
					}
				}
				catch (Exception)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× 输入的整数不合法！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (true);
			// 判断是否是质数
			Console.Clear();
			if (IsPrimeNumber(tempNumber))
			{
				Console.WriteLine("====== -| 习题 3 |- ======");
				Console.WriteLine("□ 你输入的整数是质数.");
			}
			else
			{
				Console.WriteLine("====== -| 习题 3 |- ======");
				Console.WriteLine("□ 你输入的整数不是质数.");
			}
			#endregion

			ProgramPause();

			#region 习题 4 |
			// 要求输入一个年份
			do
			{
				Console.WriteLine("====== -| 习题 4 |- ======");
				Console.WriteLine("■ 请输入一个年份(年份应该大于0)：");
				try
				{
					tempNumber = Convert.ToInt32(Console.ReadLine());
					if (tempNumber <= 0)
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("× 年份应该是一个正整数！");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						break;
					}
				}
				catch (Exception)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× 年份不合法！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (true);
			// 输出结果
			Console.Clear();
			if (IsLeapYear(tempNumber))
			{
				Console.WriteLine("====== -| 习题 4 |- ======");
				Console.WriteLine("■ 你输入的年份({0})是闰年.", tempNumber);
			}
			else
			{
				Console.WriteLine("====== -| 习题 4 |- ======");
				Console.WriteLine("■ 你输入的年份({0})是平年.", tempNumber);
			}
			#endregion

			ProgramPause();

			#region 习题 5 |
			// 要求输入一个年份
			do
			{
				Console.WriteLine("====== -| 习题 5 |- ======");
				Console.WriteLine("■ 请输入要随机生成的数组的长度(需为一个正整数)：");
				try
				{
					tempNumber = Convert.ToInt32(Console.ReadLine());
					if (tempNumber <= 0)
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("× 数组长度应该是一个正整数！");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						break;
					}
				}
				catch (Exception)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("× 数组长度不合法！");
					Console.ForegroundColor = ConsoleColor.White;
				}
			} while (true);
			// 输出结果
			Console.Clear();
			Console.WriteLine("====== -| 习题 5 |- ======");
			// 输出随机生成的数组
			Console.ForegroundColor = ConsoleColor.DarkGray;
			tempArrayInt = new int[tempNumber];
			for (int i = 0; i < tempArrayInt.Length; i++)
			{
				tempArrayInt[i] = random.Next(10, 100);
				Console.Write(tempArrayInt[i] + " ");
			}
			Console.ForegroundColor = ConsoleColor.White;
			// 输出要求
			resultArrayInt = CalculateIntArraySynthesis(tempArrayInt);
			Console.WriteLine();
			Console.WriteLine("□ 上面的数组中，最大值为:{0}，最小值为:{1}，平均数为:{2}，总和为:{3}", resultArrayInt[0], resultArrayInt[1], resultArrayInt[2], resultArrayInt[3]);
			#endregion

			ProgramPause();

			Console.WriteLine("====== -| END |- ======");
		}
	}
}
