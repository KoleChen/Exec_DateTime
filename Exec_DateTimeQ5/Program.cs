using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入年分:");
			string input = Console.ReadLine();
			int year = Convert.ToInt32(input);//將輸入的年份轉為int整數型態
			DateTime today = new DateTime(year, 01, 01);//將今天設定為輸入年份的1月1號
			DayOfWeek weekend = today.DayOfWeek;//找到這天是星期幾
			//Console.WriteLine(weekend);
			int value = (int)weekend;//找到這天星期幾換算的值 星期日=0 星期一=1...星期六=6
			//Console.WriteLine(value);
			if(value == 1)//如果這天是星期一 那加6天找到第一個星期日
			{
				today = today.AddDays(6);
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
				
			}
			else if(value == 2)//如果這天是星期二 那加5天找到第一個星期日
			{
				today = today.AddDays(5);
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
				
			}
			else if (value == 3)//如果這天是星期三 那加4天找到第一個星期日
			{
				today = today.AddDays(4);
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
				
			}
			else if (value == 4)//如果這天是星期四 那加3天找到第一個星期日
			{
				today = today.AddDays(3);
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
				
			}
			else if (value == 5)//如果這天是星期五 那加2天找到第一個星期日
			{
				today = today.AddDays(2);
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
				
			}
			else if(value==6)//如果這天是星期六 那加1天找到第一個星期日
			{
				today = today.AddDays(1);
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
				
			}
			else //如果這天剛好是星期日 直接印出來
			{
				Console.WriteLine($"今年的第一個星期日為:{today:yyyy/MM/dd}");
			}
			Console.WriteLine("今年的每一個星期日分別為:");

			do //從第一個星期日一直加7天
			{
				Console.WriteLine($"{today:yyyy/MM/dd}");
				today = today.AddDays(7);	
			}
			while(today.Year == year);//直到找到今年每一個星期日(跨到下一年停止)
		}
	}
}
