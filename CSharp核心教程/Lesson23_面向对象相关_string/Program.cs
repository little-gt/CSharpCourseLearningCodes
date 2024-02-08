using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_面向对象相关_string
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Lesson 23 - string");
			#region 知识点 1 | 字符串指定位置的获取
			// 提示 |
			// 字符串本质是 char 数组
			string str = "字符串";
			Console.WriteLine(str);
			Console.WriteLine(str[0]);
			Console.WriteLine(str[1]);
			Console.WriteLine(str[2]);
			for (int i = 0; i < str.Length; i++)
			{
				Console.WriteLine("str[{0}] = {1}", i, str[i]);
			}

			// 提示 |
			// 因此 string 可以转换为 char 数组
			char[] chars = str.ToCharArray();
			for (int i = 0; i < chars.Length; i++)
			{
				Console.WriteLine("chars[{0}] = {1}", i, chars[i]);
			}
			#endregion

			#region 知识点 2 | 字符串拼接
			// 语法 |
			// 使用 string.Format 静态方法进行字符串拼接
			str = string.Format("{0},{1}", 1, 233);
			Console.WriteLine(str);
			#endregion

			#region 知识点 3 | 正向查找字符位置
			// 语法 |
			// 使用 IndexOf("字符") 查找字符在字符串当中的位置，从 0 -> 最大
			// 如果找到，会返回该字符所在的位置索引，即在数组的位置 str[index]
			// 如果没有找到，会默认返回 -1

			// 注意 |
			// 正向查找只能返回 0 -> 最大 过程中，第一个符合条件字符的位置

			str = "字符串";
			int index;
			index = str.IndexOf("符");
			Console.WriteLine("index = " + index);
			index = str.IndexOf("天");
			Console.WriteLine("index = " + index);
			#endregion

			#region 知识点 4 | 反向查找指定字符串位置
			// 语法 |
			// 使用 LastIndexOf("字符") 查找字符在字符串当中的位置，从 最大 -> 0
			// 如果找到，会返回该字符所在的位置索引，即在数组的位置 str[index]
			// 如果没有找到，会默认返回 -1

			// 注意 |
			// 正向查找只能返回 最大 -> 0 过程中，第一个符合条件字符的位置

			str = "我是字符串，一个字符串";
			index = str.LastIndexOf("符");
			Console.WriteLine("index = " + index);
			index = str.LastIndexOf("天");
			Console.WriteLine("index = " + index);
			#endregion

			#region 知识点 5 | 移除指定位置后的字符
			// 语法 |
			// >>> 移除指定位置以后 所有的字符 可以使用
			//     .Remove( index )
			//     这样就会移除从 index 开始以后所有的字符
			// 注意 |
			// >>> .Remove( index ) 不会修改字符串本身
			//     它会返回移除完毕以后的字符串，如果需要修改本身，则需要
			//     str = str.Remove( index );
			str = "字符串，字符串";
			str.Remove(3);
			Console.WriteLine(str);
			str = str.Remove(3);
			Console.WriteLine(str);

			// 语法 |
			// >>> 如果需要移除指定位置以后 有限个字符 可以使用
			//     .Remove(参数1, 参数2);
			//     参数1 - 开始位置
			//     参数2 - 字符个数
			str = "字符串，字符串";
			str.Remove(3, 1);
			Console.WriteLine(str);
			#endregion

			#region 知识点 6 | 替换指定字符串
			// 语法 |
			// >>> 如果需要替换字符串当中的 所有指定内容 可以使用
			//     .Replace("要指定的字符串", "替换成的字符串");
			//     替换以后，所有符合的指定内容都会被替换
			// 注意 |
			// >>> 方法 .Replace("参数 1", "参数 2") 同样不会修改字符串本身
			//     会返回修改完成以后的字符串
			str = "字符串，字符串";
			str.Replace("字符串", "串串符");
			Console.WriteLine(str);
			str = str.Replace("字符串", "串串符");
			Console.WriteLine(str);
			#endregion

			#region 知识点 7 | 大小写转换
			// 语法 |
			// >>> 小写转换大写
			//     使用方法 .ToUpper() 会把字符串中所有的小写字符转换为大写字符
			// 注意 |
			// >>> 方法 .Replace("参数 1", "参数 2") 同样不会修改字符串本身
			//     会返回修改完成以后的字符串
			str = "c# learning course";
			str.ToUpper();
			Console.WriteLine(str);
			str = str.ToUpper();
			Console.WriteLine(str);
			// 语法 |
			// >>> 大写转换小写
			//     使用方法 .ToLower() 会把字符串中所有的大写字符转换为小写字符
			str = "C# LEARNING COURSE";
			str.ToLower();
			Console.WriteLine(str);
			str = str.ToLower();
			Console.WriteLine(str);
			#endregion

			#region 知识点 8 | 字符串截取
			// 语法 |
			// 截取从指定位置开始之后的 所有的字符 使用 .Substring( index );
			// 注意 |
			// .Substring() 同样不会修改字符串本身，会返回修改以后的字符串
			str = "C# LEARNING COURSE";
			str.Substring(3);
			Console.WriteLine(str);
			str = str.Substring(2);
			// 提示 |
			// 截取的时候，会把该位置所在的字符一起删除，
			// 留下之后的字符串 LEARNING COURSE
			Console.WriteLine(str);

			// 语法 |
			// 如果要截取指定位置之后的 有限个字符 使用 .Substring( index, length );
			// index  - 开始位置
			// length - 指定位置
			// 注意 |
			// .Substring( index, length ); 不会判断 length 是否越界，所以需要自己手动判断
			str = "C# LEARNING COURSE";
			str = str.Substring(3, 5);
			Console.WriteLine(str);
			#endregion

			#region 知识点 9 | 字符串切割 ★
			str = "1,2,3,4,5,6,7,8";
			string[] strs = str.Split(',');
			for (int i = 0; i < strs.Length; i++)
			{
				Console.WriteLine(strs[i]);
			}
			#endregion
		}
	}
}
