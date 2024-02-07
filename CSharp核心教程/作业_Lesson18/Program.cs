using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson18
{
	// 习题 1 |
	// 写一个动物抽象类，然后再写三个子类(人、狗、猫)
	// 再实现人叫、狗叫、猫叫的方法
	#region 类集 | 动物
	public abstract class Animal
	{
		public abstract void Shout();
	}

	#region 类 | 人
	public class Human : Animal
	{
		public override void Shout()
		{
			Console.WriteLine("人叫");
		}
	}
	#endregion

	#region 类 | 狗
	public class Dog : Animal
	{
		public override void Shout()
		{
			Console.WriteLine("狗叫");
		}
	}
	#endregion

	#region 类 | 猫
	public class Cat : Animal
	{
		public override void Shout()
		{
			Console.WriteLine("猫叫");
		}
	}
	#endregion

	#endregion

	// 习题 2 |
	// 创建一个图形类，有求面积和周长两个方法:
	// 所创建矩形类，正方形类，圆形类继承图形类
	// 实例化矩形、正方形、圆形对象求面积和周长
	#region 类集 | 图形
	public abstract class Depiction
	{
		/// <summary>
		/// 求面积
		/// </summary>
		/// <returns></returns>
		public abstract float RequestArea();

		/// <summary>
		/// 求周长
		/// </summary>
		/// <returns></returns>
		public abstract float RequestPerimeter();
	}

	#region 类 | 矩形类
	public class DRectangle : Depiction
	{
		/// <summary>
		/// 长
		/// </summary>
		public float length;
		/// <summary>
		/// 宽
		/// </summary>
		public float widths;

		/// <summary>
		/// 初始化矩形 | 较长的边长将赋值给长，较短的边长将赋值给宽
		/// </summary>
		/// <param name="x">矩形的边长 1</param>
		/// <param name="y">矩形的边长 2</param>
		public DRectangle(float x,float y)
		{
			if (x >= y)
			{
				length = x;
				widths = y;
			}
			else
			{
				length = y;
				widths = x;
			}
		}

		/// <summary>
		/// 求面积
		/// </summary>
		/// <returns></returns>
		public override float RequestArea()
		{
			return length * widths;
		}

		/// <summary>
		/// 求周长
		/// </summary>
		/// <returns></returns>
		public override float RequestPerimeter()
		{
			return 2 * length + 2 * widths;
		}
	}
	#endregion

	#region 类 | 正方形类
	public class DSquare : Depiction
	{
		/// <summary>
		/// 边长
		/// </summary>
		public float length;

		/// <summary>
		/// 初始化正方形 | 赋值正方形的边长
		/// </summary>
		/// <param name="length">正方形的边长</param>
		public DSquare(float length)
		{
			this.length = length;
		}

		/// <summary>
		/// 求面积
		/// </summary>
		/// <returns></returns>
		public override float RequestArea()
		{
			return length * length;
		}

		/// <summary>
		/// 求周长
		/// </summary>
		/// <returns></returns>
		public override float RequestPerimeter()
		{
			return 4 * length;
		}
	}
	#endregion

	#region 类 | 圆形
	public class DOrbicular : Depiction
	{
		/// <summary>
		/// 半径
		/// </summary>
		public float radius;
		/// <summary>
		/// 常量 π ( 3.1415926 )
		/// </summary>
		public const float π = 3.1415926f;

		/// <summary>
		/// 初始化圆形 | 赋值圆形的半径
		/// </summary>
		/// <param name="radius">半径</param>
		public DOrbicular(float radius)
		{
			this.radius = radius;
		}

		/// <summary>
		/// 求面积
		/// </summary>
		/// <returns></returns>
		public override float RequestArea()
		{
			return π * radius * radius;
		}

		/// <summary>
		/// 求周长
		/// </summary>
		/// <returns></returns>
		public override float RequestPerimeter()
		{
			return 2 * π * radius;
		}
	}
	#endregion

	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			DRectangle dRectangle = new DRectangle(10f, 15f);
			DSquare dSquare = new DSquare(15f);
			DOrbicular dOrbicular = new DOrbicular(15f);

			Console.WriteLine("矩形面积：" + dRectangle.RequestArea());
			Console.WriteLine("矩形周长：" + dRectangle.RequestPerimeter());

			Console.WriteLine("正方形面积：" + dSquare.RequestArea());
			Console.WriteLine("正方形周长：" + dSquare.RequestPerimeter());

			Console.WriteLine("圆形面积：" + dOrbicular.RequestArea());
			Console.WriteLine("圆形周长：" + dOrbicular.RequestPerimeter());
		}
	}
}
