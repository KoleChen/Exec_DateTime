using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today =DateTime.Today;
			DateTime newdate = new DateTime(today.Year,today.Month,1);//設定新的newdate年月和目前一樣 日強制改成1號 即可找到本月1號
			Console.WriteLine($"本月一號為:{newdate:yyyy/MM/1}");

		}
	}
}
