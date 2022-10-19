using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入書籍借閱日期:");
			string input = Console.ReadLine();
			DateTime borrowdate = Convert.ToDateTime(input);
			DateTime returndate = borrowdate.AddMonths(1);
			Console.WriteLine($"歸還日期為:{returndate:yyyy/MM/dd}");

		}
	}
}
