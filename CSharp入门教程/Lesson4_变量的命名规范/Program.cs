using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_变量的命名规范
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("第四课 变量的命名规则");
			// c#对大小写敏感 区分命名的大小写 区分函数的大小写

			#region 知识点1 | 必须要遵守的规则
			Console.WriteLine("========== 知识点1 ==========");
			Console.WriteLine("1. 不能重名；");
			Console.WriteLine("2. 不能使用数字作为开头；");
			Console.WriteLine("3. 不能使用程序关键字；");
			Console.WriteLine("4. 不能使用特殊符号（下划线_除外）。");
			// 建议的命名规则：
			// √ 变量名要有含义 | 用英文(或拼音)表示变量的含义
			// 非常不建议的命名规则：
			// × 变量名使用中文 | 不同的环境或者编辑器要求不同 可能导致报错
			#endregion

			#region 知识点2 | 常用的命名规则
			// 驼峰命名法 | 变量的命名
			// ★首字母小写，之后的单词首字母大写
			string myName = "myName";
			string yourBMI = "yourBMI";
			string yourUserName = "yourUserName";
			Console.WriteLine("例如：" + myName + "，" + yourBMI + "," + yourUserName + "...");

			// 帕斯卡命名法 | 函数、类的命名
			// ★所有单词首字母都大写
			#endregion
		}
	}
}
