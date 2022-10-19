using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTimeQ7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime time = DateTime.Now;//取得現在時間的小時數
			Console.WriteLine($"現在時間是{time:H:mm}");

			int hour =Convert.ToInt32(time.Hour);//將現在時間的小時取出來轉換成Int 再設條件
			if (0 <= hour && hour < 12)
			{
				Console.WriteLine("早安");
			}
			else if(12<=hour&&hour<18)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}


		}
	}
}
