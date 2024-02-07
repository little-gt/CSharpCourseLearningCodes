using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_选择排序
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 1 | 选择排序的基本原理
			// ===== 基本原理 =====
			//      新建中间商
			//       依次比较
			//  找出极值（最大或最小）
			//     放入目标位置
			//       比较n轮
			#endregion

			#region 知识点 2 | 代码实现
			// ===== 升序实现 =====
			int[] testArr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };

			// 第 5 步 | 比较m轮
			for (int m = 0; m < testArr.Length; m++)
			{
				// 第 1 步 | 申明一个中间商 来记录索引
				int index = 0;
				// 第 2 步 | 依次比较 ("-m" 的目的是排除上一轮已经比较过的值)
				for (int n = 1; n < testArr.Length - m; n++)
				{
					// 第 3 步 | 进行比较 找到最大值
					if (testArr[index] < testArr[n])
					{
						index = n;
					}
				}
				// 第 4 步 | 放入目标位置
				// Length - 1 - 轮数
				if (index != testArr.Length - 1 - m)
				{
					int temp = testArr[index];
					testArr[index] = testArr[testArr.Length - 1 - m];
					testArr[testArr.Length - 1 - m] = temp;
				}
			}
			#endregion
		}
	}
}
