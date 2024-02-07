using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson19
{
	#region 习题 1 | 人、汽车、房子都需要登记
	// 登记接口
	#region 接口 | 登记
	interface IRegister
	{
		string[] InformationRegistrationList
		{
			set;
			get;
		}

		/// <summary>
		/// 信息登记
		/// </summary>
		/// <param name="index">信息登记编号</param>
		/// <param name="name">信息登记名称</param>
		/// <returns></returns>
		bool InformationRegistration(int index, string name);

		/// <summary>
		/// 登记查询
		/// </summary>
		/// <param name="index">信息登记编号</param>
		/// <returns></returns>
		string InformationRegistrationSearch(int index);
	}
	#endregion
	// 人
	#region 类 | 人
	class Person : IRegister
	{
		public string name;
		public string[] InformationRegistrationList
		{
			get;
			set;
		}

		public bool InformationRegistration(int index, string name)
		{
			if (InformationRegistrationList.Length < index)
			{
				// 所需要的 index 大于 string[] 的最大值
				// 进行迁移和赋值
				string[] tempIRL = new string[index];
				for (int i = 0; i < InformationRegistrationList.Length; i++)
				{
					tempIRL[i] = InformationRegistrationList[i];
				}
				tempIRL[index - 1] = name;
				InformationRegistrationList = tempIRL;
				return true;
			}
			else
			{
				// 判断在这个index下是否已经存在值，
				// 如果已经存在，则不写入；如果不存在，则写入值
				if (InformationRegistrationList[index-1] != null)
				{
					return false;
				}
				else
				{
					InformationRegistrationList[index - 1] = name;
					return true;
				}
			}
		}

		public string InformationRegistrationSearch(int index)
		{
			throw new NotImplementedException();
		}
	}
	#endregion
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
