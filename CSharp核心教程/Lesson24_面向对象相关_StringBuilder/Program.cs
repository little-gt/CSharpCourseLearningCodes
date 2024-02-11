using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24_面向对象相关_StringBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 知识回顾
			// string 是 特殊的引用类型
			// 每次重新赋值或者拼接时，都会重新分配新的内存空间
			// 如果一个字符串经常改变，会非常浪费空间
			#endregion

			#region 知识点 | StringBuilder
			// StringBuilder 是 C# 提供的一个用于处理字符串的公共类

			// 主要解决的问题是：
			// 修改字符串而不需要创建新的对象，需要频繁修改和拼接的字符串可以使用它，可以提升性能
			// 性能 -> ① 提高内存利用 ② 减少GC次数

			// 使用 StringBuilder 时，需要注意引用命名空间( using System.Text; )

			#region 基础 - 初始化
			// 使用 StringBuilder 时，需要 new 一个对象
			// str1 是的重载，直接进行赋值；
			// str2 是的重载，在赋值的同时，定义str2的最大长度.
			StringBuilder str1 = new StringBuilder("context");
			StringBuilder str2 = new StringBuilder("context", 50);
			#endregion

			#region 基础 - 容量
			// 提要 |
			// StringBuilder 中存在一个容量问题，每次往里面加东西的时候，如果超出容量，会自动扩容
			// 演示 |
			// str1 容器{■□□□□} =装满=> 容器{■■■■■} =再向里面装东西，会自动扩容=> 容器{■■■■■■■■■■□□□□□□□□}
			// 这样的扩容，可以减少频繁新建新的空间，和减少一次性新建的容量太大，造成浪费

			// 代码 - 获取容量大小
			// .Capacity
			Console.WriteLine("str1.Capacity = " + str1.Capacity);

			// 代码 - 获取字符长度
			// .Length
			Console.WriteLine("str1.Length = " + str1.Length);

			#endregion

			#region 方法 - 增删查改替换
			// 增 |
			// 注意，在 StringBuilder 中，无法直接使用 += 进行增加操作，而需要下面的两个方法
			// .Append("context");
			// .AppendFormat("{0}{1}",222,333);
			str2.Append("context");
			Console.WriteLine("str2 : " + str2);
			Console.WriteLine("str2.Capacity = " + str2.Capacity);
			Console.WriteLine("str2.Length = " + str2.Length);

			str2.AppendFormat("{0}{1}", 222, 333);
			Console.WriteLine("str2 : " + str2);
			Console.WriteLine("str2.Capacity = " + str2.Capacity);
			Console.WriteLine("str2.Length = " + str2.Length);

			// 插入 |
			// 从字符串的某一个位置插入一个内容，可以使用下面的方法
			// .Insert(location,"context");
			// 即在 StringBuilder 的第 location 个位置插入 context
			str2 = new StringBuilder("123456789");
			Console.WriteLine("str2 : " + str2);
			str2.Insert(5, "context");
			Console.WriteLine("str2 : " + str2);

			// 删 |
			// 同样的 StringBuilder 拥有 .Remove() 函数进行删除
			// >>> .Remove(startIndex, deletLength);
			//     删除从 startIndex 开始之后 deletLength 个字符
			str2.Remove(5, 7);
			Console.WriteLine("str2 : " + str2);

			// 清空 |
			// 使用 .Clear() 方法可以清空 StringBuilder 当中的所有内容
			str1.Clear();

			// 查找 |
			// 和普通的 string 一样，可以通过 str[index] 直接进行查找
			char tempChar = str2[0];

			// 修改 |
			// 和普通的 string 一样，可以通过 str[index] = char 直接修改
			str2[0] = '0';

			// 替换 |
			// 使用 .Replace("search","context") 可以直接替换所有的 search 为 context
			// 注意与 string 不同的是 StringBuilder 会直接修改本身
			str2.Replace("2", "context");

			// 重新赋值 |
			str2.Clear();
			str2.Append("123456789");

			// 判断相等 |
			// 注意，stringbuilder 中 == 无法直接使用，但是可以通过下面的函数，判断是否相等
			// .Equals("context")
			if (str2.Equals("123456789"))
			{
				Console.WriteLine(true);
			}
			#endregion

			Console.ReadKey();
			#endregion
		}
	}
}
