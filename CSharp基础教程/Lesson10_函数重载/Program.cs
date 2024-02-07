namespace Lesson10_函数重载
{
	class Program
	{
		#region 知识点 1 | 基本概念
		/* 重载的概念
		 * 在任意同一个语句块(class或struct)中
		 * 1. 函数(方法)名称相同
		 * 2. 参数数量 或者 参数类型 或者 参数顺序 不相同
		 * 会进行函数重载
		 */

		// 作用：
		// 1. 命名一组功能相似的函数，减少函数名的数量，避免命名空间的污染
		// 2. 提升程序的可读性
		#endregion

		#region 知识点 2 | 示例
		/* 注意：
		 * 1. 重载和返回值类型无关，之和参数类型、个数、顺序有关
		 * 2. 调用时 程序会自动根据传入的参数类型进行判断，应该使用哪一个重载
		 */

		static int CalcSum(int a, int b)
		{
			return a + b;
		}

		// 1. 参数数量不同
		static int CalcSum(int a, int b, int c)
		{
			return a + b + c;
		}

		// 2. 数量相同 类型不同
		static float CalcSum(float a, float b)
		{
			return a + b;
		}
		static float CalcSum(int a, float b)
		{
			return a + b;
		}

		// 3. 数量相同 顺序不同
		static float CalcSum(float a, int b)
		{
			return a + b;
		}

		// 4. ref和out
		static float CalcSum(ref float f, int a)
		{
			f += a;
			return f;
		}

		// 5. params可变参数
		static float CalcSum(params float[] f)
		{
			float tempSum = 0f;
			for (int i = 0; i < f.Length; i++)
			{
				tempSum += f[i];
			}
			return tempSum;
		}
		#endregion

		static void Main(string[] args)
		{
		}
	}
}
