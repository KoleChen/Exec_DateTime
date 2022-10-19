using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;//取得今天日期
			DateTime NextMonth = today.AddMonths(1);//加1個月 取得下月的今日
			DateTime NextMonthFirstDay = new DateTime(NextMonth.Year, NextMonth.Month, 1);//再找到下月的第一天
			DateTime ThisMonthLastDay = NextMonthFirstDay.AddDays(-1);//往前減1天 取得本月最後一天
			Console.WriteLine($"本月最後一天為:{ThisMonthLastDay:yyyy/MM/dd}");
		}
	}
}
