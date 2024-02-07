using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_类型转换之显示转换
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("===== 知识点1 | 括号强转 =====");

			#region 知识点1 | 括号强转
			/*  作用 | 一般情况下 把高精度变量中的值 转入 低精度变量
			 *  语法 | 变量类型 变量名 = (目标变量类型) 变量名;
			 *  语法 | 变量名 = (目标变量类型) 变量名;
			 *  注意 | 要注意 精度 范围
			 */

			// 注意 | 有符号的整形在超出精度时 符号位可能出现因为精度逸出导致的问题
			int valueInt = 10;
			long valueLong = 100000000000000;
			valueInt = (int)valueLong;
			Console.Write(valueInt);
			Console.WriteLine(" | 此时100000000000000就被异常地转换了");

			// 注意 | 有符号的整形转为无符号时 可能会因为符号位导致转换出现异常
			uint valueUint = 10;
			valueInt = -50;
			valueUint = (uint)valueInt;
			Console.Write(valueUint);
			Console.WriteLine(" | 此时-50就被异常地转换了");

			// 注意 | char可以转为int uint 同理 也可以反过来转换
			// 注意 | char本质是一个将编码转换成字符的变量，所以可以这么转换
			char valueChar;
			valueUint = '啊';
			valueChar = (char)valueUint;
			Console.Write(valueChar + " 字符编码：" + valueUint);
			Console.WriteLine(" | 此时valueUint中的值就变成了char中的字符编码，被系统自动转换了");

			// 注意 | 浮点数如果 小数的部分超出精度 (超出有效数字的位数) 会被自动截断丢失多的有效数字
			double valueDouble = 1.00000000000001;
			float valueFloat;
			valueFloat = (float)valueDouble;
			Console.Write(valueFloat);
			Console.WriteLine(" | 此时1.00000000000001的精度就丢失了");
			#endregion

			Console.WriteLine();
			Console.WriteLine("===== 知识点2 | Parse法 =====");

			#region 知识点2 | Parse法
			/*  作用  | 把字符串类型转换成对应的类型
			 *  语法  | 变量类型.Parse("字符串");
			 *  注意  | 字符串必须可以转换成对应类型的字符 否则会报错
			 *  注意  | 字符串必须是可以被存储的值 否则报错
			 */

			string valueString;
			valueString = "-50";
			valueInt = int.Parse(valueString);
			Console.Write(valueInt);
			Console.WriteLine(" | 此时字符串中的值就被转换成int中可以存储的值了");
			//  警示  |
			//  valueString = "1.1";
			//  valueInt = int.Parese(valueString);
			//  会导致报错，因为string字符中的是小数，而int为整数变量，无法Parse转换，导致报错
			//  警示  |
			//  valueString = "-1";
			//  valueUint = Unit.Parese(valueString);
			//  会导致报错，因为unit不支持负数

			valueString = "0.0000001";
			valueFloat = float.Parse(valueString);
			Console.Write(valueFloat);
			Console.WriteLine(" | 此时字符串中的值就被转换成float中可以存储的值了");

			bool valueBool;
			valueString = "trUe";
			valueBool = bool.Parse(valueString);
			Console.Write(valueBool);
			Console.WriteLine(" | 此时字符串中的值就被转换成bool中可以存储的值了");
			//  注意  |
			//  bool类型转换时，string字符必须是 true 或者 false 但是对大小写不敏感
			valueString = "2.222222";
			#endregion

			Console.WriteLine();
			Console.WriteLine("===== 知识点3 | Convert法 =====");

			#region 知识点3 | Convert法
			// 作用 | 更精确地将各个类型之间进行相互转换
			// 语法 | Convert.To 目标类型(变量或常量)
			// 注意 | 填写的变量或常量必须正确 否则报错

			// 转字符串 | 如果是把字符串转对应类型 那字符串一定要合法合规
			// 错误示范 | valueInt = Convert.ToInt32("233.56");
			valueInt = Convert.ToInt32("233");
			Console.Write(valueInt);
			Console.WriteLine(" | 值：233 此时字符串被转换成了int中的值！");

			// 转数值类型 |
			// 此时可以把 浮点数 转换为 整数 而且精度高
			valueFloat = 233.233f;
			valueInt = Convert.ToInt32(valueFloat);
			Console.Write("浮点数：" + valueFloat + " | 转换后的值：" + valueInt);
			Console.WriteLine(" | 此时float中的值转换为int中的值 而且四舍五入了 精度更高了！");

			// 特殊类型 |
			// 可以把bool的 ture 或 false 转换为内的int内的值
			// 小贴士   |
			// 在其他语言中 true - 1 ； false - 0 用于条件判断
			valueBool = true;
			valueInt = Convert.ToInt32(valueBool);
			Console.Write("此时bool类型的 true 被转换为了int中的：" + valueInt);
			Console.WriteLine(" | 注意：bool的转换请注意 true 和 false的拼写");
			valueBool = false;
			valueInt = Convert.ToInt32(valueBool);
			Console.Write("此时bool类型的 false 被转换为了int中的：" + valueInt);
			Console.WriteLine(" | 注意：bool的转换请注意 true 和 false的拼写");

			// 字符编码 |
			// 单个字符可以被转换成对应的字符编码
			valueChar = 'v';
			valueInt = Convert.ToInt32(valueChar);
			Console.Write("此时 " + valueChar + " 被转换为int的字符编码 " + valueInt);
			Console.WriteLine(" | 注意：char被转换为了对应的字符编码");

			// 注意     |
			// 每一种变量类型都有对应的 Convert 方法
			/* 有符号的转换
             * sbyte short int long
             */
			sbyte exampleSbyte = Convert.ToSByte("1");
			short exampleShort = Convert.ToInt16("1");
			int exampleInt = Convert.ToInt32("1");
			long exampleLong = Convert.ToInt64("1");

			/* 无符号的转换
             * byte ushort uint ulong
             */
			byte exampleByte = Convert.ToByte("1");
			ushort exampleUshort = Convert.ToUInt16("1");
			uint exampleUint = Convert.ToUInt32("1");
			ulong exampleUlong = Convert.ToUInt64("1");

			/* 浮点数的转换
             * float double decimal
             */
			float exampleFloat = Convert.ToSingle("233.233");
			double exampleDouble = Convert.ToDouble("233.233");
			decimal exampleDecimal = Convert.ToDecimal("233.233");

			/* 特殊类型的转换
             * bool char string
             */
			bool exampleBool = Convert.ToBoolean("true");
			char exampleChar = Convert.ToChar("A");
			string exampleString = Convert.ToString("呜啊~");
			#endregion

			Console.WriteLine();
			Console.WriteLine("===== 知识点4 | 其他类型转string =====");

			#region 知识点4 | 其他类型转string
			// 注意 |
			// 在变量后加上 .ToString(); 
			exampleString = 233.ToString();
			exampleString = true.ToString();
			exampleString = 'A'.ToString();
			exampleString = 2.3f.ToString();
			// 注意 |
			// 使用输出指令时 拼接会自动使用ToString
			Console.WriteLine("233 | " + 233 + " | " + true + " | " + 2.33f);
			#endregion
		}
	}
}
