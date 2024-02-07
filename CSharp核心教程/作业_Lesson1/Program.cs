using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业_Lesson1
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 练习题 1 |
			// 将下面的事物进行分类，可重复
			// 机器人、机器、人、猫、张阿姨、隔壁老王、汽车、飞机、向日葵、菊花、太阳、星星、荷花

			/*   ======== 解答 ========
			 *   机器：机器人、机器、汽车、飞机
			 *   人类：人、张阿姨、隔壁老王1
			 *   动物：猫、人、张阿姨、隔壁老王
			 *   植物：向日葵、菊花、荷花
			 *   天体：星星
			 */
			#endregion

			#region 练习题 2 |
			// GameObject A = new GameObject();
			// GameObject B = A;
			// B = null;
			// A目前等于多少 ?

			/*   ======== 解答 ========
			 *   刚开始 A 和 B 的栈内存中指向堆内存空间的地址是一致的
			 *   之后 B = null 将 B 在栈内存中的地址清空了，但是不影响 A 在栈内存中存储的地址
			 *   所以 A 还是 GameObject
			 */
			#endregion

			#region 练习题 3 |
			// GameObject A = new GameObject();
			// GameObject B = A;
			// B = new GameObject0;
			// A和B有什么关系？

			/*   ======== 解答 ========
			 *   刚开始时，B 和 A 在栈内存中的地址是一样的
			 *   之后 B 清空栈内存中的地址以后
			 *   重新在堆内存中申请了空间 并且将地址填入 B 的栈内存
			 *   所以 A 、B 没有关系
			 */
			#endregion
		}
	}
}
