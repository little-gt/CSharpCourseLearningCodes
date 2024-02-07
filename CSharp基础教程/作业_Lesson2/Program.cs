using System;

namespace 作业_Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			// 初始化随机数生成
			Random random = new Random();
			// 初始化长度为 100 的整形数组
			int[] testArrayInt1 = new int[100];
			int[] testArrayA = new int[25];
			int[] testArrayB = new int[25];
			// 初始化长度为 10  的整形数组
			int[] testArrayInt2 = new int[10];
			// 初始化长度为 25  的字符串数组
			string[] testArrayStr = new string[25];

			#region 习题 1 |
			Console.WriteLine("======== 习题 1 | 为一维数组赋值，且值和下标一致 ========");
			// 对数组进行随机数赋值
			for (int i = 0; i < testArrayInt1.Length; i++)
			{
				testArrayInt1[i] = i;
				Console.WriteLine("testArrayInt1[{0}] = {1}", i, testArrayInt1[i]);
			}
			// 输出数组长度
			Console.WriteLine("testArrayInt1 的长度为：" + testArrayInt1.Length);
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion

			#region 习题 2 |
			Console.WriteLine("======== 习题 2 | 将数组A的值乘以2之后存入数组B ========");
			// 将为数组A输入随机数的值
			Console.WriteLine("##### 数组 A #####");
			for (int i = 0; i < testArrayA.Length; i++)
			{
				testArrayA[i] = random.Next(0, 234);
				Console.WriteLine("testArrayA[{0}] = {1}", i, testArrayA[i]);
			}
			// 将数组A的值乘以2输入数组B
			Console.WriteLine("##### 数组 B #####");
			for (int i = 0; i < testArrayB.Length; i++)
			{
				testArrayB[i] = testArrayA[i] * 2;
				Console.WriteLine("testArrayB[{0}] = {1}", i, testArrayB[i]);
			}
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion

			#region 习题 3 |
			Console.WriteLine("======== 习题 3 | 随机（0~100）生成1个长度为10的整数数组 ========");
			// 将随机数值赋值到数组中
			for (int i = 0; i < testArrayInt2.Length; i++)
			{
				testArrayInt2[i] = random.Next(1, 101);
				Console.WriteLine("testArrayInt2[{0}] = {1}", i, testArrayInt2[i]);
			}
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion

			#region 习题 4 |
			Console.WriteLine("======== 习题 4 | 从一个整数数组中找出最大值、最小值、总合、平均值 ========");
			// 定义储存 最大值的容器 和 最大值下标序号 
			int testArrayMAX, testArrayMIN;
			int xvhaoMAX, xvhaoMIN;
			int totalAll = 0, totalAva = 0;
			// 刷新数组的值
			for (int i = 0; i < testArrayInt1.Length; i++)
			{
				testArrayInt1[i] = random.Next(0, 234);
				Console.WriteLine("testArrayInt1[{0}] = {1}", i, testArrayInt1[i]);
			}
			// 初始化比较容器
			testArrayMAX = testArrayInt1[0];
			testArrayMIN = testArrayInt1[0];
			xvhaoMAX = 0;
			xvhaoMIN = 0;
			// 开始比较最大值和最小值
			for (int i = 0; i < testArrayInt1.Length; i++)
			{
				if (testArrayMAX < testArrayInt1[i])
				{
					xvhaoMAX = i;
					testArrayMAX = testArrayInt1[i];
				}
				if (testArrayMIN > testArrayInt1[i])
				{
					xvhaoMIN = i;
					testArrayMIN = testArrayInt1[i];
				}
				totalAll += testArrayInt1[i];
			}
			totalAva = totalAll / testArrayInt1.Length;
			Console.WriteLine("testArrayInt1[{0}]是testArrayInt1中的[最大值]为：{1}", xvhaoMAX, testArrayMAX);
			Console.WriteLine("testArrayInt1[{0}]是testArrayInt1中的[最小值]为：{1}", xvhaoMIN, testArrayMIN);
			Console.WriteLine("数组testArrayInt1的平均数为：{0}，合计为：{1}", totalAva, totalAll);
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion

			#region 习题 5 |
			Console.WriteLine("======== 习题 5 | 交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印 ========");
			// 将数组A和数组B的内容清空，并且将随机数赋值给数组A
			for (int i = 0; i < testArrayA.Length; i++)
			{
				testArrayA[i] = random.Next(0, 234);
				testArrayB[i] = 0;
			}
			// 反向赋值
			for (int i = testArrayA.Length - 1; i >= 0; i--)
			{
				int j = testArrayB.Length - 1 - i;
				testArrayB[j] = testArrayA[i];
				Console.WriteLine("testArrayA[{0}] = {1} | testArrayB[{2}] = {3}", i, testArrayA[i], j, testArrayB[j]);
			}
			// 将数组B的值赋值给数组A完成反转
			testArrayA = testArrayB;
			for (int i = 0; i < testArrayA.Length; i++)
			{
				Console.WriteLine("testArrayA[{0}] = {1}", i, testArrayA[i]);
			}
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion

			#region 习题 6 |
			Console.WriteLine("======== 习题 6 | 对数据按照一定规则进行处理 ========");
			for (int i = 0; i < testArrayA.Length; i++)
			{
				testArrayA[i] = random.Next(-100, 101);
				Console.Write("testArray[{0}] = {1}", i, testArrayA[i]);
				// 处理数组A中的值，并且规则如下：
				/*  1. 如果元素是正数则将这个位置的元素值加1；
				 *  2. 如果元素是负数则将这个位置的元素值减1；
				 *  3. 如果元素是0，则不变
				 */
				if (testArrayA[i] > 0)
				{
					testArrayA[i] += 1;
				}
				if (testArrayA[i] < 0)
				{
					testArrayA[i] -= 1;
				}
				Console.WriteLine(" ——> testArrayA[{0}] = {1}", i, testArrayA[i]);
			}
			Console.WriteLine("======== ☆ 按下任意键进入下一题的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion

			#region 习题 7 |
			Console.WriteLine("======== 习题 7 | 对数据按照一定规则进行处理 ========");
			// 使用for循环对string数组赋值
			for (int i = 0; i < testArrayStr.Length; i++)
			{
				if (i % 2 == 0)
				{
					testArrayStr[i] = "■";
				}
				if (i % 2 == 1)
				{
					testArrayStr[i] = "□";
				}
			}
			// 输出要求的方阵
			int tempI = 0;
			for (int i = 0; i < testArrayStr.Length; i++)
			{
				Console.Write(testArrayStr[i]);
				tempI++;
				if (tempI >= 5)
				{
					Console.WriteLine();
					tempI = 0;
				}
			}
			Console.WriteLine("======== ☆ 按下任意键结束所有题目的程序 ☆ ========");
			Console.ReadKey(true);
			Console.WriteLine();
			#endregion
		}
	}
}
