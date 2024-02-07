using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson3
{
	#region 数组 | 常见过敏原
	enum E_CommonAllergens
	{
		CerealsWithGluten,    // 含有麸质的谷物
		Crustacean,           // 甲壳纲类动物
		Fish,                 // 鱼类
		Eggs,                 // 蛋类
		Peanuts,              // 花生
		Soya,                 // 大豆
		MilkAndDairyProducts, // 奶、乳制品
		Nuts,                 // 坚果
	}
	#endregion

	#region 数组 | 生理性别
	enum E_BiologicalSex
	{
		undefined, // 未设置
		male,      // 男
		female,    // 女
	}
	#endregion

	#region 类 | 人类
	class Person
	{
		/// <summary>
		/// 方法 | 说话，将内容打印到控制台
		/// </summary>
		/// <param name="context">要说的内容</param>
		public void Speak(string context)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("> ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(name);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" 说: {0}", context);
		}

		/// <summary>
		/// 方法 | 吃东西，判断能不能吃等，并且输出详细信息到控制台
		/// </summary>
		/// <param name="food">要吃的东西</param>
		public void Eat(Food food)
		{
			if (food.IsContainsAllergens(allergicTo))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("× ");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(name);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(" 是不能吃 ");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(food.name);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" 的，因为食物中含有潜在的过敏源！");
				Console.ForegroundColor = ConsoleColor.White;
				return;
			}
			if (IsOverweight())
			{
				if (food.calorie > 10000)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("× ");
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.Write(name);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" 是不能吃 ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write(food.name);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(" 的，因为食物的卡路里超标了！");
					Console.ForegroundColor = ConsoleColor.White;
					return;
				}
			}
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("> ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(name);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" 吃掉了 {0} ({1}cal)", food.name, food.calorie);
		}

		/// <summary>
		/// 方法 | 是否超重
		/// </summary>
		/// <returns></returns>
		public bool IsOverweight()
		{
			int BMI = weight / (height * height);
			if (BMI >= 18.5 && BMI <= 23.9)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public string name;
		public int age;
		public int weight;
		public int height;
		public E_BiologicalSex sex;
		public E_CommonAllergens[] allergicTo;
	}
	#endregion

	#region 类 | 学生

	#endregion

	#region 类 | 食物
	class Food
	{
		/// <summary>
		/// 方法 | 判断是否食物中是否含有过敏原成分
		/// </summary>
		/// <param name="listAllergens"></param>
		/// <returns></returns>
		public bool IsContainsAllergens(E_CommonAllergens[] listAllergens)
		{
			// 判断 可能过敏 是否为空
			if (listAllergens == null)
			{
				return false;
			}
			// 判断 食物的过敏源成分 是否为空
			if (allergen == null)
			{
				return false;
			}

			for (int i = 0; i < allergen.Length; i++)
			{
				for (int j = 0; j < listAllergens.Length; j++)
				{
					if (listAllergens[j] == allergen[i])
					{
						return true;
					}
				}
			}

			return false;
		}

		/// <summary>
		/// 方法 | 添加过敏源信息
		/// </summary>
		/// <param name="needAdd">需要添加的过敏原</param>
		public void AddAllergen(E_CommonAllergens needAdd)
		{
			if (allergen == null)
			{
				allergen = new E_CommonAllergens[] { needAdd };
				return;
 			}

			E_CommonAllergens[] tempArr = new E_CommonAllergens[allergen.Length + 1];
			for (int i = 0; i < allergen.Length; i++)
			{
				tempArr[i] = allergen[i];
			}
			tempArr[tempArr.Length - 1] = needAdd;
			allergen = tempArr;
			return;
		}

		/// <summary>
		/// 食物的名字
		/// </summary>
		public string name;
		/// <summary>
		/// 食物的热量(单位：cal)
		/// </summary>
		public int calorie;
		/// <summary>
		/// 食物中可能含有的过敏原
		/// </summary>
		public E_CommonAllergens[] allergen;
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();
			Person p2 = new Person();
			Person p3 = new Person();
			p1.name = "sample 1";
			p2.name = "sample 2";
			p3.name = "sample 3";
		}
	}
}
