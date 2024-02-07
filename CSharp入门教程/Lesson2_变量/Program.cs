//引用命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//命名空间
namespace Lesson2_变量
{
	//类
	class Program
	{
		//函数
		static void Main(string[] args)
		{
			//函数语句块 目前学习均在这
			Console.WriteLine("第二课 变量");

			#region 知识点一 折叠代码
			//主要作用 使得我们在编程时 逻辑更加清晰
			//它是由 #region 和 #endregion 构成的
			//它的具体作用 将中间的代码折叠起来 避免代码太凌乱
			//本质是 IDE提供给我们的 预处理指令
			//只有在编辑时才有用 在发布代码时 在执行程序时 会被自动删除
			#endregion

			#region 知识点二 如何申明变量
			//变量 可以变化的容器
			//变量 就是可以用来存储不同类型数值的容器
			//不同类型的变量 可以存储对应类型的数据

			/*
			 * 变量声明的固定写法
			 * 变量类型 变量名 = 初始值 ;
			 */
			// int 整型变量 = 1;
			// 变量类型有14种 是需要背的
			// 变量名有命名规范 是要按规范命名的
			// 初始值要和变量类型统一 否则会报错

			/*
             * 变量类型
             * 1. 一定要死记硬背 各种变量类型的关键字
             * 2. 一定要记住 各种不同变量类型 所能存储的范围
             * 3. 一定要记住 各种不同变量类型 所能存储的类型
             */

			//1.有符号的整形变量 | 是能存储 一定范围 正负数包括0的变量类型
			// sbyte | 范围 -128~127
			sbyte sb = 1;
			// int   | 范围 -21亿多~21亿多
			int i = 1;
			// short | 范围 -32768~32767
			short s = 1;
			// long  | 范围 -9百万兆~9百万兆
			long l = 1;
			Console.WriteLine("这是sbyte变量sb中的值：" + sb );
			Console.WriteLine("这是int变量i中的值：" + i);
			Console.WriteLine("这是short变量s中的值：" + s);
			Console.WriteLine("这是long变量l中的值：" + l);

			//2.无符号的整型变量 | 是能存储 一定范围 非负整数的变量类型
			// byte   | 范围 0~225
			byte b = 0;
			// uint   | 范围 0~42亿多
			uint ui = 2;
			// ushort | 范围 0~65535
			ushort us = 65535;
			// ulong  | 范围 0~18百万兆
			ulong ul = 0;
			Console.WriteLine("这是byte变量b中的值：" + b);
			Console.WriteLine("这是uint变量ui中的值：" + ui);
			Console.WriteLine("这是ushort变量us中的值：" + us);
			Console.WriteLine("这是ulong变量ul中的值：" + ul);

			//3.浮点数(小数)
			//float 存储7/8位有效数字 根据编辑器不同 有效数字也可能不一样
			//当超出有效数字以后 四舍五入
			//之所以要在后面加f 是因为c#中 申明小数默认是double的类型 加f或者F 是告诉系统 它是float类型
			float f = 0.1234567890f; 
			Console.WriteLine("这是float变量f中的值：" + f);
			//double 存储15~17位有效数字 根据编辑器不同 有效数字也可能不一样
			//当超出有效数字以后 四舍五入
			double d = 0.12345678901234567890;
			Console.WriteLine("这是double变量d中的值：" + d);
			//decimal 存储27~28位的有效数字 （不建议使用）
			//之所以要在后面加m 是因为c#中 申明小数默认是double的类型 加m或者M 是告诉系统 它是decimal类型
			decimal de = 0.123456789012345678901234567890m;
			Console.WriteLine("这是decimal变量de中的值：" + de);

			//4.特殊类型
			/* bool
			 * 布尔类型 或 真假类型 | 只能存储 ture false 表示真假的数据类型
			 */
			bool bo1 = true;
			bool bo2 = false;
			Console.WriteLine("bo1: " + bo1 + " | " + "bo2: "+bo2);
			/*
			 * char
			 * 查尔类型 或 字符类型 | 是用来存储 单个字符 的变量类型
			 */
			char c = '茶';
			Console.WriteLine("char:  " + c);
			/*
			 * string
			 * 字符串类型          | 是用来存储 多个字符且没有上限 的变量类型
			 */
			string str = "哈哈哈哈，2333333333，咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕咕";
			Console.WriteLine("string:  " + str);
			#endregion

			#region 知识点三 为什么会有这么多的变量类型
			//注意：变量的使用不能无中生有 必须声明以后才能使用 而且不要多次重复声明变量
			i = i + 1;

			/* 不同的变量 存储的范围和类型不同 本质是占用的内存空间不同
			*  选择不同的数据（变量）类型装载不同的数据
			*/
			//例如 以下的场景
			//姓名 | 字符串
			string UserRealName = "小德";
			//年龄 | 数字 且 不为负数 不大于255
			byte UserAge = 17;
			//身高 | 数字 且 可以为小数 单位为cm
			float UserHeight = 176.5f;
			//体重 | 数字 且 可以为小数 单位为kg
			float UserWeight = 68.5f;
			//性别 | 两个值（男或者女） ture——女 false——男
			bool UserSex = false;

			//对于初学 数字用int 小数用float 字符串用string 真假用bool
			#endregion

			#region 知识点四 多个相同类型变量的同时申明
			// 同时声明的方法即使用 , 把它们分开
			// 变量类型 变量名 = 初始值 , 变量名 = 初始值 ...;
			int Val1 = 1, Val2 = 2;
			#endregion

			#region 知识点五 变量初始化相关
			//变量申明时 可以不设置初始值 但是不建议这样写 因为这样写不安全
			int TestEmpty;
			#endregion
		}
	}
}
