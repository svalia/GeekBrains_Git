// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
	int[] array = { 1, 2, 3, 4, 5 }; // Пример массива
	PrintArrayReverse(array, array.Length - 1);
}

// Метод для рекурсивной печати элементов массива с конца
void PrintArrayReverse(int[] array, int index)
{
	if (index < 0) // Базовый случай рекурсии
	{
		return;
	}

	Console.WriteLine(array[index]); // Печать текущего элемента
	PrintArrayReverse(array, index - 1); // Рекурсивный вызов для следующего элемента
}
Main();
