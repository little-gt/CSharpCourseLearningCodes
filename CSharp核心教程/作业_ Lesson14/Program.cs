using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业__Lesson14
{
	#region 基础基类 | 工人类
	public class Worker
	{
		string occupation;
		string description;

		public Worker(string strOcc, string strDes)
		{
			occupation = strOcc;
			description = strDes;
		}

		public void DoWork()
		{
			Console.WriteLine("WORKING...");
		}
	}
	#endregion

	#region 工人子类 |
	// 程序员
	public class Coders : Worker
	{
		public Coders(string strOcc, string strDes) : base(strOcc, strDes)
		{

		}
	}
	// 策划
	public class Mastermind : Worker
	{
		public Mastermind(string strOcc, string strDes) : base(strOcc, strDes)
		{

		}
	}
	// 美术家
	public class Artist : Worker
	{
		public Artist(string strOcc, string strDes) : base(strOcc, strDes)
		{

		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			Coders coders = new Coders("程序员", "程序员（Programmer）是一种职业，其主要工作职责是设计、编写、测试和维护计算机软件程序。在现代信息技术行业中，程序员的角色可以根据项目需求和团队结构划分为不同的层级和专业领域。");
			Mastermind mastermind = new Mastermind("策划", "策划是负责制定和执行项目计划，通过整合资源、创新思维以及市场分析，以实现特定目标或解决复杂问题的专业人员。");
			Artist artist = new Artist("艺术家", "艺术家通过创作视觉艺术、表演艺术、文学艺术等多种形式的作品，表达情感、思想和审美理念，为社会提供精神文化产品与体验的专业人士。");
		}
	}
}
