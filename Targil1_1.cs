using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = Convert.ToInt32(Console.ReadLine());
			
			int m = 2;
			while (a % m != 0 && m < a)
			{
				m++;
			}
			if (a == m || a == 1)
			{
				Console.WriteLine("This is Prime number");

			}
			else
				Console.WriteLine("This is NOT a Prime number");
			
		}
	}
}
