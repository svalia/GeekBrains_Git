// Назовём число «интересным» если его суммацифр чётная• 
// Создать двумерный массив, состоящий изцелых чисел. Вывести на экран «интересные»элементы массива

void Main()
{
	int[,] matrix = CreateMatrix(3, 4);
	Console.WriteLine("Сгенерированный двумерный массив:");
	ShowMatrix(matrix);
	Console.WriteLine();
	Console.WriteLine("Найденные в массиве интересные числа: ");
	foreach (int e in matrix)
	{
		if (IsInteresting(e) == true)
		{
			Console.WriteLine(e);
		}
	}
}

int[,] CreateMatrix(int rowCount, int columnCount) // метод создания двумерного массива
{
	int[,] matrix = new int[rowCount, columnCount];

	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(1, 1000);
		}
	}
	return matrix;
}
void ShowMatrix(int[,] matrix) // метод вывода двумерного массива
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}

bool IsInteresting(int value)
{
	int sumOfDigits = GetSumOfDigits(value);
	if (sumOfDigits % 2 == 0)
	{
		return true;
	}
	return false;
}

int GetSumOfDigits(int value)
{
	int sum = 0;
	while (value > 0) //цикл продолжается пока после деления на 10 value > 0
	{
		sum = sum + value % 10; //получая отсаток от деления числа на 10 мы получаем самую правую цифру
		value = value / 10; // уменьшаем исходное число отрезая правую цифру делением на 10
	}
	return sum;
}

Main();