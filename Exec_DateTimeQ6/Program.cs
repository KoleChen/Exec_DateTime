using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int day = Convert.ToInt32(today.Day);//取得今天是"幾號" 並轉換成Int 再設條件

			if(1<=day&&day<=10)
			{
				Console.WriteLine("今天是本月的上旬");
				return;
			}
			else if(11<=day&&day<=20)
			{
				Console.WriteLine("今天是本月的中旬");
				return ;
			}
			else if(21<=day&&day<=30)
			{
				Console.WriteLine("今天是本月的下旬");
				return;
			}
		}
	}
}
