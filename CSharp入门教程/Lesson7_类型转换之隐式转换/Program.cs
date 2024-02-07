using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_类型转换之隐式转换
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("类型转换 - 隐式转换");
			/* 类型转换 | 不同变量类型之间的相互转换
			 * 
			 * 隐式转换的基本规则
			 * 1. 不同类型之间的自动转换
			 * 2. 大范围装小范围
			 */

			#region 知识点1 | 相同大类型之间的转换
			/* 有符号
			 * long int short sbyte
			 */
			long valueLong = 0;
			int valueInt = 0;
			short valueShort = 0;
			sbyte valueSbyte = 1;
			// 隐式转换 | 可以使用大范围的类型去装载小范围的类型
			valueLong = valueSbyte;
			valueShort = valueSbyte;
			valueInt = valueShort;
			valueLong = valueInt;
			// 务必注意 | 不能使用小范围的类型去装载大范围的类型
			// 错误示范 | valueInt = valueLong;

			/* 无符号
			 * ulong uint ushort byte
			 */
			ulong valueUlong = 0;
			uint valueUint = 0;
			ushort valueUshort = 0;
			byte valueByte = 1;
			// 隐式转换 | 可以使用大范围的类型去装载小范围的类型
			valueUlong = valueByte;
			valueUshort = valueByte;
			valueUint = valueUshort;
			valueUlong = valueUint;
			// 务必注意 | 不能使用小范围的类型去装载大范围的类型
			// 错误示范 | valueUint = valueUlong;

			/* 浮点数
			 * decimal double float
			 */
			decimal valueDecimal = 0M;
			double valueDouble = 0;
			float valueFloat = 1F;
			// 务必注意 | decimal 是无法使用隐式转换的形式的
			// 错误示范 | valueDecimal = valueDouble;
			// 错误示范 | valueDecimal = valueFloat;
			// 隐式转换 | double 是可以装载 float
			valueDouble = valueFloat;

			/* 特殊类型
			 * bool char string
			 */
			// 务必注意 | bool char string 是无法隐式转换的
			#endregion

			#region 知识点2 | 不同大类之间的转换
			/* 有符号和无符号 之间的装载
			 * 无符号的 ulong uint ushort byte ——> 有符号的 long int short sbyte
			 */
			// 务必注意 | 有符号的变量 无法被装在 无符号的变量 中的！
			// 错误示范 | valueUlong = valueSbyte;
			// 务必注意 | 无符号的变量 可以装载到 有符号的变量 要注意有符号的变量的存储空间 避免转换时因为空间不够报错！
			valueLong = valueUint;
			// 如上的转换不会使得两个类型的变量的值超出范围

			/* 整数和浮点数 之间的装载
             * 整数 long int short sbyte / ulong uint ushort byte ——> 浮点数 decimal double float
             */
			// 浮点数可以装载任何整数变量
			// 特别提醒 | 浮点数变量可以使用科学计数法 因此范围比整数变量都要大
			valueFloat = valueLong;
			valueFloat = valueUlong;
			// 特别提示 | 虽然 float double 无法隐式转换成 decimal 但是 decimal 可以装载 任何的整数变量
			valueDecimal = valueLong;

			/* char和 浮点数 / 整数 之间的装载
             * 变量类型 ——> 有符号整数 long int / 无符号整数 ulong uint / 浮点数 decimal double float
             */
			// 特别提醒 | char是一个无符号的16位的无符号整数，范围是0~65535，用于表示ASCII码的编码值，并且将对应的编码值变成文字
			char valueChar = '0';
			valueInt = valueChar;
			valueFloat = valueChar;
			#endregion
		}
	}
}
