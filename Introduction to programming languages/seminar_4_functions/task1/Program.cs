
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная

using System;

class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("Введите число или 'q' для выхода: ");
			string input = Console.ReadLine();

			if (input == "q")
			{
				break;
			}

			try
			{
				int number = Convert.ToInt32(input);
				int sum = 0;

				while (number > 0)
				{
					sum += number % 10;
					number /= 10;
				}

				if (sum % 2 == 0)
				{
					Console.WriteLine("Сумма цифр четная. Программа завершена.");
					break;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
			}
		}
	}
}
