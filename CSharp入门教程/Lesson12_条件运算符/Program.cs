using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_条件运算符
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 条件运算符 ======");

			#region 知识点1 | 条件运算符
			/*  用于比较两个变量或常量
			 *  是否大于      >
			 *  是否小于      <
			 *  是否等于      ==
			 *  是否不等于    !=
			 *  是否大于等于  >=
			 *  是否小于等于  <=
			 */
			int a = 5;
			int b = 10;

			// 条件运算符 一定存在两边的内容
			// 左边内容 条件运算符 右边内容
			// 比较的结果 返回的是一个bool类型的值
			// true和false 如果比较的条件满足，那就返回true ；不满足，那就返回false
			// 先算右边 在赋值给左边

			// 纯比较 无法使用结果 对于我们来说没有意义
			// a > b; | 直接这样写会导致报错

			// 有效比较
			bool result;

			result = a > b;
			Console.WriteLine(result);

			result = a < b;
			Console.WriteLine(result);

			result = a >= b;
			Console.WriteLine(result);

			result = a <= b;
			Console.WriteLine(result);

			result = a == b;
			Console.WriteLine(result);

			result = a != b;
			Console.WriteLine(result);
			#endregion

			#region 知识点2 | 各种应用写法
			// 变量和变量比较
			a = 5;
			b = 10;
			result = a < b;
			// 变量和数值(常量)比较
			result = a < 10;
			result = b > 5;
			// 数值和数值(常量)比较
			result = 233 >= 233;
			// 计算结果的比较 | 条件运算符的优先级 低于 算数运算符
			// 先计算再比较
			result = a + 3 > b - 2;
			result = 233 + 666 < 666 - 233;

			// 左边 条件运算符 右边
			#endregion

			#region 知识点3 | 不能进行范围比较
			a = 5;
			// 判断是否在某两个值之间
			// 1 < a < 6 | 在c#都不不可以这样写
			// 要判断 一个变量是否在两个数之间 需要使用逻辑运算符连接
			#endregion

			#region 知识点4 | 不同类型之间的比较
			// 不同数值类型之间 可以随意进行条件运算符的比较
			int valueInt = 5;
			float valueFloat = 1.12f;
			double valueDouble = 12.4;
			short valueShort = 2;
			byte valueByte = 233;
			uint valueUint = 233;
			// 只要是数值 就可以进行条件运算符比较 比较大于小于等于 等等
			result = valueByte > valueDouble;
			result = valueInt <= valueFloat;
			result = valueUint != valueShort;

			// 特殊类型 string bool 只可以进行同类型进行 == 和 != 比较
			string valueString = "233";
			
			bool valueBool = true;

			result = valueString != "233";
			result = valueBool == false;

			// char 不仅可以和自己类型进行比较 还可以和数字类型进行比较
			char valueChar = 'A';
			// 因为ASC编码在一些区间内是连续的，可以用于实现一些特殊的输入判断
			result = valueChar == 'R';
			result = valueChar >= 'C'; //此时 A 和 C 会转化为ASC编码进行比较
			#endregion
		}
	}
}
