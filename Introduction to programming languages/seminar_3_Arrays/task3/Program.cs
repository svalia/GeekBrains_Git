// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний ит.д. 
// Результат запишите в новый массив.
// Пример[1 3 2 4 2 3] => [3 6 8][2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

void Main()
{
	int arraySize = ReadInt("Введите кол-во числе в массиве: ");
	int[] array = GenerateArray(arraySize, -9, 9);
	PrintArray(array);
	System.Console.WriteLine("");
	PrintArray(FindPair(array));
}

int[] FindPair(int[] myArray)
{
	int[] newArray = new int[myArray.Length / 2]; // деление вернет целое число 7 / 2 -> 3

	for (int i = 0; i < myArray.Length / 2; i++)
	{
		newArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
	}

	return newArray;
}

int ReadInt(string msg)
{
	System.Console.WriteLine(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
	int[] myArray = new int[size];
	for (int i = 0; i < myArray.Length; i++)
	{
		myArray[i] = new Random().Next(leftRange, rightRange + 1);
	}
	return myArray;
}

void PrintArray(int[] arrayForPrint)
{
	for (int i = 0; i < arrayForPrint.Length; i++)
	{
		System.Console.WriteLine(arrayForPrint[i] + " ");
	}
}

Main();