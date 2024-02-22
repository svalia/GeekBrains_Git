// Задайте массив. Напишите программу, которая определяет,присутствует ли заданное число в массиве. 
// Программадолжна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

void Main()
{
	int arraySize = ReadInt("Введите кол-во числе в массиве: ");

	int[] array = GenerateArray(arraySize, -9, 9);
	
	PrintArray(array);

	int number = ReadInt("Введите искомое число: ");

	bool numberIsFinded = NumberIsExist(array, number);

	if (numberIsFinded == true)
	{
		System.Console.WriteLine("Да");
	}
	else
	{
		System.Console.WriteLine("Нет");
	}
}

int ReadInt(string msg)
{
	System.Console.WriteLine(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray (int size, int leftRange, int rightRange)
{
	int[] myArray = new int[size];
	for (int i = 0; i < myArray.Length; i++)
	{
		myArray[i] = new Random().Next(leftRange, rightRange + 1);
		// System.Console.Write(myArray[i] + " "); так лучше не делать, т.к. это нарушает принцип SOLID в ООП, 1 метод - 1 отвественность. Если например нужно будет в программе, 1 массив вывести, а другой не ввыводить, то придется править метод или создавать еще один, поэтому лучше сразу разносить по методам только одну отвествтенность.
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

bool NumberIsExist(int[] myArray, int number)
{
		for (int i = 0; i < myArray.Length; i++)
	{
		if (myArray[i] == number)
		{
			return true;
		}
	}
	return false;
}

Main();