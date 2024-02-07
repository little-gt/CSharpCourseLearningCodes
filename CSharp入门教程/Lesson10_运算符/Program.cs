using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_运算符
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== lesson 10 · 运算符 ======");
			// 算数运算符 使用于 数值类型变量计算的运算符
			// 返回结果是数值

			#region 知识点1 | 赋值符号
			/* 符号 | =  
			 * 知识关键点 | 
			 * 先看右侧 再看左侧 把右侧的值赋值给左侧的变量 
			 * 示例 | A = B; 把 B 的值赋值给 A
			 */
			string userName = "TEST";
			int userAge = 17;
			float userHeight = 177.67f;
			#endregion


			#region 知识点2 | 算数运算符
			int valueInt1;
			int valueInt2;
			uint valueUint1;
			uint valueUint2;
			float valueFloat1;
			float valueFloat2;
			valueInt1 = 23;
			valueInt2 = 27;
			valueFloat1 = 23.3f;
			valueFloat2 = 27.7f;
			valueUint1 = 23;
			valueUint2 = 27;

			// --- --- --- --- --- --- --- --- --- --- --- --- --- //

			/* 符号 | + （加法运算）
			 * 将两个变量的值 相加 ；可以把整形相加以后的值 用= 赋值给 浮点数变量
			*/
			// 整数只能等于整数计算的结果
			valueInt1 = valueInt1 + 27;
			// 浮点数 可以等于 整数运算的结果
			valueFloat1 = valueFloat1 + valueFloat2 + valueInt1;
			// 有符号和无符号的整形不能直接计算
			// 错误示范 |
			// valueInt1 = valueUint1 + 2;

			// --- --- --- --- --- --- --- --- --- --- --- --- --- //

			/*  符号 | / （除法运算）
			 *  将两个变量的值相除 A/B 等价于 A÷B ；当赋值给整形变量时 小数部分会自动丢失
			 */
			// 注意如果要小数 必须为浮点数相除
			// 如果直接 1 / 2 会默认为 int整形类型
			valueFloat1 = 1f / 2f; //此时小数精度 保留 为0.5
			valueFloat2 = 1 / 2;   //此时小数精度 不保留 为0
			Console.WriteLine("valueFloat1：" + valueFloat1 + " valueFloat2：" + valueFloat2);

			// --- --- --- --- --- --- --- --- --- --- --- --- --- //

			/*  符号 | % （取余符号）
			 *  取余数 比如 4%3 表示 求4÷3的余数
			 */
			valueFloat1 = valueInt1 % valueInt2;
			#endregion

			#region 知识点3 | 运算顺序
			// 与数学四则运算规则相同 | 乘除取余 ——> 加减
			valueFloat1 = 1 + 4 % 2 * 3 / 2 + 1;
			// 先算 4除2的余数 再 乘上3 后 除以 2 最后 再算加法
			#endregion

			#region 知识点4 | 算术运算符 ——> 复合运算符
			/*  固定写法 | 运算符=
			 *  += ；-= ；*= ；/= ；%=
			 *  复合运算符 是用于 自己=自己 的运算
			 */
			// --- --- 隔 --- --- 离 --- --- 线 --- --- //
			int a = 50;

			a += 5; // 相当于 a = a + 5;
			a -= 5; // 相当于 a = a - 5;
			a *= 5; // 相当于 a = a * 5;
			a /= 5; // 相当于 a = a / 5;
			a %= 5; // 相当于 a = a % 5;
			#endregion

			#region 知识点5 算术运算符的自增减
			// 方式1 |
			a = 1;
			a = a + 1;

			// 方式2 |
			a = 1;
			a += 1;

			// 方式3 | 自增运算符
			a = 1;
			a++; //先用再加
			a = 1;
			++a; //先加再用
				 //a++：
			a = 1;
			Console.WriteLine(a++); //此时 输出1 并且输出（使用）以后再使得a+1
			Console.WriteLine(a);
			    //++a
			a = 1;
			Console.WriteLine(++a); //此时 输出2 并且a为2

			// 方法4 | 自减运算符
			a = 2;
			a--; //先用再减
			a = 2;
			--a; //先减再用
			     //a--
			Console.WriteLine(a--); //此时 输出2 并且输出（使用）以后再使得a-1
			Console.WriteLine(a);
			     //--a
			a = 1;
			Console.WriteLine(--a); //此时 输出1 并且a为1
			#endregion
		}
	}
}
