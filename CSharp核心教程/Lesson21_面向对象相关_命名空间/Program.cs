// 系统默认引用的命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 命名空间的使用 ( 引用 )
using MyGame;

#region 知识点 1 | 命名空间基本概念
// 概念：
// 命名空间是用来组织和重用代码的
// 作用：
// 命名空间就像是一个工具包，类就像是一件一件的工具，都是申明在命名空间当中的
#endregion

#region 知识点 2 |命名空间的使用
// 基本语法：
// namespace 命名空间名称
// {
//     类
//     类
// }

namespace MyGame
{
	class GameObject
	{

	}
}
// 注意：
// 允许存在同名的命名空间，相当于分步组成了一个整体
// 不仅如此，命名空间还可以分步到不同的文件当中
namespace MyGame
{
	class Player : GameObject
	{

	}
}
#endregion

#region 知识点 3 | 不同命名空间中的相互使用，需要引用命名空间或者指明出处
// 引用 |
// 使用时，需要在文件最开头，添加下面的字段：
// using 命名空间名称;
// using 命名空间名称;

// 指明出处 |
// 使用时，在需要使用的地方，使用下面的语法：
// 命名空间名称.类 对象名称 = new 命名空间.类();

namespace GiveAExample
{
	class GiveAGift
	{

	}
}
#endregion

#region 知识点 4 | 不同命名空间中允许有同名类
// 不同命名空间中的同名类，在使用的时候，只能通过指明出处进行使用
// 否则会报错
namespace ToolsBag1
{
	class ExampleClass
	{
		public void GiveFeedback()
		{
			Console.WriteLine("ToolsBag 1");
		}
	}
}
namespace ToolsBag2
{
	// 在不同的命名空间当中，是允许有同名类的
	class ExampleClass
	{
		public void GiveFeedback()
		{
			Console.WriteLine("ToolsBag 2");
		}
	}
}
#endregion

#region 知识点 5 | 命名空间中可以包含多个命名空间
namespace MyGame
{
	namespace UI
	{
		class Image
		{

		}
	}

	namespace Game
	{
		class Image
		{

		}
	}
}
#endregion

#region 知识点 6 | 关于修饰类的访问修饰符
// 注意：
// 命名空间内的类，默认都是为 internal ( 只能在该程序集内使用)

// public   —— 公共的
// internal —— 内部的，只能在该程序集内使用
// abstract —— 抽象类
// sealed   —— 密封类
// partial  —— 分部类
#endregion

namespace Lesson21_面向对象相关_命名空间
{
	class Program
	{
		static void Main(string[] args)
		{
			// 知识点 3 |
			// 在引用命名空间以后，
			// 之后，就可以使用命名空间里面的类了：
			GameObject game = new GameObject();
			// 在不引用命名空间时，
			// 可以通过下面的方法指明命名空间使用：
			GiveAExample.GiveAGift gift = new GiveAExample.GiveAGift();

			// 知识点 4 |
			// 即使在代码开头引用了命名空间，但是在遇到同名类时，
			// 仍然需要通过指明命名空间的方式进行使用
			ToolsBag1.ExampleClass example1 = new ToolsBag1.ExampleClass();
			ToolsBag2.ExampleClass example2 = new ToolsBag2.ExampleClass();
			example1.GiveFeedback();
			example2.GiveFeedback();

			// 知识点 5 |
			// 即使已经引用了 MyGame 但是在访问其中的 Game 命名空间时，仍然需要再次引用
			// 否则就需要像下面这样，进行指明
			// 同样，如果需要使用 MyGame 下的 Game 和 UI 当中相同的类 Image ，也是要进行指明的
			MyGame.Game.Image image1 = new MyGame.Game.Image();
			MyGame.UI.Image image2 = new MyGame.UI.Image();
		}
	}

	#region 总结 |
	// 1. 命名空间是一个工具包，用来管理类的
	// 2. 不同命名空间中，可以有同名的类
	// 3. 不同命名空间中相互使用，需要使用 using 引用命名空间，或者指明出处
	// 4. 命名空间可以包裹命名空间
	#endregion
}
