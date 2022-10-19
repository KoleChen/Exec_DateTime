using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入DVD借閱日期:");
			string borrowdate = Console.ReadLine();
			DateTime borrow = Convert.ToDateTime(borrowdate);
			DateTime returndate =borrow.AddDays(3);
			Console.WriteLine($"歸還日期為:{returndate:yyyy/MM/dd}");
		}
	}
}
