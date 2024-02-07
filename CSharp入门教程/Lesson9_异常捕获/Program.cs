using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_异常捕获
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 异常捕获 ======");

			#region 知识点1 | 异常捕获的作用
			/*  将玩家输入的内容存储到 checkString 容器中
			 *  异常捕获 | 如果对异常捕获的运用 可以 防止程序运行报错导致的程序无法运行
			 */
			//string checkString;
			//Console.WriteLine("您现在需要输入您的年龄：");
			//checkString = Console.ReadLine();
			#endregion

			#region 知识点2 | 基本语法
			/*  注意 |
			 *  代码块的结构中的{}最后 不用打; 哦！
			 */
			// 必须部分
			try
			{    //  希望 进行异常捕获 的代码块
				 //  说明 | 如果try中的代码 报错 会自动运行 catch中的代码 不会让程序卡死  
			}
			catch
			{  //  如果出错就会执行
			   //  说明 | catch(Exception e) 具体报错跟踪 通过e得到具体的错误信息

			}
			// 可选部分
			finally
			{  //  最后执行的代码 不管有没有出错 都会执行其中的代码
			   //  备注 | 目前暂用不到
			}
			#endregion

			#region 知识点3 | 实际
			try
			{
				int linePass_Sess1;
				Console.WriteLine("□ 请输入你分析得到的 整数 秘钥：");
				linePass_Sess1 = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("□ 哇啊啊，请务必输入 整数 秘钥！ ");
			}
			finally
			{
				Console.WriteLine("△ 嘿嘿，执行完毕啦！！！");
			}
			#endregion
		}
	}
}
