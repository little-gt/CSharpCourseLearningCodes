using System;

namespace Lesson8_ref和out
{
	class Program
	{
		// 总结 |
		// 1. ref和out的使用：解决值类型和引用类型 在函数内部 改值 或者 重新赋值 时和外部进行同步
		// 2. 使用上都是在申明和传入参数时，在参数前加ref或out.
		// 3. 区别
		//    ref传入的变量必须初始化 但是在内部 可以修改可以不修改
		//    out传入的变量不用初始化 但是在内部 必须进行修改(赋值)

		#region 知识点 1 | 学习ref和out的原因
		// 学习ref和out的原因
		// 它们可以解决 在函数内部改变外部传入的内容 里面变了 外面也会跟着变

		static void ChangeValue(int value)
		{
			value = 3;
		}
		static void ChangeArray1(int[] arr)
		{
			arr[0] = 233;
		}
		static void ChangeArray2(int[] arr)
		{
			arr = new int[] { 666, 233, 888, 555 };
		}
		#endregion

		#region 知识点 2 | ref和out的使用
		// ref 的使用
		static void ChangeValueRef(ref int value)
		{
			value = 888;
		}
		// out 的使用
		static void ChangeValueOut(out int value)
		{
			value = 233;
		}
		#endregion

		static void Main(string[] args)
		{
			// 传入函数的参数，相当于 int value = valueInt;
			Console.WriteLine("====== -| 1 |- ======");
			int valueInt = 1;
			ChangeValue(valueInt);
			Console.WriteLine(valueInt);

			// 传入函数的参数，相当于 int[] arr = valueArrayInt;
			// 相当于把 arr 和 valueArrayInt 的地址都指向同一个堆内存空间的位置
			// 所有函数内外的值会同步变化
			Console.WriteLine("====== -| 2 |- ======");
			int[] valueArrayInt = { 0, 1, 2, 3, 4 };
			ChangeArray1(valueArrayInt);
			Console.WriteLine(valueArrayInt[0]);

			// 因为使用了 new int[] 所以两个数组的地址不再一致
			Console.WriteLine("====== -| 3 |- ======");
			ChangeArray2(valueArrayInt);
			Console.WriteLine(valueArrayInt[0]);

			// 使用 ref 以后，可以使得函数内外的变量值保持一致
			Console.WriteLine("====== -| 4 |- ======");
			ChangeValueRef(ref valueInt);
			Console.WriteLine(valueInt);

			// 使用 out 以后，可以使得函数内外的变量值保持一致
			Console.WriteLine("====== -| 5 |- ======");
			ChangeValueOut(out valueInt);
			Console.WriteLine(valueInt);

			#region 知识点 3 | ref和out的区别
			// 1. ref 传入的变量必须初始化 out不需要初始化
			// 2. out 传入的变量必须在内部赋值 ref不用
			int differentRef = 233;
			ChangeValueRef(ref differentRef);
			int differentOut;
			ChangeValueOut(out differentOut);
			// ☆ ref传入的变量必须要初始化 但是在传入的函数内部 可以修改也可以不修改
			// ☆ out传入的变量可以不初始化 但是在传入的函数内部 必须进行修改(赋值)
			#endregion
		}
	}
}
