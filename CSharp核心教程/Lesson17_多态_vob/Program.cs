using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_多态_vob
{
	#region 知识回顾 |

	#region 封装 —— 用程序语言来形容对象
	class 类名
	{
		#region 特征 —— 成员变量

		#endregion

		#region 行为 —— 成员方法

		#endregion

		#region 初始化调用 —— 构造函数

		#endregion

		#region 释放时调用 —— 析构函数

		#endregion

		#region 保护成员变量 —— 成员属性

		#endregion

		#region 像数组一样使用 —— 索引器

		#endregion

		#region 类名点出使用 —— 静态成员

		#endregion

		#region 自定义对象可计算 —— 运算符重载

		#endregion
	}
	#endregion

	#region 继承 —— 复用封装对象的代码；子对象继承父对象，复用现成代码

	#region 继承中的构造函数

	#endregion

	#region 里氏替换原则

	#endregion

	#region 万物之父

	#endregion

	#region 装箱拆箱

	#endregion

	#region 密封类

	#endregion

	#endregion

	#endregion

	#region 知识点 1 | 多态的概念
	// 多态按字面的意思就是 "多种状态"
	// 让继承同一类父类的子类们，在执行相同方法时有不同的表现 (状态)

	// 主要目的：
	// 同一个父类的对象，执行相同行为 (方法) 有着不同的表现
	// 解决问题：
	// 让同一个对象有唯一行为的特征
	#endregion

	#region 知识点 2 | 解决的问题
	class Father
	{
		public void SpeakName()
		{
			Console.WriteLine("Father的方法。");
		}
	}
	class Son : Father
	{
		public new void SpeakName()
		{
			Console.WriteLine("Son的方法");
		}
	}
	#endregion

	#region 知识点 3 | 多态的实现
	// 我们目前已经学过的多态：
	// 编译时多态 —— 函数重载 ( 函数重载一开始就写好在编译器当中 )
	

	// 现在需要开始学习的多态：
	// 运行时多态 —— vob 抽象函数 接口
	// v: virtual  (虚函数)
	// o: override ( 重写 )
	// b: base     ( 父类 )

	class GameObject
	{
		public string name;

		public GameObject(string name)
		{
			this.name = name;
		}

		// 注意：虚函数可以被子类重写
		public virtual void Attack()
		{
			Console.WriteLine("游戏对象进行了攻击！");
		}
	}

	class Player : GameObject
	{
		public Player(string name) : base(name) { }

		// 重写虚函数
		public override void Attack()
		{
			// base 的作用：
			// 代表父类，可以通过 base 来保留父类的行为
			// base.Attack(); // 保留父类的攻击方法
			// 作用在于复用代码，优化代码
			Console.WriteLine("玩家进行了攻击！");
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			// 知识点 2 |
			// 需要解决的问题，当父类和子类当中有重复的方法名时，
			// 调用这个方法，会出现不同的表现
			Father father = new Son();
			father.SpeakName();
			(father as Son).SpeakName();

			// 知识点 3 |
			// vob 多态的使用,解决了重名方法在调用时有多个行为特征，
			// 使得一个方法函数只有唯一的特征
			GameObject player = new Player("TEST PLAYER");
			player.Attack();
		}
	}

	#region 总结 |
	// 多态     ：让同一对象在执行相同方法函数时，执行相同行为时，有不同的表现
	// 解决的问题：让同一对象有唯一的行为特征
	// vob:
	//       v: virtual ( 虚函数 )
	//       o: override( 重  写 )
	//       b: base    ( 父  类 )
	// v 和 o 一定是结合使用的，他们是用来实现多态的
	// b 是否使用，是根据实际需求决定的，如果需要保留父类行为，就保留 base
	#endregion
}
