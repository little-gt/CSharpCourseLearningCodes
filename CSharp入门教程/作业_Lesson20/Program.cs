using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson20
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			/* --- 分 --- 割 --- 线 */

			Console.WriteLine("======== Exercise 1 ========");
			Console.WriteLine("□ Please press any key to start executing the program for the first question.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("======== Exercise 1 ========");
			Console.WriteLine("■ The program will print integers from 1 to 100 below.");
			#region 习题 1 | 输出从1到100之间的整数（包括本身）
			for (int i = 1; i <= 100; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			#endregion
			Console.WriteLine("□ Please press any key to exit the program for the first question.");
			Console.ReadKey();
			Console.Clear();

			/* --- 分 --- 割 --- 线 */

			Console.WriteLine("======== Exercise 2 ========");
			Console.WriteLine("□ Please press any key to start executing the program for the second question.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("======== Exercise 2 ========");
			Console.WriteLine("■ The program will print the calculation formula for the sum of all even numbers from 1 to 100 below.");
			#region 习题 2 | 求出1~100中所有偶数的和
			string tempString = "1";
			int tempTotal = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					tempTotal = tempTotal + i;
					if ( 1 < i )
					{
						tempString += " + " + i;
					}
				}
			}
			Console.WriteLine(tempString + " = " + tempTotal);
			#endregion
			Console.WriteLine("□ Please press any key to exit the program for the second question.");
			Console.ReadKey();
			Console.Clear();

			/* --- 分 --- 割 --- 线 */

			Console.WriteLine("======== Exercise 3 ========");
			Console.WriteLine("□ Please press any key to start executing the program for the third question.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("======== Exercise 3 ========");
			Console.WriteLine("■ The program will print all Narcissistic number numbers from 100 to 999 below.");
			#region 习题 3 | 找出100~900之间的水仙花数
			int tempNumber1 , tempNumber2 , tempNumber3;
			tempString = "";
			for (int i = 100; i <= 999; i++)
			{
				tempNumber1 = i / 100;     //取出数字的百位
				tempNumber2 = i / 10 % 10; //取出数字的十位
				tempNumber3 = i % 10;      //取出数字的个位

				tempTotal = tempNumber1 * tempNumber1 * tempNumber1 + tempNumber2 * tempNumber2 * tempNumber2 + tempNumber3 * tempNumber3 * tempNumber3;

				if (i == tempTotal)
				{
					tempString = tempNumber1 + "×" + tempNumber1 +"×" + tempNumber1 + " + " + tempNumber2 + "×" + tempNumber2 + "×" + tempNumber2 + " + " + tempNumber3 + "×" + tempNumber3 + "×" + tempNumber3 + " = " + i;
					Console.WriteLine(tempString);
				}
			}
			#endregion
			Console.WriteLine("□ Please press any key to exit the program for the third question.");
			Console.ReadKey();
			Console.Clear();

			/* --- 分 --- 割 --- 线 */

			Console.WriteLine("======== Exercise 4 ========");
			Console.WriteLine("□ Please press any key to start executing the program for the 4th question.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("======== Exercise 4 ========");
			Console.WriteLine("■ The program will print the nine-nine table below.");
			#region 习题 4 | 九九乘法表
			// 乘法表可以看为 y × i = z
			// 在换行时 y = i
			for (int i = 1; i < 10; i++)
			{
				for (int y = 1; y <= i; y++)
				{
					Console.Write("{0}×{1}={2}\t", y, i, y * i);
				}
				Console.WriteLine(); // 一行打印完成 换行
			}
			#endregion
			Console.WriteLine("□ Please press any key to exit the program for the 4th question.");
			Console.ReadKey();
			Console.Clear();

			/* --- 分 --- 割 --- 线 */

			Console.WriteLine("======== Exercise 5 ========");
			Console.WriteLine("□ Please press any key to start executing the program for the 4th question.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("======== Exercise 5 ========");
			#region 习题 5 | 输出空心正方形
			Console.WriteLine("□ You need to enter a positive integer to let the program start building a square (alignment may not be possible due to font issues):");
			int squareSize;
			try
			{
				squareSize = Convert.ToInt32(Console.ReadLine());
				if (squareSize <= 0)
				{
					squareSize = 10;
					Console.WriteLine("× The number you entered does not meet the requirements, and the default value (10) has been automatically selected.");
				}
			}
			catch (Exception)
			{
				squareSize = 10;
				Console.WriteLine("× The number you entered does not meet the requirements, and the default value (10) has been automatically selected.");
			}
			Console.WriteLine("■ The program will print " + squareSize + " × " + squareSize + " infantry square below.");

			for (int h = 0; h < squareSize; h++)
			{
				if (h == 0)
				{
					// 输出 第一行
					for (int i = 0; i < squareSize; i++)
					{
						Console.Write("□");
					}
					Console.WriteLine();
					continue;
				}
				if (h == squareSize - 1)
				{
					// 输出 最后一行
					for (int i = 0; i < squareSize; i++)
					{
						Console.Write("□");
					}
					Console.WriteLine();
					break;
				}

				Console.Write("□");
				for (int i = 0; i < squareSize - 2; i++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("□");
			}

			#endregion
			Console.WriteLine("□ Please press any key to exit the program for the 5th question.");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
