
void Main()
{
	int[,] matrix = CreateMatrix(4, 5);
	ShowMatrix(matrix);
}
int[,] CreateMatrix(int rowCount, int columnCount)
{
	int[,] matrix = new int[rowCount, columnCount];

	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)// array.GetLength(0) - узнаем сколько строк в двумерном массиве, где 0 означает что мы запрашиваем кол-во строк (т.е. одномерных массивов)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)// // array.GetLength(1) - узнаем сколько элементов внутри каждого одномерного массива, находящихся в двумерном массиве, где 1 указывает как раз на кол-во столбцов (элементов внутри одномерных массивов) двумерного массива
		{
			matrix[i, j] = rnd.Next(1, 11);
		}
	}
	return matrix;
}

void ShowMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} "); //интерполяция строк
		}
		Console.WriteLine();
	}
}
Main();