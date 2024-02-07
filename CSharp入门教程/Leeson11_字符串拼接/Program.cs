using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeson11_字符串拼接
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 字符串拼接 ======");

			#region 知识点1 | 字符串拼接方式 1
			string str;
			// 之前的算数运算符 只是用来数值类型变量类型进行数学运算的
			// 而 string 不存在算数运算符不能计算 但是可以通过+号来进行字符串拼接
			str = "233";
			// 用 + 进行字符串拼接
			str = str + "233";
			Console.WriteLine(str);

			// 复合运算符 +=
			// 1. 字符串之后的拼接都默认转换为字符串
			str = "□ ";
			str += "1" + 4 + true;
			Console.WriteLine(str);
			// 2. += 之后是全部的整形计算 所以相当于 str + 10
			str = "□ ";
			str += 1 + 2 + 3 + 4;
			Console.WriteLine(str);
			// 3. 用括号可以改变运算顺序
			str = "□ ";
			str += 1 + 2 + "" + (3 + 4);
			Console.WriteLine(str);
			#endregion

			#region 知识点2 | 字符串拼接方式 2
			/*  固定方法 string.Format();
			 *  string.Format("待拼接的内容，{0}，{1}......{n}" , 内容0 , 内容1 , ...... , 内容n );
			 *  拼接内容中的固定规则：
			 *  需要被拼接的内容用占位符 {数字} 替代。数字从：0~n依次往后
			 */
			string exampleString;
			exampleString = string.Format("你好！\n我是{0}，我现在正在学习{1}，很高兴认识你！", "小德", "C#");
			Console.WriteLine(exampleString);
			#endregion

			#region 知识点3 | 控制台打印拼接
			// Console.Write(); 和 Console.WriteLine(); 默认提供了和 string.Format(); 类似的功能
			Console.Write("233，{0}，456，{1}，{2}", 1, true, false);
			Console.WriteLine("233，{0}，456，{1}，{2}", 1, true, false);
			#endregion
		}
	}
}
