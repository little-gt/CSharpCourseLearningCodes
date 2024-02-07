using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson13
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 作业 · lesson 13 ======");

			#region 习题1 | 下面代码打印出来是什么？
			Console.WriteLine(true || true);  // true
			Console.WriteLine(false || true); // true
			Console.WriteLine(true && true);  // true
			Console.WriteLine(true && false); // false
			Console.WriteLine(!true);         // false
			#endregion

			#region 习题2 | 下面代码打印出来是什么？
			bool gameOver;
			bool isWin;
			int health = 100;
			gameOver = true;
			isWin = false;
			//              true      false      true
			Console.Write(gameOver || isWin && health > 0); // false
			#endregion
		}
	}
}
