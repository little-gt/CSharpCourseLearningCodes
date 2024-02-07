using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson10
{
	#region 自定义类 | 二维位置
	/*
	 * 	定义一个位置结构体或类，为其重载判断是否相等的运算符
     *  (×1,y1)==(×2,y2)=>两个值同时相等才为true
     *  
	 */
	class Position2D
	{
		int x;
		int y;

		public static bool operator ==(Position2D p1, Position2D p2)
		{
			if (p1.x == p2.x && p1.y == p2.y)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool operator !=(Position2D p1, Position2D p2)
		{
			if (p1.x == p2.x && p1.y == p2.y)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
	#endregion

	#region 自定义类 | 三维坐标
	/*
	 * 	定义一个Vector3类(x,y,z)通过重载运算符实现以下运算
	 * 	(×1,y1,z1) + (×2,y2,z2) = (×1+×2,y1+y2,z1+z2)
	 * 	(×1,y1,z1) - (×2,y2,z2) = (×1-×2,y1-y2,z1-z2)
	 * 	(x1,y1,z1) * num = (x1*num,y1*num,z1*num)
	 * 	
	 */
	class Position3D
	{
		int x;
		int y;
		int z;

		public static Position3D operator +(Position3D p1, Position3D p2)
		{
			Position3D p = new Position3D();
			p.x = p1.x + p2.x;
			p.y = p1.y + p2.y;
			p.z = p1.z + p2.z;
			return p;
		}

		public static Position3D operator -(Position3D p1, Position3D p2)
		{
			Position3D p = new Position3D();
			p.x = p1.x - p2.x;
			p.y = p1.y - p2.y;
			p.z = p1.z - p2.z;
			return p;
		}

		public static Position3D operator *(Position3D p, int i)
		{
			p.x = i * p.x;
			p.y = i * p.y;
			p.z = i * p.z;
			return p;
		}

		public static int operator *(Position3D p1, Position3D p2)
		{
			return p1.x * p2.x + p1.y + p2.y + p1.z * p2.z;
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
