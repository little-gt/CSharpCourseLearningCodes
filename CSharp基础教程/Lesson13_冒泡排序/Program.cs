namespace Lesson13_冒泡排序
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 1 | 排序的基本概念
			// 排序是计算机内经常进行的一种操作，其目的是将一组"无序"的记录序列调整为"有序"的记录序列
			// 常用的排序例子
			// 无序 ——> 8 7 1 5 4 2 6 3 9
			// 把上面这个无序序列变为有序(升序或者降序)序列的过程
			// 升序 ——> 1 2 3 4 5 6 7 8 9
			// 降序 ——> 9 8 7 6 5 4 3 2 1
			// 就叫做排序

			// 在程序中 序列一般存储在 数组中
			// 所以 排序往往是 对数组进行排序
			int[] testArray = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
			// 把数组里面的内容 变为有序
			#endregion

			#region 知识点 2 | 冒泡排序基本原理
			// ===== 基本原理 =====
			//       两两相邻
			//       不停比较
			//       不停交换
			//       比较n轮
			#endregion

			#region 知识点 3 | 代码实现
			// 最基本的实现逻辑

			// 第三步 | 重复执行n轮
			for (int n = 0; n < testArray.Length; n++)
			{
				// 第一步 | 如何比较数组中两两相邻的数
				// 从头开始 第i个数和第i+1个数进行比较
				for (int i = 0; i < testArray.Length - 1; i++)
				{
					// 如果 第i个数 比 第i+1个数 大 就交换他们的位置
					if (testArray[i] > testArray[i + 1])
					{
						// 第二步 | 交换位置
						int temp = testArray[i + 1];
						testArray[i + 1] = testArray[i];
						testArray[i] = temp;
					}
				}
			}

			testArray = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };

			// 优化以后算法逻辑
			// 1. 重复执行浪费算力
			// 2. 不能判断是否已经排序完成
			// 优化 | 每执行一次，最后n个数其实已经排序好了，不用再去比较
			for (int n = 0; n < testArray.Length; n++)
			{
				// 优化 | 创建一个bool变量 记录是否交换过值
				bool isRan = false;
				// 第一步 | 如何比较数组中两两相邻的数
				// 从头开始 第i个数和第i+1个数进行比较
				for (int i = 0; i < testArray.Length - 1 - n; i++)
				{
					// 如果 第i个数 比 第i+1个数 大 就交换他们的位置
					if (testArray[i] > testArray[i + 1])
					{
						// 第二步 | 交换位置
						int temp = testArray[i + 1];
						testArray[i + 1] = testArray[i];
						testArray[i] = temp;
						// 执行了交换 对bool变量进行赋值
						isRan = true;
					}
				}
				// 如果没有执行交换 说明已经完成排序 直接退出循环
				if (!isRan)
				{
					break;
				}
			}
			#endregion
		}
	}
}
