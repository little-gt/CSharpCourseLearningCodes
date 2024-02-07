namespace 作业_Lesson10
{
	class Program
	{
		#region 比较两个数的值并且发回最大的那一个
		static int CompareTwo(int tempNumber1, int tempNumber2)
		{
			if (tempNumber1 > tempNumber2)
			{
				return tempNumber1;
			}
			else
			{
				return tempNumber2;
			}
		}

		static float CompareTwo(float tempNumber1, float tempNumber2)
		{
			if (tempNumber1 > tempNumber2)
			{
				return tempNumber1;
			}
			else
			{
				return tempNumber2;
			}
		}

		static double CompareTwo(double tempNumber1, double tempNumber2)
		{
			if (tempNumber1 > tempNumber2)
			{
				return tempNumber1;
			}
			else
			{
				return tempNumber2;
			}
		}
		#endregion

		#region 比较n个数并且返回其中最大的一个
		static int FindArrayMAX(int[] tempArray)
		{
			int tempMAX = 0;
			for (int i = 0; i < tempArray.Length; i++)
			{
				if (tempMAX <= tempArray[i])
				{
					tempMAX = tempArray[i];
				}
			}
			return tempMAX;
		}

		static float FindArrayMAX(float[] tempArray)
		{
			float tempMAX = 0;
			for (int i = 0; i < tempArray.Length; i++)
			{
				if (tempMAX <= tempArray[i])
				{
					tempMAX = tempArray[i];
				}
			}
			return tempMAX;
		}

		static double FindArrayMAX(double[] tempArray)
		{
			double tempMAX = 0;
			for (int i = 0; i < tempArray.Length; i++)
			{
				if (tempMAX <= tempArray[i])
				{
					tempMAX = tempArray[i];
				}
			}
			return tempMAX;
		}
		#endregion
		static void Main(string[] args)
		{
		}
	}
}
