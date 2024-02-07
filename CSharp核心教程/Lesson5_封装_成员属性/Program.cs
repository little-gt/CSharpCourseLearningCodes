using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_封装_成员属性
{
	#region  知识点 1 | 成员属性的基本概念
	// 基本概念 |
	// 1. 用于保护成员变量
	// 2. 为成员属性的获取和赋值添加逻辑处理
	// 3. 解决3P的一些局限性
	//    public    ——> 内外访问
	//    private   ——> 仅内部访问
	//    protected ——> 内部和子类可访问
	// 只能获取不能修改 或者 只能修改不能获取
	#endregion

	#region 知识点 2 | 成员属性的基本方法
	// 访问修饰符 属性类型 属性名
	// {
	//        get{}
	//        set{}
	// }
	class Person
	{
		private string name;
		private int age;
		private int money;
		private bool sex;

		// 属性的命名 ——> 帕斯卡命名法
		public string Name
		{
			get
			{
				// 可以在返回之前可以添加一些逻辑规则
				// 意味着 这个属性可以获取到的内容
				return name;
			}
			set
			{
				// 可以在设置之前添加一些规则
				// 关键字 value 用于表示外部传入的值
				name = value;
			}
		}
		public int Age
		{
			set
			{
				// 例子 | 对写入的内容进行安全检查
				if (value < 0)
				{
					System.Diagnostics.Debug.WriteLine("× 年龄不应该小于0，写入失败！");
				}
				else
				{
					age = value;
				}

			}
			get
			{
				return age;
			}
		}
		public int Money
		{
			set
			{
				// 例子 | 进行加密处理
				int tempMoney = value;
				tempMoney *= 22;
				tempMoney += 666;
				tempMoney *= 11;
				tempMoney -= 777;
				money = tempMoney;
				System.Diagnostics.Debug.WriteLine("√ 已经对 money 就行赋值，值为：" + money);
			}
			get
			{
				// 例子 | 进行解密处理
				int tempMoney = money;
				tempMoney += 777;
				tempMoney /= 11;
				tempMoney -= 666;
				tempMoney /= 22;
				System.Diagnostics.Debug.WriteLine("√ 已经对 money 就解密，值为：" + tempMoney);
				return tempMoney;
			}
		}
	}
	#endregion

	#region 知识点 4 | 成员属性中 get 和 set 前可以加访问修饰符
	// 注意 |
	// 1. 默认不加 会使用属性申明时的访问权限
	// 2. 加的访问修饰符要低于属性的权限
	// 3. 不能让 get 和 set 的访问权限都低于属性的权限
	class Example4
	{
		int password;
		public int valuePassword
		{
			// 允许外界进行设置
			set
			{
				password = value;
			}
			// 不允许外界进行读取
			private get
			{
				return password;
			}
		}
	}
	#endregion

	#region 知识点 5 | get 和 set 可以只有一个
	class Example5
	{
		bool isLogin;
		int userPassword;
		// 只有 get ：
		public bool IsLogin
		{
			get
			{
				return isLogin;
			}
		}
		// 只有 set ：
		public int UserPassword
		{
			set
			{
				userPassword = value;
			}
		}
	}
	#endregion

	#region 知识点 6 | 自动属性
	// 作用 | 
	// 如果在没有什么特殊处理的情况下，希望可以对变量的设置和读取进行精细的权限控制
	// 可以使用自动属性，以节约一些代码量
	class Example6
	{
		public float Height
		{
			// 没有在 get 或者 set 中写任何逻辑
			get;
			private set;
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			#region 知识点 3 | 成员属性的使用
			Person person = new Person();

			person.Age = -1;

			person.Money = 100;
			Console.WriteLine(person.Money);
			#endregion
		}
	}
}
