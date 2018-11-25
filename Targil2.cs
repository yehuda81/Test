using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number of seconds");
			sec();

		}

		private static void sec()
		{
			int secondsTotal = Convert.ToInt32(Console.ReadLine());
			if (secondsTotal >= 0)
			{
				int days = secondsTotal / 86400;
				int hours = secondsTotal / 3600 - days * 24;
				int minutes = secondsTotal / 60 - hours * 60 - days * 1440;
				int seconds = secondsTotal - minutes * 60 - hours * 3600 - days * 86400;
				Console.Write("days: "); Console.WriteLine(days);
				Console.Write("hours: "); Console.WriteLine(hours);
				Console.Write("minutes: "); Console.WriteLine(minutes);
				Console.Write("seconds: "); Console.WriteLine(seconds);
			}
			else
			{
				Console.WriteLine("Enter a possitive number ");
				sec();
			}
		}
	}
}
