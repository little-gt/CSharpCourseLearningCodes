using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson12
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 习题1 | 打印的结果是什么？
			bool boo = true;
			Console.WriteLine(boo != true);
			Console.WriteLine(10 == 10);
            Console.WriteLine(10 > 20);
            Console.WriteLine(10 <= 20);
			Console.WriteLine(10 <= 10);
			#endregion

			#region 习题2 | 问游戏开始得了吗？
			bool gameOver, startGame;
			int a = 10, b = 15;
			gameOver = a > (b - 5);
			startGame = gameOver == (b > (a + 5));
			Console.WriteLine("startGame: " + startGame);
			#endregion
		}
	}
}
