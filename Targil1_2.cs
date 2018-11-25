using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter 3 numbers");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int c = Convert.ToInt32(Console.ReadLine());
			int m = 2;
			while (a % m != 0 && m < a)
			{
				m++;
			}
			if (a == m || a == 1)
			{
				m = 2;
				while (b % m != 0 && m < b)
				{
					m++;
				}
				if (b == m || b == 1)
				{
					m = 2;
					while (c % m != 0 && m < c)
					{
						m++;
					}
					if (c == m || c == 1)
					{
						int sum = a + b + c;
						Console.WriteLine(sum);
					}
				}
			}
			else
			{
				Console.WriteLine("NOT a Prime number");
			}

				}
				
	}
}
