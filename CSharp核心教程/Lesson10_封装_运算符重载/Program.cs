using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_封装_运算符重载
{
	#region 知识点 1 | 基本概念
	// 概念 |
	// 让自定义类和结构体，能够使用运算符

	// 使用关键字 |
	// operator

	// 特点 |
	// 1. 一定是一个公共的静态方法
	// 2. 返回值写在operator之前
	// 3. 运算逻辑处理是自定义的

	// 作用 |
	// 让自定义的类和结构体对象可以进行运算

	// 注意 |
	// 1. 条件运算符需要成对实现
	// 2. 一个符号可以多次重载
	// 3. 不能使用 ref 和 out
	#endregion

	#region 知识点 2 | 基本语法
	// public static 返回类型 operator 运算符(参数列表)
	// {
	//        // 自定义的运算逻辑代码
	// }
	#endregion

	#region 知识点 3 | 实例
	class Point
	{
		public int x;
		public int y;

		public Point()
		{
			x = 0;
			y = 0;
		}

		public Point(int valueX, int valueY)
		{
			x = valueX;
			y = valueY;
		}

		public static Point operator +(Point p1, int i)
		{
			Point p = new Point();
			p.x += i;
			p.y += i;
			return p;
		}

		#region 知识点 4 | 可重载的运算符
		// START | 可重载运算符
		#region 类型 1 | 算数运算符
		// 注意：符号需要两个参数还是一个参数
		// + - * / % 两个参数；++ -- 一个参数
		public static Point operator +(Point p1, Point p2)
		{
			Point p = new Point();
			p.x = p1.x + p2.x;
			p.y = p1.y + p2.y;
			return p;
		}
		public static Point operator -(Point p1, Point p2)
		{
			Point p = new Point();
			p.x = p1.x - p2.x;
			p.y = p1.y - p2.y;
			return p;
		}
		public static Point operator *(Point p1, Point p2)
		{
			Point p = new Point();
			p.x = p1.x * p2.x;
			p.y = p1.y * p2.y;
			return p;
		}
		public static Point operator /(Point p1, Point p2)
		{
			Point p = new Point();
			p.x = p1.x / p2.x;
			p.y = p1.y / p2.y;
			return p;
		}
		public static Point operator %(Point p1, Point p2)
		{
			Point p = new Point();
			p.x = p1.x % p2.x;
			p.y = p1.y % p2.y;
			return p;
		}
		public static Point operator ++(Point p)
		{
			p.x = p.x + 1;
			p.y = p.y + 1;
			return p;
		}
		public static Point operator --(Point p)
		{
			p.x = p.x - 1;
			p.y = p.y - 1;
			return p;
		}
		#endregion

		#region 类型 2 | 逻辑运算符
		// 注意：符号只能是 ! 非运算符
		public static bool operator !(Point p)
		{
			bool valueBool1;
			bool valueBool2;
			bool valueResult;
			// 检查x的正负
			if (p.x >= 0){valueBool1 = true;}else{valueBool1 = false;}
			// 检查y的正负
			if (p.y >= 0){valueBool2 = true;}else{valueBool2 = false;}
			// 返回正负值
			if (valueBool1 = valueBool2)
			{
				valueResult = true;
			}
			else
			{
				valueResult = false;
			}

			return valueResult;
		}
		#endregion

		#region 类型 3 | 位运算符
		// 注意：符号需要两个参数还是一个参数
		// | & ^ << >> 两个参数；~ 一个参数
		public static Point operator ~(Point p)
		{
			p.x = -1 * p.x;
			p.y = -1 * p.y;
			return p;
		}
		#endregion

		#region 类型 4 | 条件运算符
		// 注意：
		// 1.返回值一般是bool值，也可以是其他的；
		// 2.相关符号必须要配对(成对)实现。
		// 成对匹配的符号(<,>)、(<=,>=)、!=
		public static bool operator >(Point p1, Point p2)
		{
			int valueLengthP1 = p1.x ^ 2 + p1.y ^ 2;
			int valueLengthP2 = p2.x ^ 2 + p2.y ^ 2;

			if (valueLengthP1 > valueLengthP2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator <(Point p1, Point p2)
		{
			int valueLengthP1 = p1.x ^ 2 + p1.y ^ 2;
			int valueLengthP2 = p2.x ^ 2 + p2.y ^ 2;

			if (valueLengthP1 < valueLengthP2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion
		// END | 可重载运算符
		#endregion

		#region 知识点 5 | 不可重载的运算符
		// 逻辑运算符与(&&) 或(||)
		// 强转运算符()
		// 特殊运算符点.    三目运算符? ：     赋值符号=
		// 索引器 []
		#endregion

	}
	#endregion
	class Program
	{
		static void Main(string[] args)
		{
			Point resultP = new Point(0,0);
			Point p1 = new Point(5,2);
			Point p2 = new Point(6,7);

			resultP = p1 + p2;
			Console.WriteLine("({0},{1})", resultP.x, resultP.y);

			resultP = p1 - p2;
			Console.WriteLine("({0},{1})", resultP.x, resultP.y);
		}
	}

	#region 总结 |
	// 关键字 |
	// operator

	// 固定语法 |
	// public static 返回值 operator 运算符(参数列表)
	// {
	//      // 自定义运算逻辑
	// }

	// 作用 |
	// 让子弟定义类或结构体对象 进行运算

	// 注意 |
	// 1. 参数的数量要符合运算符原始逻辑；
	// 2. 条件运算符需要配对才能实现；
	// 3. 一个符号可以多个重载；
	// 4. 不可以使用 ref 和 out。
	#endregion
}
