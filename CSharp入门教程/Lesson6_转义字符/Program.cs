using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_转义字符
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("第六课 转义字符");
			#region 知识点1 | 转义字符的使用
			// 转义字符 | 它是字符串的一部分 用来表示一些有特殊含义的字符
			// 特殊含义 | 单引号 双引号 换行符等

			/* 固定写法 |
			 * 不同的 \和字符的组合 表示不同的含义
			 */
			string strZhuanYiZiFu;

			//常用转义字符
			//单引号 \'
			strZhuanYiZiFu = "这是单引号：\'";
			Console.WriteLine(strZhuanYiZiFu);
			//双引号 \"
			strZhuanYiZiFu = "这是双引号：\"";
			Console.WriteLine(strZhuanYiZiFu);
			//换行   \n
			strZhuanYiZiFu = "这是换行符：\n你看，转行了吧~";
			Console.WriteLine(strZhuanYiZiFu);
			//斜杠   \\
			strZhuanYiZiFu = "这是斜杠：\\";
			Console.WriteLine(strZhuanYiZiFu);

			//不常用转义字符
			//制表符(空一个tab键)
			strZhuanYiZiFu = "这是制表符：0\t0";
			Console.WriteLine(strZhuanYiZiFu);
			//光标退格
			strZhuanYiZiFu = "这是光标退格：■□■□■□\b■□■□■□■";
			Console.WriteLine(strZhuanYiZiFu);
			//空字符
			strZhuanYiZiFu = "这是空字符：\0咕\0咕\0咕...";
			Console.WriteLine(strZhuanYiZiFu);
			//警报音
			strZhuanYiZiFu = "这是警报音：\a叮\a叮\a叮...";
			Console.WriteLine(strZhuanYiZiFu);
			#endregion

			#region 知识点2 | 取消转义字符
			//取消转义字符就在前面加一个@符号 具体如下
			string strQvXiaoZhuanYi = @"0000/a0000";
			Console.WriteLine(strQvXiaoZhuanYi);
			#endregion

		}
	}
}
