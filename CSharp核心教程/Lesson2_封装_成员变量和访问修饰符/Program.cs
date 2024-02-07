using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_封装_成员变量和访问修饰符
{
	#region 知识点回顾
	// 知识点 类和对象 |

	// 申明类 (在 namespace 语句块下 )
	// class 类名
	// {
	//       //   特征 ——> 成员变量
	//       //   行为 ——> 成员方法
	//       //   保护特征 ——> 成员属性
	//
	//       //   构造函数和解析函数
	//       //   索引器
	//       //   运算符重载函数
	//       //   静态函数
	// }

	// 实例化对象 ( 在 Main 等函数语句块中 )
	// 类名 变量名;
	// 类名 变量名 = null;
	// 类名 变量名 = new 变量名();

	#endregion

	#region 知识点 1 | 成员变量
	// 基本规则 |
	// 1. 申明在类语句块中
	// 2. 用来描述对象的特征
	// 3. 可以是任意变量类型
	// 4. 数量不做限制
	// 5. 是否赋值根据需求决定

	// 枚举 | 性别
	enum E_SexType
	{
		Man,        // 0
		Woman,      // 1
		Other,      // 2
		Undefined,  // 3
	}

	// 类   | 宠物
	class Pet
	{

	}

	// 类   | 人
	class Person
	{
		// 特征 ——> 成员变量
		// 可以初始化也可以不初始化
		public string name = "No Name"; // 姓名
		public int age = 0;             // 年龄
		public E_SexType sex;           // 性别
		public Person girlfriend;       // 女朋友 | 如果 要在类中申明一个和自己相同类型的成员变量时 是不允许直接初始化的 
		public Person[] friends;        // 朋友们 | 如果 要在类中申明一个和自己相同类型的成员变量时 是不允许直接初始化的 
		Pet pet = new Pet();     // 宠物
	}
	#endregion

	#region 知识点 2 | 访问修饰符
	// 访问修饰符 |
	// pubilc    ——> 公共的 | 自己(内部)和别人(外部)都可以访问和使用
	// private   ——> 私有的 | 只允许自己(内部)进行访问和使用           ★不说明访问类型，默认为private
	// protected ——> 保护的 | 自己(内部)和子类才能访问和使用

	// 目前决定 类内部 的成员 访问权限 
	#endregion

	class Program
	{
		static void Main(string[] args)
		{

			Person p = new Person();

			#region 知识点 3 | 成员变量的使用和初始值
			/* 初始值 */

			// 使用 default 函数可以快速地获取每个变量类型的默认值
			Console.WriteLine(default(int));

			// 数字类型 | 默认都是 0
			// 布尔类型 | 默认都是 false
			// 引用类型 | 默认的是 null (空)

			/* 代码实例 */
			p.age = 12;
			Console.WriteLine(p.age);
			#endregion
		}
	}
	// 总结      |
	// 成员变量
	// 描述特征
	// 类中申明
	// 赋值随意
	// 默认值，值类型    不相同
	// 默认值，引用类型为 null
	// 任意类型
	// 任意数量

	// 访问修饰符 |
	// public    ——> 公共点
	// private   ——> 私有的
	// protected ——> 保护的
}
