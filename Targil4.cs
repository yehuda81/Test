using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil4
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				int stars = Convert.ToInt32(Console.ReadLine());
				if (stars >= 1 && stars <= 15)
				{
					stars = (stars - 1) * 2 + 1;
					int m = stars / 2 + 1;
					int j = 1;
					while (j <= stars && stars >= 1)
					{
						for (int i = 1; i < m; i++)
						{
							Console.Write(" ");
						}
						for (int i = 1; i <= j; i++)
						{
							Console.Write("*");
						}
						m--;
						j = j + 2;
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("wrong number");
				}

			}
		}
	}
}
