// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
	static void Main()
	{
		Random random = new Random();
		int[] array = new int[10]; // Создаем массив из 10 элементов

		// Заполняем массив случайными трехзначными числами
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = random.Next(100, 1000); // Случайные числа от 100 до 999
		}

		// Выводим массив для наглядности
		Console.WriteLine("Массив случайных трехзначных чисел:");
		foreach (int number in array)
		{
			Console.Write(number + " ");
		}
		Console.WriteLine(); // Для переноса строки

		// Подсчитываем количество четных чисел в массиве
		int evenCount = 0;
		foreach (int number in array)
		{
			if (number % 2 == 0)
			{
				evenCount++;
			}
		}

		// Выводим результат
		Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
	}
}