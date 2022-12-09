using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_4_2
{
	class Programm
	{
		static void res(int n, int index = 1)
		{
			if (index > n)
			{
				return;
			}

			for (int i = index; i >= 1; i--)
			{
				Console.Write(i + "\t");
			}

			index++;
			Console.WriteLine();

			res(n, index);
		}

		static void Main(string[] agrs)
		{
			try
			{
				int n;

				while (true)
				{
					Console.Write("Введите n: ");
					n = Convert.ToInt32(Console.ReadLine());

					if (n >= 0)
					{
						break;
					}

					Console.WriteLine("n не может быть меньше или равном 0");
				}

				res(n);
			}
			catch
			{
				Console.WriteLine("Введите корректные значения");
			}


		}
	}
}