using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number:");
			int number = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= number; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(j);
				}

				for (int j = i + 1; j <= number; j++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}

		}
	}
}
