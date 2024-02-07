using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== 习题 1 ======");
			#region 习题1 | 定义一个变量存储你的年龄，十年后你的年龄是多少？请输出到控制台
			int userAge;
			int userAge10;
			Console.WriteLine("请输入您的年龄：");
			try
			{
				userAge = Convert.ToInt32(Console.ReadLine());
				userAge10 = userAge + 10;
				userAge += 10;
				Console.WriteLine("□ 十年以后您的年龄是:" + userAge);
				Console.WriteLine("□ 十年以后您的年龄是:" + userAge10);
			}
			catch
			{
				Console.WriteLine("☆ 输入了不合法的内容，已跳过");
			}
			#endregion

			Console.WriteLine("====== 习题 2 ======");
			#region 习题2 | 计算一个半径为 r 的圆的面积和周长
			try
			{
				Console.WriteLine("请输入圆的半径：");
				float roundRadius;
				float roundSize;
				float roundCircumference;
				roundRadius = float.Parse(Console.ReadLine());
				roundSize = 3.1415926f * roundRadius * roundRadius;
				roundCircumference = 2f * 3.1415926f * roundRadius;
				Console.WriteLine("□ 圆的面积：" + roundSize);
				Console.WriteLine("□ 圆的周长：" + roundCircumference);
			}
			catch
			{
				Console.WriteLine("☆ 输入了不合法的内容，已跳过");
			}
			#endregion

			Console.WriteLine("====== 习题 3 ======");
			#region 习题3 | 计算任意三门成绩的总分、平均分打印到控制台。
			int scoreSub1;
			int scoreSub2;
			int scoreSub3;
			int scoreTotal;
			int scoreAverage;
			try
			{
				Console.WriteLine("请输入第 1 门课程的成绩：");
				scoreSub1 = int.Parse(Console.ReadLine());
				Console.WriteLine("请输入第 2 门课程的成绩：");
				scoreSub2 = int.Parse(Console.ReadLine());
				Console.WriteLine("请输入第 3 门课程的成绩：");
				scoreSub3 = int.Parse(Console.ReadLine());
				scoreTotal = scoreSub1 + scoreSub2 + scoreSub3;
				scoreAverage = scoreTotal / 3;
				Console.WriteLine("□ 您的三门课程的总分：" + scoreTotal);
				Console.WriteLine("□ 您的三门课程的平均分：" + scoreAverage);
			}
			catch
			{
				Console.WriteLine("☆ 输入了不合法的内容，已跳过");
			}
			#endregion

			Console.WriteLine("====== 习题 4 ======");
			#region 习题4 | 商店T恤的价格为285元/件，裤子的价格为720元/条，小李在该店卖了2件T恤和3条裤子，请计算小李该付多少钱？打3.8折后呢？
			int priceTshirt = 285;
			int pricePants = 720;
			int priceTotal;
			float priceDiscount;
			int numberTshirt;
			int numberPants;
			try
			{
				Console.WriteLine("T恤的价格为285元/件，请输入购买的数量：");
				numberTshirt = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("裤子的价格为720元/条，请输入购买的数量：");
				numberPants = Convert.ToInt32(Console.ReadLine());
				priceTotal = numberTshirt * priceTshirt + numberPants + pricePants;
				priceDiscount = priceTotal * 0.38f;
				Console.WriteLine("□ □ □ □ □ □");
				Console.WriteLine("○ 购买数目细节：" + "\n" + "T恤：" + numberTshirt + "件 |裤子：" + numberPants + "件");
				Console.WriteLine("○ 详细价格项目：" + "\n" + "总价：" + priceTotal + "元 |会员折扣价：" + priceDiscount + "元");
				Console.WriteLine("□ □ □ □ □ □");
			}
			catch
			{
				Console.WriteLine("☆ 输入了不合法的内容，已跳过");
			}
			#endregion

			Console.WriteLine("====== 习题 5 ======");
			#region 习题5 | 有两个数a=99，b=87，请写出两种方法交换他们的值，让a=87，b=99
			int a;
			int b;
			int cache_A;
			int cache_B;
			int cache_C;

			// 方法 1 |
			a = 99;
			b = 87;
			cache_A = a;
			cache_B = b;
			b = cache_A;
			a = cache_B;
			Console.WriteLine("a:" + a + " b:" + b);
			// 方法 2 |
			a = 99;
			b = 87;
			cache_C = a;
			a = b;
			b = cache_C;
			Console.WriteLine("a:" + a + " b:" + b);
			#endregion

			Console.WriteLine("====== 习题 6 ======");
			#region 习题6 | 请把987652秒通过代码转为n天n小时n分钟n秒显示在控制台中
		    long timeInPut;
			long timeDay;
			long timeHour;
			long timeMin;
			long timeSecond;
			
			try
			{
				Console.WriteLine("请输入要转换的秒数：");
				timeInPut = Convert.ToInt64(Console.ReadLine());
				timeDay = timeInPut / 86400;
				timeInPut = timeInPut - (timeDay * 86400);
				timeHour = timeInPut / 3600;
				timeInPut = timeInPut - (timeHour * 3600);
				timeMin = timeInPut / 60;
				timeInPut = timeInPut - (timeMin * 60);
				timeSecond = timeInPut;
				Console.WriteLine("□ 转为：" + timeDay + "天" + timeHour + "时" + timeMin + "分" + timeSecond + "秒");
			}
			catch
			{
				Console.WriteLine("☆ 输入了不合法的内容，已跳过");
			}
			#endregion
		}
	}
}
