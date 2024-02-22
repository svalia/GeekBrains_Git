// Задайте массив из 10 элементов, заполненный числами изпромежутка [-10, 10]. 
// Замените отрицательные элементы наположительные, а положительные на отрицательные.
// Пример: [1 -5 6]=> [-1 5 -6]
void Main()
{
	int[] array = GenerateArray(10, -10, 10);
	System.Console.WriteLine("Сгенерированный массив: ");
	PrintArray(array);
	ChangeArray(array);
	System.Console.WriteLine("");
	System.Console.WriteLine("Измененный массив: ");
	PrintArray(array);
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
		System.Console.Write(arrayForPrint[i] + "\t"); // "\t" - знак табуляции
	}
}

void ChangeArray(int[] myArray)
{
	for (int i = 0; i < myArray.Length; i++)
	{
		myArray[i] = -myArray[i]; //можно использвовать myArray[i] *= -1, что экивалентно myArray[i] = myArray[i] * -1
	}
}
Main();